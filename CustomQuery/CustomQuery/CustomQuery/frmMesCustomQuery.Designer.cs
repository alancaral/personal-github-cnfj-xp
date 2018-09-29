namespace CustomQuery
{
    partial class frmMesCustomQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProdOldQuery = new System.Windows.Forms.RichTextBox();
            this.txtProdCurrentQuery = new System.Windows.Forms.RichTextBox();
            this.lblEnvProd = new System.Windows.Forms.Label();
            this.btnProdNew = new System.Windows.Forms.Button();
            this.txtProdNVersion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProdNQueryid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.btnProdTest = new System.Windows.Forms.Button();
            this.txtProdComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProdEventTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdEventUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProdQuery = new System.Windows.Forms.DataGridView();
            this.btnProtQuery = new System.Windows.Forms.Button();
            this.txtProdVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProdQueryId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProdEnv = new System.Windows.Forms.DataGridView();
            this.dgvTestEnv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTestOldQuery = new System.Windows.Forms.RichTextBox();
            this.txtTestCurrentQuery = new System.Windows.Forms.RichTextBox();
            this.lblEnvTest = new System.Windows.Forms.Label();
            this.btnTestNew = new System.Windows.Forms.Button();
            this.txtTestNVersion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTestNQueryId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTestSave = new System.Windows.Forms.Button();
            this.btnTestTest = new System.Windows.Forms.Button();
            this.txtTestComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTestEventTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTestEventUser = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvTestQuery = new System.Windows.Forms.DataGridView();
            this.btnTestQuery = new System.Windows.Forms.Button();
            this.txtTestVersion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTestQueryId = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCompareSel = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnTestToProd = new System.Windows.Forms.Button();
            this.btnProtToTest = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdEnv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestEnv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestQuery)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvProdEnv, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvTestEnv, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.45749F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.54251F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtProdOldQuery);
            this.panel1.Controls.Add(this.txtProdCurrentQuery);
            this.panel1.Controls.Add(this.lblEnvProd);
            this.panel1.Controls.Add(this.btnProdNew);
            this.panel1.Controls.Add(this.txtProdNVersion);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtProdNQueryid);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnProdSave);
            this.panel1.Controls.Add(this.btnProdTest);
            this.panel1.Controls.Add(this.txtProdComment);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProdEventTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtProdEventUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvProdQuery);
            this.panel1.Controls.Add(this.btnProtQuery);
            this.panel1.Controls.Add(this.txtProdVersion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbProdQueryId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 395);
            this.panel1.TabIndex = 0;
            // 
            // txtProdOldQuery
            // 
            this.txtProdOldQuery.Location = new System.Drawing.Point(179, 219);
            this.txtProdOldQuery.Name = "txtProdOldQuery";
            this.txtProdOldQuery.Size = new System.Drawing.Size(409, 111);
            this.txtProdOldQuery.TabIndex = 23;
            this.txtProdOldQuery.Text = "";
            // 
            // txtProdCurrentQuery
            // 
            this.txtProdCurrentQuery.Location = new System.Drawing.Point(179, 102);
            this.txtProdCurrentQuery.Name = "txtProdCurrentQuery";
            this.txtProdCurrentQuery.Size = new System.Drawing.Size(409, 111);
            this.txtProdCurrentQuery.TabIndex = 22;
            this.txtProdCurrentQuery.Text = "";
            this.txtProdCurrentQuery.DoubleClick += new System.EventHandler(this.txtProdCurrentQuery_DoubleClick);
            // 
            // lblEnvProd
            // 
            this.lblEnvProd.AutoSize = true;
            this.lblEnvProd.Location = new System.Drawing.Point(503, 51);
            this.lblEnvProd.Name = "lblEnvProd";
            this.lblEnvProd.Size = new System.Drawing.Size(53, 12);
            this.lblEnvProd.TabIndex = 21;
            this.lblEnvProd.Text = "Prod Env";
            // 
            // btnProdNew
            // 
            this.btnProdNew.Location = new System.Drawing.Point(411, 46);
            this.btnProdNew.Name = "btnProdNew";
            this.btnProdNew.Size = new System.Drawing.Size(75, 23);
            this.btnProdNew.TabIndex = 20;
            this.btnProdNew.Text = "新建";
            this.btnProdNew.UseVisualStyleBackColor = true;
            this.btnProdNew.Click += new System.EventHandler(this.btnProdNew_Click);
            // 
            // txtProdNVersion
            // 
            this.txtProdNVersion.Location = new System.Drawing.Point(244, 75);
            this.txtProdNVersion.Name = "txtProdNVersion";
            this.txtProdNVersion.ReadOnly = true;
            this.txtProdNVersion.Size = new System.Drawing.Size(131, 21);
            this.txtProdNVersion.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "Version";
            // 
            // txtProdNQueryid
            // 
            this.txtProdNQueryid.Location = new System.Drawing.Point(244, 48);
            this.txtProdNQueryid.Name = "txtProdNQueryid";
            this.txtProdNQueryid.ReadOnly = true;
            this.txtProdNQueryid.Size = new System.Drawing.Size(131, 21);
            this.txtProdNQueryid.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "QueryId";
            // 
            // btnProdSave
            // 
            this.btnProdSave.Location = new System.Drawing.Point(494, 73);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(75, 23);
            this.btnProdSave.TabIndex = 15;
            this.btnProdSave.Text = "保存";
            this.btnProdSave.UseVisualStyleBackColor = true;
            this.btnProdSave.Click += new System.EventHandler(this.btnProdSave_Click);
            // 
            // btnProdTest
            // 
            this.btnProdTest.Location = new System.Drawing.Point(411, 73);
            this.btnProdTest.Name = "btnProdTest";
            this.btnProdTest.Size = new System.Drawing.Size(75, 23);
            this.btnProdTest.TabIndex = 14;
            this.btnProdTest.Text = "测试";
            this.btnProdTest.UseVisualStyleBackColor = true;
            this.btnProdTest.Click += new System.EventHandler(this.btnProdTest_Click);
            // 
            // txtProdComment
            // 
            this.txtProdComment.Location = new System.Drawing.Point(236, 366);
            this.txtProdComment.Name = "txtProdComment";
            this.txtProdComment.Size = new System.Drawing.Size(333, 21);
            this.txtProdComment.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "备注";
            // 
            // txtProdEventTime
            // 
            this.txtProdEventTime.Location = new System.Drawing.Point(438, 339);
            this.txtProdEventTime.Name = "txtProdEventTime";
            this.txtProdEventTime.ReadOnly = true;
            this.txtProdEventTime.Size = new System.Drawing.Size(131, 21);
            this.txtProdEventTime.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "EventTime";
            // 
            // txtProdEventUser
            // 
            this.txtProdEventUser.Location = new System.Drawing.Point(254, 339);
            this.txtProdEventUser.Name = "txtProdEventUser";
            this.txtProdEventUser.ReadOnly = true;
            this.txtProdEventUser.Size = new System.Drawing.Size(113, 21);
            this.txtProdEventUser.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "EventUser";
            // 
            // dgvProdQuery
            // 
            this.dgvProdQuery.AllowUserToAddRows = false;
            this.dgvProdQuery.AllowUserToDeleteRows = false;
            this.dgvProdQuery.AllowUserToResizeRows = false;
            this.dgvProdQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdQuery.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProdQuery.Location = new System.Drawing.Point(3, 48);
            this.dgvProdQuery.Name = "dgvProdQuery";
            this.dgvProdQuery.RowHeadersVisible = false;
            this.dgvProdQuery.RowTemplate.Height = 23;
            this.dgvProdQuery.Size = new System.Drawing.Size(170, 344);
            this.dgvProdQuery.TabIndex = 5;
            this.dgvProdQuery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdQuery_CellClick);
            // 
            // btnProtQuery
            // 
            this.btnProtQuery.Location = new System.Drawing.Point(490, 14);
            this.btnProtQuery.Name = "btnProtQuery";
            this.btnProtQuery.Size = new System.Drawing.Size(75, 23);
            this.btnProtQuery.TabIndex = 4;
            this.btnProtQuery.Text = "查询";
            this.btnProtQuery.UseVisualStyleBackColor = true;
            this.btnProtQuery.Click += new System.EventHandler(this.btnProtQuery_Click);
            // 
            // txtProdVersion
            // 
            this.txtProdVersion.Location = new System.Drawing.Point(340, 14);
            this.txtProdVersion.Name = "txtProdVersion";
            this.txtProdVersion.Size = new System.Drawing.Size(131, 21);
            this.txtProdVersion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version";
            // 
            // cmbProdQueryId
            // 
            this.cmbProdQueryId.FormattingEnabled = true;
            this.cmbProdQueryId.Location = new System.Drawing.Point(75, 14);
            this.cmbProdQueryId.Name = "cmbProdQueryId";
            this.cmbProdQueryId.Size = new System.Drawing.Size(197, 20);
            this.cmbProdQueryId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "QueryId";
            // 
            // dgvProdEnv
            // 
            this.dgvProdEnv.AllowUserToAddRows = false;
            this.dgvProdEnv.AllowUserToDeleteRows = false;
            this.dgvProdEnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdEnv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProdEnv.Location = new System.Drawing.Point(3, 404);
            this.dgvProdEnv.Name = "dgvProdEnv";
            this.dgvProdEnv.RowTemplate.Height = 23;
            this.dgvProdEnv.Size = new System.Drawing.Size(600, 155);
            this.dgvProdEnv.TabIndex = 3;
            // 
            // dgvTestEnv
            // 
            this.dgvTestEnv.AllowUserToAddRows = false;
            this.dgvTestEnv.AllowUserToDeleteRows = false;
            this.dgvTestEnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestEnv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTestEnv.Location = new System.Drawing.Point(661, 404);
            this.dgvTestEnv.Name = "dgvTestEnv";
            this.dgvTestEnv.RowTemplate.Height = 23;
            this.dgvTestEnv.Size = new System.Drawing.Size(600, 155);
            this.dgvTestEnv.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTestOldQuery);
            this.panel2.Controls.Add(this.txtTestCurrentQuery);
            this.panel2.Controls.Add(this.lblEnvTest);
            this.panel2.Controls.Add(this.btnTestNew);
            this.panel2.Controls.Add(this.txtTestNVersion);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtTestNQueryId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnTestSave);
            this.panel2.Controls.Add(this.btnTestTest);
            this.panel2.Controls.Add(this.txtTestComment);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTestEventTime);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtTestEventUser);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dgvTestQuery);
            this.panel2.Controls.Add(this.btnTestQuery);
            this.panel2.Controls.Add(this.txtTestVersion);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cmbTestQueryId);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(661, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 395);
            this.panel2.TabIndex = 5;
            // 
            // txtTestOldQuery
            // 
            this.txtTestOldQuery.Location = new System.Drawing.Point(179, 219);
            this.txtTestOldQuery.Name = "txtTestOldQuery";
            this.txtTestOldQuery.Size = new System.Drawing.Size(409, 111);
            this.txtTestOldQuery.TabIndex = 25;
            this.txtTestOldQuery.Text = "";
            // 
            // txtTestCurrentQuery
            // 
            this.txtTestCurrentQuery.Location = new System.Drawing.Point(179, 103);
            this.txtTestCurrentQuery.Name = "txtTestCurrentQuery";
            this.txtTestCurrentQuery.Size = new System.Drawing.Size(409, 111);
            this.txtTestCurrentQuery.TabIndex = 24;
            this.txtTestCurrentQuery.Text = "";
            this.txtTestCurrentQuery.DoubleClick += new System.EventHandler(this.txtTestCurrentQuery_DoubleClick);
            // 
            // lblEnvTest
            // 
            this.lblEnvTest.AutoSize = true;
            this.lblEnvTest.Location = new System.Drawing.Point(501, 51);
            this.lblEnvTest.Name = "lblEnvTest";
            this.lblEnvTest.Size = new System.Drawing.Size(53, 12);
            this.lblEnvTest.TabIndex = 22;
            this.lblEnvTest.Text = "Test Env";
            // 
            // btnTestNew
            // 
            this.btnTestNew.Location = new System.Drawing.Point(411, 46);
            this.btnTestNew.Name = "btnTestNew";
            this.btnTestNew.Size = new System.Drawing.Size(75, 23);
            this.btnTestNew.TabIndex = 20;
            this.btnTestNew.Text = "新建";
            this.btnTestNew.UseVisualStyleBackColor = true;
            this.btnTestNew.Click += new System.EventHandler(this.btnTestNew_Click);
            // 
            // txtTestNVersion
            // 
            this.txtTestNVersion.Location = new System.Drawing.Point(244, 75);
            this.txtTestNVersion.Name = "txtTestNVersion";
            this.txtTestNVersion.ReadOnly = true;
            this.txtTestNVersion.Size = new System.Drawing.Size(131, 21);
            this.txtTestNVersion.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "Version";
            // 
            // txtTestNQueryId
            // 
            this.txtTestNQueryId.Location = new System.Drawing.Point(244, 48);
            this.txtTestNQueryId.Name = "txtTestNQueryId";
            this.txtTestNQueryId.ReadOnly = true;
            this.txtTestNQueryId.Size = new System.Drawing.Size(131, 21);
            this.txtTestNQueryId.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "QueryId";
            // 
            // btnTestSave
            // 
            this.btnTestSave.Location = new System.Drawing.Point(494, 73);
            this.btnTestSave.Name = "btnTestSave";
            this.btnTestSave.Size = new System.Drawing.Size(75, 23);
            this.btnTestSave.TabIndex = 15;
            this.btnTestSave.Text = "保存";
            this.btnTestSave.UseVisualStyleBackColor = true;
            this.btnTestSave.Click += new System.EventHandler(this.btnTestSave_Click);
            // 
            // btnTestTest
            // 
            this.btnTestTest.Location = new System.Drawing.Point(411, 73);
            this.btnTestTest.Name = "btnTestTest";
            this.btnTestTest.Size = new System.Drawing.Size(75, 23);
            this.btnTestTest.TabIndex = 14;
            this.btnTestTest.Text = "测试";
            this.btnTestTest.UseVisualStyleBackColor = true;
            this.btnTestTest.Click += new System.EventHandler(this.btnTestTest_Click);
            // 
            // txtTestComment
            // 
            this.txtTestComment.Location = new System.Drawing.Point(236, 366);
            this.txtTestComment.Name = "txtTestComment";
            this.txtTestComment.Size = new System.Drawing.Size(333, 21);
            this.txtTestComment.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "备注";
            // 
            // txtTestEventTime
            // 
            this.txtTestEventTime.Location = new System.Drawing.Point(438, 339);
            this.txtTestEventTime.Name = "txtTestEventTime";
            this.txtTestEventTime.ReadOnly = true;
            this.txtTestEventTime.Size = new System.Drawing.Size(131, 21);
            this.txtTestEventTime.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "EventTime";
            // 
            // txtTestEventUser
            // 
            this.txtTestEventUser.Location = new System.Drawing.Point(254, 339);
            this.txtTestEventUser.Name = "txtTestEventUser";
            this.txtTestEventUser.ReadOnly = true;
            this.txtTestEventUser.Size = new System.Drawing.Size(113, 21);
            this.txtTestEventUser.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "EventUser";
            // 
            // dgvTestQuery
            // 
            this.dgvTestQuery.AllowUserToAddRows = false;
            this.dgvTestQuery.AllowUserToDeleteRows = false;
            this.dgvTestQuery.AllowUserToResizeRows = false;
            this.dgvTestQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestQuery.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTestQuery.Location = new System.Drawing.Point(3, 48);
            this.dgvTestQuery.Name = "dgvTestQuery";
            this.dgvTestQuery.RowHeadersVisible = false;
            this.dgvTestQuery.RowTemplate.Height = 23;
            this.dgvTestQuery.Size = new System.Drawing.Size(170, 344);
            this.dgvTestQuery.TabIndex = 5;
            this.dgvTestQuery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTestQuery_CellClick);
            // 
            // btnTestQuery
            // 
            this.btnTestQuery.Location = new System.Drawing.Point(490, 14);
            this.btnTestQuery.Name = "btnTestQuery";
            this.btnTestQuery.Size = new System.Drawing.Size(75, 23);
            this.btnTestQuery.TabIndex = 4;
            this.btnTestQuery.Text = "查询";
            this.btnTestQuery.UseVisualStyleBackColor = true;
            this.btnTestQuery.Click += new System.EventHandler(this.btnTeseQuery_Click);
            // 
            // txtTestVersion
            // 
            this.txtTestVersion.Location = new System.Drawing.Point(340, 14);
            this.txtTestVersion.Name = "txtTestVersion";
            this.txtTestVersion.Size = new System.Drawing.Size(131, 21);
            this.txtTestVersion.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "Version";
            // 
            // cmbTestQueryId
            // 
            this.cmbTestQueryId.FormattingEnabled = true;
            this.cmbTestQueryId.Location = new System.Drawing.Point(75, 14);
            this.cmbTestQueryId.Name = "cmbTestQueryId";
            this.cmbTestQueryId.Size = new System.Drawing.Size(197, 20);
            this.cmbTestQueryId.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "QueryId";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCompareSel);
            this.panel3.Controls.Add(this.btnCompare);
            this.panel3.Controls.Add(this.btnTestToProd);
            this.panel3.Controls.Add(this.btnProtToTest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(609, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 395);
            this.panel3.TabIndex = 6;
            // 
            // btnCompareSel
            // 
            this.btnCompareSel.Location = new System.Drawing.Point(7, 147);
            this.btnCompareSel.Name = "btnCompareSel";
            this.btnCompareSel.Size = new System.Drawing.Size(34, 23);
            this.btnCompareSel.TabIndex = 8;
            this.btnCompareSel.Text = "sel";
            this.btnCompareSel.UseVisualStyleBackColor = true;
            this.btnCompareSel.Click += new System.EventHandler(this.btnCompareSel_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(6, 118);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(34, 23);
            this.btnCompare.TabIndex = 7;
            this.btnCompare.Text = "==";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnTestToProd
            // 
            this.btnTestToProd.Location = new System.Drawing.Point(7, 235);
            this.btnTestToProd.Name = "btnTestToProd";
            this.btnTestToProd.Size = new System.Drawing.Size(34, 23);
            this.btnTestToProd.TabIndex = 6;
            this.btnTestToProd.Text = "<=";
            this.btnTestToProd.UseVisualStyleBackColor = true;
            this.btnTestToProd.Click += new System.EventHandler(this.btnTestToProd_Click);
            // 
            // btnProtToTest
            // 
            this.btnProtToTest.Location = new System.Drawing.Point(7, 191);
            this.btnProtToTest.Name = "btnProtToTest";
            this.btnProtToTest.Size = new System.Drawing.Size(34, 23);
            this.btnProtToTest.TabIndex = 5;
            this.btnProtToTest.Text = "=>";
            this.btnProtToTest.UseVisualStyleBackColor = true;
            this.btnProtToTest.Click += new System.EventHandler(this.btnProtToTest_Click);
            // 
            // frmMesCustomQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMesCustomQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFemCustomQuery";
            this.Load += new System.EventHandler(this.frmFemCustomQuery_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdEnv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestEnv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestQuery)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProdEnv;
        private System.Windows.Forms.DataGridView dgvTestEnv;
        private System.Windows.Forms.Button btnProtQuery;
        private System.Windows.Forms.TextBox txtProdVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProdQueryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProdQuery;
        private System.Windows.Forms.TextBox txtProdEventTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdEventUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.Button btnProdTest;
        private System.Windows.Forms.TextBox txtProdNVersion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProdNQueryid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnProdNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTestNew;
        private System.Windows.Forms.TextBox txtTestNVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTestNQueryId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTestSave;
        private System.Windows.Forms.Button btnTestTest;
        private System.Windows.Forms.TextBox txtTestComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTestEventTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTestEventUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvTestQuery;
        private System.Windows.Forms.Button btnTestQuery;
        private System.Windows.Forms.TextBox txtTestVersion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTestQueryId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTestToProd;
        private System.Windows.Forms.Button btnProtToTest;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblEnvProd;
        private System.Windows.Forms.Label lblEnvTest;
        private System.Windows.Forms.RichTextBox txtProdCurrentQuery;
        private System.Windows.Forms.RichTextBox txtProdOldQuery;
        private System.Windows.Forms.RichTextBox txtTestCurrentQuery;
        private System.Windows.Forms.RichTextBox txtTestOldQuery;
        private System.Windows.Forms.Button btnCompareSel;

    }
}