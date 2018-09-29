using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Configuration;
using System.Data;

namespace CustomQuery
{
    public class OracleHelpMes
    {
        private OracleConnection con;
        OracleTransaction oracleTransaction;

        public string baseStr
        {
            get;
            set;
        }
        /// <summary>
        /// 打开数据库连接.
        /// </summary>
        public void Open()
        {
            string baseConnetString = baseStr;
            if (string.IsNullOrEmpty(baseConnetString))
            {
                throw new Exception("DB连接字符串为空!");
            }

            //string connetString = Base64.UnBaseEnconding(baseConnetString);//解码
            string connetString = baseConnetString;
            // 打开数据库连接
            if (con == null)
            {
                con = new OracleConnection(connetString);
            }
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void Close()
        {
            if (con != null)
                con.Close();
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            // 确认连接是否已经关闭
            if (con != null)
            {
                con.Dispose();
                con = null;
            }
        }

        /// <summary>
        /// 直接运行指令
        /// </summary>
        /// <param name="cmd">SqlCommand</param>
        /// <returns>1</returns>
        public int RunCommand(OracleCommand cmd)
        {
            this.Open();
            cmd.Connection = con;
            int iret = cmd.ExecuteNonQuery();
            this.Close();
            return iret;
        }

        /// <summary>
        /// 使用事务运行
        /// </summary>
        /// <param name="cmd">SqlCommand</param>
        /// <returns>执行的数据数量</returns>
        public int RunCommandStartT(OracleCommand cmd)
        {
            try
            {
                this.Open();
                oracleTransaction = con.BeginTransaction();
                cmd.Connection = con;
                cmd.Transaction = oracleTransaction;

                int iret = cmd.ExecuteNonQuery();
                //this.Close();
                return iret;
            }
            catch (System.Exception ex)
            {
                if (oracleTransaction != null && oracleTransaction.Connection != null)
                {
                    oracleTransaction.Rollback();
                }

                this.Close();

                throw ex;
                //return -1;
            }
        }

        /// <summary>
        /// 使用Commit关闭事务
        /// </summary>
        public void RunCommandEndCommitT()
        {
            if (oracleTransaction != null && oracleTransaction.Connection != null)
            {
                oracleTransaction.Commit();
            }

            this.Close();
        }


        /// <summary>
        /// 使用RollBack关闭事务
        /// </summary>
        public void RunCommandEndRollBackT()
        {
            if (oracleTransaction != null && oracleTransaction.Connection != null)
            {
                oracleTransaction.Rollback();
            }

            this.Close();
        }

        /// <summary>
        /// 获得DataSet
        /// </summary>
        /// <param name="sql">string</param>
        /// <returns>DataSet</returns>
        public DataSet GetDataSet(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                this.Open();

                OracleDataAdapter dap = new OracleDataAdapter();
                dap.SelectCommand = cmd;
                dap.SelectCommand.Connection = con;

                dap.Fill(ds);
                this.Close();
            }
            catch (Exception err)
            {
                throw err;
            }
            //得到执行成功返回值
            return ds;
        }

