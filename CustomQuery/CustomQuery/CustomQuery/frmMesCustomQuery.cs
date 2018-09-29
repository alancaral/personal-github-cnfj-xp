using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomQuery
{
    public partial class frmMesCustomQuery : frmBase
    {
        OracleHelpMes oraProdEnv;
        OracleHelpMes oraTestEnv;

        DataTable dtParam;
        string mdQuery = "";
        string mdVersion = "";

        public frmMesCustomQuery()
        {
            InitializeComponent(); ; ;
        }

        private void frmFemCustomQuery_Load(object sender, EventArgs e)
        {
            string prod = ConfigurationManager.AppSettings["PROD"].ToString();
            string test = ConfigurationManager.AppSettings["TEST"].ToString();

            string prodConnectStr = ConfigurationManager.ConnectionStrings[prod].ConnectionString.ToString();
            string testConnectStr = ConfigurationManager.ConnectionStrings[test].ConnectionString.ToString();
            
            oraProdEnv = new OracleHelpMes();
            oraProdEnv.baseStr = prodConnectStr;

            oraTestEnv = new OracleHelpMes();
            oraTestEnv.baseStr = testConnectStr;

            lblEnvProd.Text = prod;
            lblEnvTest.Text = test;

            cmbProdQueryId.Items.AddRange(this.GetCustomQueryList(oraProdEnv).ToArray());
            cmbTestQueryId.Items.AddRange(this.GetCustomQueryList(oraTestEnv).ToArray());

            dtParam = new DataTable();
            dtParam.Columns.Add("Param");
            dtParam.Columns.Add("Value");
            dtParam.TableName = "Param";
        }

        private List<string> GetCustomQueryList(OracleHelpMes ora)
        {
            List<string> lstStr = new List<string>();

            string ssql = "SELECT DISTINCT(QUERYID)  FROM CT_CUSTOMQUERY order by QUERYID";
            DataSet ds = ora.GetDataSet(ssql);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lstStr.Add(dr["QUERYID"].ToString());
                }
            }

            return lstStr;
        }

        private DataSet GetCustomQueryDetail(OracleHelpMes ora, string queryid, string version)
        {
            string ssql = @"SELECT QUERYID,
       VERSION,
       QUERYSTRING,
       OLDQUERYSTRING,
       DESCRIPTION,
       LASTEVENTUSER,
       LASTEVENTDATE
  FROM CT_CUSTOMQUERY
 WHERE NVL (QUERYID, ' ') LIKE :QUERYID AND NVL (VERSION, ' ') LIKE :VERSION";

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = ssql;
            if (string.IsNullOrEmpty(queryid))
            {
                queryid = "%";
            }

            cmd.Parameters.Add(new OracleParameter("QUERYID", queryid));
            cmd.Parameters.Add(new OracleParameter("VERSION", version + "%"));

            DataSet ds = ora.GetDataSet(cmd);

            return ds;
        }

        private void btnProtQuery_Click(object sender, EventArgs e)
        {
            dgvProdQuery.DataSource = GetCustomQueryDetail(oraProdEnv, 
                cmbProdQueryId.Text.Trim(), txtProdVersion.Text.Trim()).Tables[0];            
        }

        private void btnTeseQuery_Click(object sender, EventArgs e)
        {
            dgvTestQuery.DataSource = GetCustomQueryDetail(oraTestEnv,
                cmbTestQueryId.Text.Trim(), txtTestVersion.Text.Trim()).Tables[0];
        }

        #region Query Cell Click
        private void dgvProdQuery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdQuery.CurrentRow == null)
            {
                return;
            }

            string queryid = dgvProdQuery.CurrentRow.Cells["QUERYID"].Value.ToString();
            string version = dgvProdQuery.CurrentRow.Cells["VERSION"].Value.ToString();
            string querystring = dgvProdQuery.CurrentRow.Cells["QUERYSTRING"].Value.ToString();
            string oldquerystring = dgvProdQuery.CurrentRow.Cells["OLDQUERYSTRING"].Value.ToString();
            string description = dgvProdQuery.CurrentRow.Cells["DESCRIPTION"].Value.ToString();
            string lasteventuser = dgvProdQuery.CurrentRow.Cells["LASTEVENTUSER"].Value.ToString();
            string lasteventdate = dgvProdQuery.CurrentRow.Cells["LASTEVENTDATE"].Value.ToString();

            txtProdNQueryid.Text = queryid;
            txtProdNVersion.Text = version;
            txtProdCurrentQuery.Text = querystring;
            txtProdOldQuery.Text = oldquerystring;
            txtProdEventUser.Text = lasteventuser;
            txtProdEventTime.Text = lasteventdate;
            txtProdComment.Text = description;

            btnProdNew.Enabled = true;
            txtProdNQueryid.ReadOnly = true;
            txtProdNVersion.ReadOnly = true;

            mdQuery = queryid;
            mdVersion = version;
        }

        private void dgvTestQuery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTestQuery.CurrentRow == null)
            {
                return;
            }

            string queryid = dgvTestQuery.CurrentRow.Cells["QUERYID"].Value.ToString();
            string version = dgvTestQuery.CurrentRow.Cells["VERSION"].Value.ToString();
            string querystring = dgvTestQuery.CurrentRow.Cells["QUERYSTRING"].Value.ToString();
            string oldquerystring = dgvTestQuery.CurrentRow.Cells["OLDQUERYSTRING"].Value.ToString();
            string description = dgvTestQuery.CurrentRow.Cells["DESCRIPTION"].Value.ToString();
            string lasteventuser = dgvTestQuery.CurrentRow.Cells["LASTEVENTUSER"].Value.ToString();
            string lasteventdate = dgvTestQuery.CurrentRow.Cells["LASTEVENTDATE"].Value.ToString();

            txtTestNQueryId.Text = queryid;
            txtTestNVersion.Text = version;
            txtTestCurrentQuery.Text = querystring;
            txtTestOldQuery.Text = oldquerystring;
            txtTestEventUser.Text = lasteventuser;
            txtTestEventTime.Text = lasteventdate;
            txtTestComment.Text = description;

            btnTestNew.Enabled = true;
            txtTestNQueryId.ReadOnly = true;
            txtTestNVersion.ReadOnly = true;

            mdQuery = queryid;
            mdVersion = version;
        }
        #endregion

        private void txtProdCurrentQuery_DoubleClick(object sender, EventArgs e)
        {
            frmFemCustomQueryEdit frm = new frmFemCustomQueryEdit();
            frm.Query = txtProdCurrentQuery.Text;
            frm.Env = "PROD";
            frm.Querydata += new delQueryData(queryData);
            DialogResult dir=frm.ShowDialog();
            if (dir.Equals(DialogResult.OK))
            {
                txtProdCurrentQuery.Text = frm.Query;
            }
            
        }

        private void txtTestCurrentQuery_DoubleClick(object sender, EventArgs e)
        {
            frmFemCustomQueryEdit frm = new frmFemCustomQueryEdit();
            frm.Query = txtTestCurrentQuery.Text;
            frm.Env = "TEST";
            frm.Querydata += new delQueryData(queryData);
            DialogResult dir=frm.ShowDialog();
            if (dir.Equals(DialogResult.OK))
            {
                txtTestCurrentQuery.Text = frm.Query;
            }
        }

        void queryData(string strQuery, string Env)
        {
            dtParam = this.GetParam(strQuery);
            DataSet ds = new DataSet();
            if (dtParam != null && dtParam.Rows.Count > 0)
            {
                frmSqlExcuteParam frm = new frmSqlExcuteParam();
                frm.dtParam = this.dtParam;
                frm.ssql = strQuery;
                DialogResult dis = frm.ShowDialog();
                if (dis.Equals(DialogResult.OK))
                {
                    this.dtParam = frm.dtParam;
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = strQuery;
                    if (dtParam != null & dtParam.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtParam.Rows)
                        {
                            if (string.IsNullOrEmpty(dr["Param"].ToString().Trim())) continue;

                            cmd.Parameters.Add(new OracleParameter(dr["Param"].ToString(), dr["Value"]));
                        }
                    }

                    if (Env.ToUpper().Equals("PROD"))
                    {
                        ds = oraProdEnv.GetDataSet(cmd);
                        dgvProdEnv.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        ds = oraTestEnv.GetDataSet(cmd);
                        dgvTestEnv.DataSource = ds.Tables[0];
                    }
                }
            }
            else
            {
                if (Env.ToUpper().Equals("PROD"))
                {
                    ds = oraProdEnv.GetDataSet(strQuery);
                    dgvProdEnv.DataSource = ds.Tables[0];
                }
                else
                {
                    ds = oraTestEnv.GetDataSet(strQuery);
                    dgvTestEnv.DataSource = ds.Tables[0];
                }
            }
        }

        #region 分析Sql,然后执行
        private DataTable GetParam(string ssql)
        {
            DataTable dt = dtParam.Clone();
            dt.Clear();

            string sqlTemp = ssql.Replace("\r", " ").Replace("\n", " ");
            //return dt;

            int istart = 0;
            int idx = 0;
            while (idx >= 0)
            {
                idx = sqlTemp.IndexOf(':', istart);
                if (idx > 0)
                {
                    istart = idx + 1;

                    int iparam = sqlTemp.IndexOf(' ', istart);
                    if (iparam >= 0)
                    {
                        //':'不要截取
                        string strParam = sqlTemp.Substring(istart, iparam - istart).Trim().ToUpper()
                            .Replace(",", "").Replace(")", "").Replace("-", "");

                        bool paramExist = false;
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["Param"].ToString().Equals(strParam))
                            {
                                paramExist = true;
                                break;
                            }
                        }
                        if (paramExist) continue;

                        DataRow dr = dt.NewRow();
                        dr["Param"] = strParam;
                        dr["Value"] = "";
                        dt.Rows.Add(dr);
                        dt.AcceptChanges();

                    }
                    else
                    {
                        //':'不要截取
                        int iend = sqlTemp.Length;
                        string strParam = sqlTemp.Substring(istart, iend - istart).Trim()
                            .ToUpper().Replace(",", "").Replace(")", "").Replace("-", "");

                        bool paramExist = false;
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["Param"].ToString().Equals(strParam))
                            {
                                paramExist = true;
                                break;
                            }
                        }
                        if (paramExist) continue;

                        DataRow dr = dt.NewRow();
                        dr["Param"] = strParam;
                        dr["Value"] = "";
                        dt.Rows.Add(dr);
                        dt.AcceptChanges();
                    }

                }
            }

            return dt;
        }

        #endregion

        private void btnProdTest_Click(object sender, EventArgs e)
        {
            queryData(txtProdCurrentQuery.Text, "PROD");
        }

        private void btnTestTest_Click(object sender, EventArgs e)
        {
            queryData(txtTestCurrentQuery.Text, "TEST");
        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {
            if (!btnProdNew.Enabled && !txtProdNQueryid.ReadOnly)
            {
                //create
                if (string.IsNullOrEmpty(txtProdNQueryid.Text) || string.IsNullOrEmpty(txtProdNVersion.Text))
                {
                    ShowBoxWarmOK("Query Id& Version不能为空!", this.Text);
                    return;
                }
                DialogResult dis = ShowBoxQuesYesNo("要保存Prod,Insert内容吗?", this.Text);
                if (!dis.Equals(DialogResult.Yes)) return;
                //insert into  CT_CUSTOMQUERY
                Dictionary<string, object> setMap = new Dictionary<string, object>();
                setMap.Add("QUERYID", txtProdNQueryid.Text.Trim());
                setMap.Add("VERSION", txtProdNVersion.Text.Trim());
                setMap.Add("QUERYSTRING", txtProdCurrentQuery.Text);
                setMap.Add("DESCRIPTION", txtProdComment.Text);
                setMap.Add("LASTEVENTUSER", Machine.GetMachineIP());
                setMap.Add("LASTEVENTDATE", DateTime.Now);
                setMap.Add("TAG", "1");//?
                if(oraProdEnv.InsertTable("CT_CUSTOMQUERY", setMap)>0)
                {
                    ShowBoxInfoOK("保存OK", this.Text);
                }
                else
                {
                    ShowBoxInfoOK("保存失败", this.Text);
                }
                //insert into CT_CUSTOMQUERY_HISTORY

            }
            else if (btnProdNew.Enabled && txtProdNQueryid.ReadOnly)
            {
                DialogResult dis = ShowBoxQuesYesNo("要保存Prod,Update内容吗?", this.Text);
                if (!dis.Equals(DialogResult.Yes)) return;
                //update CT_CUSTOMQUERY
                Dictionary<string, object> setMap = new Dictionary<string, object>();
                setMap.Add("QUERYSTRING", txtProdCurrentQuery.Text);
                setMap.Add("OLDQUERYSTRING", dgvProdQuery.CurrentRow.Cells["QUERYSTRING"].Value.ToString());
                setMap.Add("DESCRIPTION", txtProdComment.Text);
                setMap.Add("LASTEVENTUSER", Machine.GetMachineIP());
                setMap.Add("LASTEVENTDATE", DateTime.Now);

                Dictionary<string, object> whereMap = new Dictionary<string, object>();
                whereMap.Add("QUERYID", txtProdNQueryid.Text.Trim());
                whereMap.Add("VERSION", txtProdNVersion.Text.Trim());

                if(oraProdEnv.UpdateTable("CT_CUSTOMQUERY", setMap, whereMap)>0)
                {
                    ShowBoxInfoOK("保存OK", this.Text);
                }
                else
                {
                    ShowBoxInfoOK("保存失败", this.Text);
                }
                //insert into CT_CUSTOMQUERY_HISTORY
            }

            this.btnProtQuery_Click(sender, null);
        }

        private void btnTestSave_Click(object sender, EventArgs e)
        {
            if (!btnTestNew.Enabled && !txtTestNQueryId.ReadOnly)
            {
                //create
                if (string.IsNullOrEmpty(txtTestNQueryId.Text) || string.IsNullOrEmpty(txtTestNVersion.Text))
                {
                    ShowBoxWarmOK("Query Id& Version不能为空!", this.Text);
                    return;
                }
                DialogResult dis = ShowBoxQuesYesNo("要保存Test,Insert内容吗?", this.Text);
                if (!dis.Equals(DialogResult.Yes)) return;
                //insert into  CT_CUSTOMQUERY
                Dictionary<string, object> setMap = new Dictionary<string, object>();
                setMap.Add("QUERYID", txtTestNQueryId.Text.Trim());
                setMap.Add("VERSION", txtTestNVersion.Text.Trim());
                setMap.Add("QUERYSTRING", txtTestCurrentQuery.Text);
                setMap.Add("DESCRIPTION", txtTestComment.Text);
                setMap.Add("LASTEVENTUSER", Machine.GetMachineIP());
                setMap.Add("LASTEVENTDATE", DateTime.Now);
                setMap.Add("TAG", "1");//?

                if (oraTestEnv.InsertTable("CT_CUSTOMQUERY", setMap) > 0)
                {
                    ShowBoxInfoOK("保存OK", this.Text);
                }
                else
                {
                    ShowBoxInfoOK("保存失败", this.Text);
                }

                //insert into CT_CUSTOMQUERY_HISTORY
            }
            else if (btnTestNew.Enabled && txtTestNQueryId.ReadOnly)
            {
                DialogResult dis = ShowBoxQuesYesNo("要保存Test,Update内容吗?", this.Text);
                if (!dis.Equals(DialogResult.Yes)) return;
                //update CT_CUSTOMQUERY
                Dictionary<string, object> setMap = new Dictionary<string, object>();
                setMap.Add("QUERYSTRING", txtTestCurrentQuery.Text);
                setMap.Add("OLDQUERYSTRING", dgvTestQuery.CurrentRow.Cells["QUERYSTRING"].Value.ToString());
                setMap.Add("DESCRIPTION", txtTestComment.Text);
                setMap.Add("LASTEVENTUSER", Machine.GetMachineIP());
                setMap.Add("LASTEVENTDATE", DateTime.Now);

                Dictionary<string, object> whereMap = new Dictionary<string, object>();
                whereMap.Add("QUERYID", txtTestNQueryId.Text.Trim());
                whereMap.Add("VERSION", txtTestNVersion.Text.Trim());

                if(oraTestEnv.UpdateTable("CT_CUSTOMQUERY", setMap, whereMap)>0)
                {
                    ShowBoxInfoOK("保存OK", this.Text);
                }
                else
                {
                    ShowBoxInfoOK("保存失败", this.Text);
                }
                //insert into CT_CUSTOMQUERY_HISTORY
            }

            this.btnTeseQuery_Click(sender, null);
        }

        private void btnProdNew_Click(object sender, EventArgs e)
        {
            txtProdNQueryid.Clear();
            txtProdNVersion.Clear();
            txtProdCurrentQuery.Clear();
            txtProdOldQuery.Clear();
            txtProdEventUser.Clear();
            txtProdEventTime.Clear();
            txtProdComment.Clear();

            btnProdNew.Enabled = false;
            txtProdNQueryid.ReadOnly = false;
            txtProdNVersion.ReadOnly = false;
        }

        private void btnTestNew_Click(object sender, EventArgs e)
        {
            txtTestNQueryId.Clear();
            txtTestNVersion.Clear();
            txtTestCurrentQuery.Clear();
            txtTestOldQuery.Clear();
            txtTestEventUser.Clear();
            txtTestEventTime.Clear();
            txtTestComment.Clear();

            btnTestNew.Enabled = false;
            txtTestNQueryId.ReadOnly = false;
            txtTestNVersion.ReadOnly = false;
        }

        private void btnProtToTest_Click(object sender, EventArgs e)
        {
            if (dgvProdQuery.CurrentRow == null)
            {
                return;
            }
            string queryid = dgvProdQuery.CurrentRow.Cells["QUERYID"].Value.ToString();
            string version = dgvProdQuery.CurrentRow.Cells["VERSION"].Value.ToString();
            string querystring = dgvProdQuery.CurrentRow.Cells["QUERYSTRING"].Value.ToString();
            string oldquerystring = dgvProdQuery.CurrentRow.Cells["OLDQUERYSTRING"].Value.ToString();
            string description = dgvProdQuery.CurrentRow.Cells["DESCRIPTION"].Value.ToString();
            string lasteventuser = dgvProdQuery.CurrentRow.Cells["LASTEVENTUSER"].Value.ToString();
            string lasteventdate = dgvProdQuery.CurrentRow.Cells["LASTEVENTDATE"].Value.ToString();

            DataSet dsTest = GetCustomQueryDetail(oraTestEnv, queryid, version);
            if (dsTest != null && dsTest.Tables[0].Rows.Count > 0)
            {
                DialogResult dis = ShowBoxQuesYesNo("要保存Prod=>Test,Update内容吗?", this.Text);
                if (!dis.Equals(DialogResult.Yes)) return;
                //update
                Dictionary<string, object> setMap = new Dictionary<string, object>();
                setMap.Add("QUERYSTRING", querystring);
                setMap.Add("OLDQUERYSTRING", dsTest.Tables[0].Rows[0]["QUERYSTRING"].ToString());
                setMap.Add("DESCRIPTION", description);
                setMap.Add("LASTEVENTUSER", Machine.GetMachineIP());
                setMap.Add("LASTEVENTDATE", DateTime.Now);

                Dictionary<string, object> whereMap = new Dictionary<string, object>();
                whereMap.Add("QUERYID", queryid);
                whereMap.Add("VERSION", version);

                if (oraTestEnv.UpdateTable("CT_CUSTOMQUERY", setMap, whereMap) > 0)
                {
                    ShowBoxInfoOK("保存OK", this.Text);
                }
                else
                {
                    ShowBoxInfoOK("保存失败", this.Text);
                }
            }
            else
            {
                DialogResult dis = ShowBoxQuesYesNo("要保存Prod=>Test,Insert内容吗?", this.Text);
                if (!dis.Equals(DialogResult.Yes)) return;
                //insert 
                Dictionary<string, object> setMap = new Dictionary<string, object>();
                setMap.Add("QUERYID", queryid);
                setMap.Add("VERSION", version);
                setMap.Add("QUERYSTRING", querystring);
                setMap.Add("DESCRIPTION", description);
                setMap.Add("LASTEVENTUSER", Machine.GetMachineIP());
                setMap.Add("LASTEVENTDATE", DateTime.Now);
                setMap.Add("TAG", "1");//?
                if (oraTestEnv.InsertTable("CT_CUSTOMQUERY", setMap) > 0)
                {
                    ShowBoxInfoOK("保存OK", this.Text);
                }
                else
                {
                    ShowBoxInfoOK("保存失败", this.Text);
                }
            }

            this.btnCompareSel_Click(sender, null);
        }

        private void btnTestToProd_Click(object sender, EventArgs e)
        {
            if (dgvTestQuery.CurrentRow == null)
            {
                return;
            }
            string queryid = dgvTestQuery.CurrentRow.Cells["QUERYID"].Value.ToString();
            string version = dgvTestQuery.CurrentRow.Cells["VERSION"].Value.ToString();
            string querystring = dgvTestQuery.CurrentRow.Cells["QUERYSTRING"].Value.ToString();
            string oldquerystring = dgvTestQuery.CurrentRow.Cells["OLDQUERYSTRING"].Value.ToString();
            string description = dgvTestQuery.CurrentRow.Cells["DESCRIPTION"].Value.ToString();
            string lasteventuser = dgvTestQuery.CurrentRow.Cells["LASTEVENTUSER"].Value.ToString();
            string lasteventdate = dgvTestQuery.CurrentRow.Cells["LASTEVENTDATE"].Value.ToString();

            DataSet dsProd = GetCustomQueryDetail(oraProdEnv, queryid, version);
            if (dsProd != null && dsProd.Tables[0].Rows.Count > 0)
            {
                DialogResult dis = ShowBoxQuesYesNo("要保存Test=>Prod,Update内容吗?", this.Text);
                if (!dis.Equals(DialogResult.Yes)) return;
                //update
                Dictionary<string, object> setMap = new Dictionary<string, object>();
                setMap.Add("QUERYSTRING", querystring);
                setMap.Add("OLDQUERYSTRING", dsProd.Tables[0].Rows[0]["QUERYSTRING"].ToString());
                setMap.Add("DESCRIPTION", description);
                setMap.Add("LASTEVENTUSER", Machine.GetMachineIP());
                setMap.Add("LASTEVENTDATE", DateTime.Now);

                Dictionary<string, object> whereMap = new Dictionary<string, object>();
                whereMap.Add("QUERYID", queryid);
                whereMap.Add("VERSION", version);

                if (oraProdEnv.UpdateTable("CT_CUSTOMQUERY", setMap, whereMap) > 0)
                {
                    ShowBoxInfoOK("保存OK", this.Text);
                }
                else
                {
                    ShowBoxInfoOK("保存失败", this.Text);
                }
            }
            else
            {
                DialogResult dis = ShowBoxQuesYesNo("要保存Test=>Prod,Insert内容吗?", this.Text);
                if (!dis.Equals(DialogResult.Yes)) return;
                //insert 
                Dictionary<string, object> setMap = new Dictionary<string, object>();
                setMap.Add("QUERYID", queryid);
                setMap.Add("VERSION", version);
                setMap.Add("QUERYSTRING", querystring);
                setMap.Add("DESCRIPTION", description);
                setMap.Add("LASTEVENTUSER", Machine.GetMachineIP());
                setMap.Add("LASTEVENTDATE", DateTime.Now);
                setMap.Add("TAG", "1");//?
                if (oraProdEnv.InsertTable("CT_CUSTOMQUERY", setMap) > 0)
                {
                    ShowBoxInfoOK("保存OK", this.Text);
                }
                else
                {
                    ShowBoxInfoOK("保存失败", this.Text);
                }
            }

            this.btnCompareSel_Click(sender, null);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            DataTable dtProd = GetCustomQueryDetail(oraProdEnv, "%", "").Tables[0];
            DataTable dtTest = GetCustomQueryDetail(oraTestEnv, "%", "").Tables[0];

            DataTable dtProdClone = dtProd.Copy();

            for (int i = 0; i < dtProdClone.Rows.Count; i++)
            {
                string queryid = dtProdClone.Rows[i]["QUERYID"].ToString();
                string version = dtProdClone.Rows[i]["VERSION"].ToString();
                string querystring = dtProdClone.Rows[i]["QUERYSTRING"].ToString().Replace("\r","");
                DataRow[] arrDrTest = dtTest.Select("QUERYID='" + queryid + "' and VERSION='" + version + "'");
                if (arrDrTest != null && arrDrTest.Length > 0)
                {
                    string str = arrDrTest[0]["QUERYSTRING"].ToString().Replace("\r","");
                    if (str.Equals(querystring))
                    {
                        dtProdClone.Rows.RemoveAt(i);
                        i = 0;
                    }
                    else
                    {
                        //string str = arrDrTest[0]["QUERYSTRING"].ToString();
                    }
                }
            }

            for (int i = 0; i < dtTest.Rows.Count; i++)
            {
                string queryid = dtTest.Rows[i]["QUERYID"].ToString();
                string version = dtTest.Rows[i]["VERSION"].ToString();
                string querystring = dtTest.Rows[i]["QUERYSTRING"].ToString().Replace("\r", "");
                DataRow[] arrDrProd = dtProd.Select("QUERYID='" + queryid + "' and VERSION='" + version +"'");
                if (arrDrProd != null && arrDrProd.Length > 0)
                {
                    string str = arrDrProd[0]["QUERYSTRING"].ToString().Replace("\r", "");
                    if (str.Equals(querystring))
                    {
                        dtTest.Rows.RemoveAt(i);
                        i = 0;
                    }
                }
            }

            dgvProdQuery.DataSource = dtProdClone;
            dgvTestQuery.DataSource = dtTest;

        }

        private void btnCompareSel_Click(object sender, EventArgs e)
        {
            cmbProdQueryId.Text = mdQuery;
            txtProdVersion.Text = mdVersion;

            cmbTestQueryId.Text = mdQuery;
            txtTestVersion.Text = mdVersion;

            btnProtQuery_Click(sender, null);
            btnTeseQuery_Click(sender, null);
        }
    }
}
