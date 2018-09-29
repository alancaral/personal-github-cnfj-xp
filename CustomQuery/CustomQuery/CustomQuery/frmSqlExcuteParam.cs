using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomQuery
{
    public partial class frmSqlExcuteParam : frmBase
    {
        public DataTable dtParam
        {
            get;
            set;
        }

        public string ssql
        {
            get;
            set;
        }

        public frmSqlExcuteParam()
        {
            InitializeComponent();
        }

        private void frmSqlExcuteParam_Load(object sender, EventArgs e)
        {
            if (dtParam == null || dtParam.Rows.Count <= 0)
            {
                ShowBoxWarmOK("没有参数!", "参数");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                txtsql.Text = ssql;
                dgvParam.DataSource = dtParam;
            }
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            dtParam.AcceptChanges();
            //dtParam = dgvParam.DataSource as DataTable;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
