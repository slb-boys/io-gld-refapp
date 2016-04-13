namespace io_gld_refapp
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.startGlue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbStrings = new System.Windows.Forms.ComboBox();
            this.btnDataSources = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.cmbDataSources = new System.Windows.Forms.ComboBox();
            this.cmbWells = new System.Windows.Forms.ComboBox();
            this.btnFields = new System.Windows.Forms.Button();
            this.btnWells = new System.Windows.Forms.Button();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.cmbLeases = new System.Windows.Forms.ComboBox();
            this.btnLeases = new System.Windows.Forms.Button();
            this.btnCurrentWell = new System.Windows.Forms.Button();
            this.btnSelectWell = new System.Windows.Forms.Button();
            this.btnGetWelltest = new System.Windows.Forms.Button();
            this.btnSetWelltest = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 440);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.outputBox);
            this.flowLayoutPanel1.Controls.Add(this.startGlue);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnCurrentWell);
            this.flowLayoutPanel1.Controls.Add(this.btnSelectWell);
            this.flowLayoutPanel1.Controls.Add(this.btnGetWelltest);
            this.flowLayoutPanel1.Controls.Add(this.btnSetWelltest);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(315, 434);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputBox.Location = new System.Drawing.Point(3, 3);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(304, 86);
            this.outputBox.TabIndex = 1;
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // startGlue
            // 
            this.startGlue.AutoSize = true;
            this.startGlue.Location = new System.Drawing.Point(3, 95);
            this.startGlue.Name = "startGlue";
            this.startGlue.Size = new System.Drawing.Size(122, 27);
            this.startGlue.TabIndex = 2;
            this.startGlue.Text = "Staert WinGLUE";
            this.startGlue.UseVisualStyleBackColor = true;
            this.startGlue.Click += new System.EventHandler(this.startGlue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 232);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Well Selector";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.08738F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.91262F));
            this.tableLayoutPanel2.Controls.Add(this.cmbStrings, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnDataSources, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnString, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cmbDataSources, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbWells, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnFields, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnWells, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cmbFields, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbLeases, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnLeases, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(276, 211);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cmbStrings
            // 
            this.cmbStrings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStrings.FormattingEnabled = true;
            this.cmbStrings.Location = new System.Drawing.Point(132, 171);
            this.cmbStrings.Name = "cmbStrings";
            this.cmbStrings.Size = new System.Drawing.Size(121, 24);
            this.cmbStrings.TabIndex = 3;
            // 
            // btnDataSources
            // 
            this.btnDataSources.AutoSize = true;
            this.btnDataSources.Location = new System.Drawing.Point(3, 3);
            this.btnDataSources.Name = "btnDataSources";
            this.btnDataSources.Size = new System.Drawing.Size(104, 27);
            this.btnDataSources.TabIndex = 0;
            this.btnDataSources.Text = "Data Sources";
            this.btnDataSources.UseVisualStyleBackColor = true;
            this.btnDataSources.Click += new System.EventHandler(this.btnDataSources_Click);
            // 
            // btnString
            // 
            this.btnString.AutoSize = true;
            this.btnString.Location = new System.Drawing.Point(3, 171);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(104, 27);
            this.btnString.TabIndex = 2;
            this.btnString.Text = "String";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // cmbDataSources
            // 
            this.cmbDataSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataSources.FormattingEnabled = true;
            this.cmbDataSources.Location = new System.Drawing.Point(132, 3);
            this.cmbDataSources.Name = "cmbDataSources";
            this.cmbDataSources.Size = new System.Drawing.Size(121, 24);
            this.cmbDataSources.TabIndex = 1;
            this.cmbDataSources.SelectedIndexChanged += new System.EventHandler(this.cmbDataSources_SelectedIndexChanged);
            // 
            // cmbWells
            // 
            this.cmbWells.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWells.FormattingEnabled = true;
            this.cmbWells.Location = new System.Drawing.Point(132, 129);
            this.cmbWells.Name = "cmbWells";
            this.cmbWells.Size = new System.Drawing.Size(121, 24);
            this.cmbWells.TabIndex = 1;
            // 
            // btnFields
            // 
            this.btnFields.AutoSize = true;
            this.btnFields.Location = new System.Drawing.Point(3, 45);
            this.btnFields.Name = "btnFields";
            this.btnFields.Size = new System.Drawing.Size(104, 27);
            this.btnFields.TabIndex = 0;
            this.btnFields.Text = "Fields";
            this.btnFields.UseVisualStyleBackColor = true;
            this.btnFields.Click += new System.EventHandler(this.btnFields_Click);
            // 
            // btnWells
            // 
            this.btnWells.AutoSize = true;
            this.btnWells.Location = new System.Drawing.Point(3, 129);
            this.btnWells.Name = "btnWells";
            this.btnWells.Size = new System.Drawing.Size(104, 27);
            this.btnWells.TabIndex = 0;
            this.btnWells.Text = "Wells";
            this.btnWells.UseVisualStyleBackColor = true;
            this.btnWells.Click += new System.EventHandler(this.btnWells_Click);
            // 
            // cmbFields
            // 
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(132, 45);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(121, 24);
            this.cmbFields.TabIndex = 1;
            this.cmbFields.SelectedIndexChanged += new System.EventHandler(this.cmbFields_SelectedIndexChanged);
            // 
            // cmbLeases
            // 
            this.cmbLeases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeases.FormattingEnabled = true;
            this.cmbLeases.Location = new System.Drawing.Point(132, 87);
            this.cmbLeases.Name = "cmbLeases";
            this.cmbLeases.Size = new System.Drawing.Size(121, 24);
            this.cmbLeases.TabIndex = 1;
            this.cmbLeases.SelectedIndexChanged += new System.EventHandler(this.cmbLeases_SelectedIndexChanged);
            // 
            // btnLeases
            // 
            this.btnLeases.AutoSize = true;
            this.btnLeases.Location = new System.Drawing.Point(3, 87);
            this.btnLeases.Name = "btnLeases";
            this.btnLeases.Size = new System.Drawing.Size(104, 27);
            this.btnLeases.TabIndex = 0;
            this.btnLeases.Text = "Leases";
            this.btnLeases.UseVisualStyleBackColor = true;
            this.btnLeases.Click += new System.EventHandler(this.btnLeases_Click);
            // 
            // btnCurrentWell
            // 
            this.btnCurrentWell.AutoSize = true;
            this.btnCurrentWell.Location = new System.Drawing.Point(3, 366);
            this.btnCurrentWell.Name = "btnCurrentWell";
            this.btnCurrentWell.Size = new System.Drawing.Size(112, 27);
            this.btnCurrentWell.TabIndex = 9;
            this.btnCurrentWell.Text = "Get Well Sel";
            this.btnCurrentWell.UseVisualStyleBackColor = true;
            this.btnCurrentWell.Click += new System.EventHandler(this.btnCurrentWell_Click);
            // 
            // btnSelectWell
            // 
            this.btnSelectWell.AutoSize = true;
            this.btnSelectWell.Location = new System.Drawing.Point(121, 366);
            this.btnSelectWell.Name = "btnSelectWell";
            this.btnSelectWell.Size = new System.Drawing.Size(88, 27);
            this.btnSelectWell.TabIndex = 10;
            this.btnSelectWell.Text = "Select Well";
            this.btnSelectWell.UseVisualStyleBackColor = true;
            this.btnSelectWell.Click += new System.EventHandler(this.btnSelectWell_Click);
            // 
            // btnGetWelltest
            // 
            this.btnGetWelltest.AutoSize = true;
            this.btnGetWelltest.Location = new System.Drawing.Point(215, 366);
            this.btnGetWelltest.Name = "btnGetWelltest";
            this.btnGetWelltest.Size = new System.Drawing.Size(95, 27);
            this.btnGetWelltest.TabIndex = 11;
            this.btnGetWelltest.Text = "Get Welltest";
            this.btnGetWelltest.UseVisualStyleBackColor = true;
            this.btnGetWelltest.Click += new System.EventHandler(this.btnGetWelltest_Click);
            // 
            // btnSetWelltest
            // 
            this.btnSetWelltest.AutoSize = true;
            this.btnSetWelltest.Location = new System.Drawing.Point(3, 399);
            this.btnSetWelltest.Name = "btnSetWelltest";
            this.btnSetWelltest.Size = new System.Drawing.Size(93, 27);
            this.btnSetWelltest.TabIndex = 12;
            this.btnSetWelltest.Text = "Set Welltest";
            this.btnSetWelltest.UseVisualStyleBackColor = true;
            this.btnSetWelltest.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 440);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "IO GLD Ref App";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button startGlue;
        private System.Windows.Forms.Button btnDataSources;
        private System.Windows.Forms.ComboBox cmbDataSources;
        private System.Windows.Forms.ComboBox cmbWells;
        private System.Windows.Forms.Button btnWells;
        private System.Windows.Forms.ComboBox cmbLeases;
        private System.Windows.Forms.Button btnLeases;
        private System.Windows.Forms.ComboBox cmbStrings;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.Button btnFields;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCurrentWell;
        private System.Windows.Forms.Button btnSelectWell;
        private System.Windows.Forms.Button btnGetWelltest;
        private System.Windows.Forms.Button btnSetWelltest;
    }
}

