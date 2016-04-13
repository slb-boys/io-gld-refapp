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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.startGlue = new System.Windows.Forms.Button();
            this.pullModel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDataSources = new System.Windows.Forms.ComboBox();
            this.btnDataSources = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 275);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.outputBox);
            this.flowLayoutPanel1.Controls.Add(this.startGlue);
            this.flowLayoutPanel1.Controls.Add(this.pullModel);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(307, 269);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 0);
            this.textBox1.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputBox.Location = new System.Drawing.Point(3, 9);
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
            this.startGlue.Location = new System.Drawing.Point(3, 101);
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
            this.pullModel.Location = new System.Drawing.Point(89, 101);
            this.pullModel.Name = "pullModel";
            this.pullModel.Size = new System.Drawing.Size(83, 27);
            this.pullModel.TabIndex = 3;
            this.pullModel.Text = "Pull Model";
            this.pullModel.UseVisualStyleBackColor = true;
            this.pullModel.Click += new System.EventHandler(this.pullModel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDataSources);
            this.groupBox1.Controls.Add(this.btnDataSources);
            this.groupBox1.Location = new System.Drawing.Point(3, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Sources";
            // 
            // cmbDataSources
            // 
            this.cmbDataSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataSources.FormattingEnabled = true;
            this.cmbDataSources.Location = new System.Drawing.Point(134, 21);
            this.cmbDataSources.Name = "cmbDataSources";
            this.cmbDataSources.Size = new System.Drawing.Size(121, 24);
            this.cmbDataSources.TabIndex = 1;
            // 
            // btnDataSources
            // 
            this.btnDataSources.AutoSize = true;
            this.btnDataSources.Location = new System.Drawing.Point(6, 21);
            this.btnDataSources.Name = "btnDataSources";
            this.btnDataSources.Size = new System.Drawing.Size(104, 27);
            this.btnDataSources.TabIndex = 0;
            this.btnDataSources.Text = "Data Sources";
            this.btnDataSources.UseVisualStyleBackColor = true;
            this.btnDataSources.Click += new System.EventHandler(this.btnDataSources_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 275);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "IO GLD Ref App";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button startGlue;
        private System.Windows.Forms.Button pullModel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDataSources;
        private System.Windows.Forms.ComboBox cmbDataSources;
    }
}