        /// <summary>
        /// 获得DataSet
        /// </summary>
        /// <param name="cmd">OracleCommand</param>
        /// <returns>DataSet</returns>
        public DataSet GetDataSet(OracleCommand cmd)
        {
            DataSet ds = new DataSet();
            try
            {
                this.Open();
                cmd.Connection = con;
                OracleDataAdapter dap = new OracleDataAdapter(cmd);
                dap.Fill(ds);
                this.Close();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                this.Close();
            }
            return ds;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="tablename">表名</param>
        /// <param name="setMap">插入的内容</param>
        /// <returns>数据成功条数</returns>
        public int InsertTable(string tablename, Dictionary<string, object> setMap)
        {
            try
            {
                string ssql = "";
                StringBuilder strSql1 = new StringBuilder();
                StringBuilder strSql2 = new StringBuilder();
                strSql1.Append("insert into ").Append(tablename).Append("(");
                strSql2.Append("values ({0}");
                foreach (KeyValuePair<string, object> pair in setMap)
                {
                    strSql1.Append(pair.Key).Append(",");
                    strSql2.Append("SET_" + pair.Key).Append(",{0}");//使用SET_PARAM方式
                }

                string sql1 = strSql1.ToString();
                sql1 = sql1.Substring(0, sql1.Length - 1) + ")";//字符串组装结束后,结尾为',',需要把','去掉
                string sql2 = strSql2.ToString();
                sql2 = sql2.Substring(0, sql2.Length - 4) + ")";//字符串组装结束后,结尾为',{0}',需要把',{0}'去掉

                ssql = sql1 + " " + sql2;

                this.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = string.Format(ssql, ":");//把{0}转换为@,Sql使用的符号为@
                cmd.Parameters.Clear();
                foreach (KeyValuePair<string, object> pair in setMap)
                {
                    //cmd.Parameters.Add("SET_" + pair.Key, pair.Value.GetType()).Value = pair.Value;
                    cmd.Parameters.Add(new OracleParameter("SET_" + pair.Key, pair.Value));
                }
                cmd.ExecuteNonQuery();
                this.Close();

                return 1;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        /// <summary>
        /// Update数据
        /// </summary>
        /// <param name="tablename">表名</param>
        /// <param name="setMap">Update的内容</param>
        /// <param name="whereMap">Where条件</param>
        /// <returns>数据成功条数</returns>
        public int UpdateTable(string tablename, Dictionary<string, object> setMap, Dictionary<string, object> whereMap)
        {
            try
            {
                string ssql = "";
                StringBuilder strSql1 = new StringBuilder();
                StringBuilder strSql2 = new StringBuilder();

                strSql1.Append("update ").Append(tablename).Append(" set ");
                foreach (KeyValuePair<string, object> setPair in setMap)
                {
                    strSql1.Append(setPair.Key).Append("={0}").Append("SET_" + setPair.Key).Append(",");
                }
                string sql1 = strSql1.ToString();
                sql1 = sql1.Substring(0, sql1.Length - 1);//字符串组装结束后,结尾为',',需要把','去掉

                strSql2.Append("Where ");
                foreach (KeyValuePair<string, object> wherePair in whereMap)
                {
                    strSql2.Append(wherePair.Key).Append("={0}").Append("WHERE_" + wherePair.Key).Append(" and ");
                }
                string sql2 = strSql2.ToString();
                sql2 = sql2.Substring(0, sql2.Length - 4);//字符串组装结束后,结尾为'and ',需要把'and '去掉

                ssql = sql1 + " " + sql2;

                this.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = string.Format(ssql, ":");
                cmd.Connection = con;
                cmd.Parameters.Clear();
                foreach (KeyValuePair<string, object> pair in setMap)
                {
                    cmd.Parameters.Add(new OracleParameter("SET_" + pair.Key, pair.Value));
                }
                foreach (KeyValuePair<string, object> pair in whereMap)
                {
                    cmd.Parameters.Add(new OracleParameter("WHERE_" + pair.Key, pair.Value));
                }
                //cmd.Parameters.Add(new OracleParameter("ReturnValue", OracleType.Int32, 4,
                //ParameterDirection.ReturnValue, false, 0, 0,
                //string.Empty, DataRowVersion.Default, null));
                int iRet = cmd.ExecuteNonQuery();
                this.Close();

                return iRet;//(int)cmd.Parameters["ReturnValue"].Value;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        /// <summary>
        /// 删除表的数据
        /// </summary>
        /// <param name="tablename">表名</param>
        /// <param name="whereMap">Where条件</param>
        /// <returns>数据成功条数</returns>
        public int DeleteTable(string tablename, Dictionary<string, object> whereMap)
        {
            try
            {
                string ssql = "";
                StringBuilder strSql1 = new StringBuilder();

                strSql1.Append("delete ").Append(tablename).Append(" where ");
                foreach (KeyValuePair<string, object> pair in whereMap)
                {
                    strSql1.Append(pair.Key).Append("={0}").Append("WHERE_" + pair.Key).Append(" and ");
                }
                string sql1 = strSql1.ToString();
                ssql = sql1.Substring(0, sql1.Length - 4);//字符串组装结束后,结尾为'and ',需要把'and '去掉

                this.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = string.Format(ssql, ":");
                cmd.Connection = con;
                cmd.Parameters.Clear();
                foreach (KeyValuePair<string, object> pair in whereMap)
                {
                    cmd.Parameters.Add(new OracleParameter("WHERE_" + pair.Key, pair.Value));
                }
                //cmd.Parameters.Add(new OracleParameter("ReturnValue", OracleType.Int32, 4,
                //ParameterDirection.ReturnValue, false, 0, 0,
                //string.Empty, DataRowVersion.Default, null));
                int iRet = cmd.ExecuteNonQuery();
                this.Close();

                return iRet;// (int)cmd.Parameters["ReturnValue"].Value;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
