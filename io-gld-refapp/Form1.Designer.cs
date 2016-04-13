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
            this.pullModel = new System.Windows.Forms.Button();
            this.cmbDataSources = new System.Windows.Forms.ComboBox();
            this.btnDataSources = new System.Windows.Forms.Button();
            this.cmbWells = new System.Windows.Forms.ComboBox();
            this.btnWells = new System.Windows.Forms.Button();
            this.cmbLeases = new System.Windows.Forms.ComboBox();
            this.btnLeases = new System.Windows.Forms.Button();
            this.btnFields = new System.Windows.Forms.Button();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.btnString = new System.Windows.Forms.Button();
            this.cmbString = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.outputBox);
            this.flowLayoutPanel1.Controls.Add(this.startGlue);
            this.flowLayoutPanel1.Controls.Add(this.pullModel);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(642, 570);
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
            this.startGlue.Location = new System.Drawing.Point(313, 3);
            this.startGlue.Name = "startGlue";
            this.startGlue.Size = new System.Drawing.Size(80, 27);
            this.startGlue.TabIndex = 2;
            this.startGlue.Text = "WinGLUE";
            this.startGlue.UseVisualStyleBackColor = true;
            this.startGlue.Click += new System.EventHandler(this.startGlue_Click);
            // 
            // pullModel
            // 
            this.pullModel.AutoSize = true;
            this.pullModel.Location = new System.Drawing.Point(399, 3);
            this.pullModel.Name = "pullModel";
            this.pullModel.Size = new System.Drawing.Size(83, 27);
            this.pullModel.TabIndex = 3;
            this.pullModel.Text = "Pull Model";
            this.pullModel.UseVisualStyleBackColor = true;
            this.pullModel.Click += new System.EventHandler(this.pullModel_Click);
            // 
            // cmbDataSources
            // 
            this.cmbDataSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataSources.FormattingEnabled = true;
            this.cmbDataSources.Location = new System.Drawing.Point(132, 3);
            this.cmbDataSources.Name = "cmbDataSources";
            this.cmbDataSources.Size = new System.Drawing.Size(121, 24);
            this.cmbDataSources.TabIndex = 1;
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
            // cmbWells
            // 
            this.cmbWells.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWells.FormattingEnabled = true;
            this.cmbWells.Location = new System.Drawing.Point(132, 129);
            this.cmbWells.Name = "cmbWells";
            this.cmbWells.Size = new System.Drawing.Size(121, 24);
            this.cmbWells.TabIndex = 1;
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
            // cmbLeases
            // 
            this.cmbLeases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeases.FormattingEnabled = true;
            this.cmbLeases.Location = new System.Drawing.Point(132, 87);
            this.cmbLeases.Name = "cmbLeases";
            this.cmbLeases.Size = new System.Drawing.Size(121, 24);
            this.cmbLeases.TabIndex = 1;
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
            // cmbFields
            // 
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(132, 45);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(121, 24);
            this.cmbFields.TabIndex = 1;
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
            // 
            // cmbString
            // 
            this.cmbString.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbString.FormattingEnabled = true;
            this.cmbString.Location = new System.Drawing.Point(132, 171);
            this.cmbString.Name = "cmbString";
            this.cmbString.Size = new System.Drawing.Size(121, 24);
            this.cmbString.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 95);
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
            this.tableLayoutPanel2.Controls.Add(this.cmbString, 1, 4);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 576);
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
        private System.Windows.Forms.Button pullModel;
        private System.Windows.Forms.Button btnDataSources;
        private System.Windows.Forms.ComboBox cmbDataSources;
        private System.Windows.Forms.ComboBox cmbWells;
        private System.Windows.Forms.Button btnWells;
        private System.Windows.Forms.ComboBox cmbLeases;
        private System.Windows.Forms.Button btnLeases;
        private System.Windows.Forms.ComboBox cmbString;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.Button btnFields;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

