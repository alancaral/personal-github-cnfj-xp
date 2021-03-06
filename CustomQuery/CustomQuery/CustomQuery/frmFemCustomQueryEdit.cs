﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomQuery
{
    public delegate void delQueryData(string query,string env);

    public partial class frmFemCustomQueryEdit : frmBase
    {
        public event delQueryData Querydata;

        public string Query { get; set; }
        public string Env { get; set; }

        public frmFemCustomQueryEdit()
        {
            InitializeComponent();
        }

        private void frmFemCustomQueryEdit_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Query))
            {
                txtQuery.Text = Query;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Query = txtQuery.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Querydata(txtQuery.Text,Env);
        }
    }
}
