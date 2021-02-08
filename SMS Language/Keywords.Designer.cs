namespace SMS_Language
{
    partial class Keywords
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Definitions1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abbreviations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDefinition = new System.Windows.Forms.RichTextBox();
            this.txtAbbreviation = new System.Windows.Forms.RichTextBox();
            this.lblAbbreviation = new System.Windows.Forms.Label();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Definitions1,
            this.Abbreviations});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(383, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // Definitions1
            // 
            this.Definitions1.HeaderText = "Definitions";
            this.Definitions1.MinimumWidth = 6;
            this.Definitions1.Name = "Definitions1";
            this.Definitions1.ReadOnly = true;
            this.Definitions1.Width = 125;
            // 
            // Abbreviations
            // 
            this.Abbreviations.HeaderText = "Abbreviations";
            this.Abbreviations.MinimumWidth = 6;
            this.Abbreviations.Name = "Abbreviations";
            this.Abbreviations.ReadOnly = true;
            this.Abbreviations.Width = 125;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(465, 38);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "ADD Abbreiations and Definitions";
            // 
            // txtDefinition
            // 
            this.txtDefinition.BackColor = System.Drawing.Color.White;
            this.txtDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinition.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDefinition.Location = new System.Drawing.Point(226, 207);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(269, 68);
            this.txtDefinition.TabIndex = 4;
            this.txtDefinition.Text = "";
            this.txtDefinition.TextChanged += new System.EventHandler(this.RichTextBox2_TextChanged);
            // 
            // txtAbbreviation
            // 
            this.txtAbbreviation.BackColor = System.Drawing.Color.White;
            this.txtAbbreviation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbbreviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbbreviation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAbbreviation.Location = new System.Drawing.Point(23, 207);
            this.txtAbbreviation.Name = "txtAbbreviation";
            this.txtAbbreviation.Size = new System.Drawing.Size(175, 68);
            this.txtAbbreviation.TabIndex = 4;
            this.txtAbbreviation.Text = "";
            this.txtAbbreviation.TextChanged += new System.EventHandler(this.RichTextBox3_TextChanged);
            // 
            // lblAbbreviation
            // 
            this.lblAbbreviation.AutoSize = true;
            this.lblAbbreviation.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbbreviation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.lblAbbreviation.Location = new System.Drawing.Point(25, 146);
            this.lblAbbreviation.Name = "lblAbbreviation";
            this.lblAbbreviation.Size = new System.Drawing.Size(188, 38);
            this.lblAbbreviation.TabIndex = 3;
            this.lblAbbreviation.Text = "Abbreviation";
            this.lblAbbreviation.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.lblDefinition.Location = new System.Drawing.Point(219, 146);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(150, 38);
            this.lblDefinition.TabIndex = 3;
            this.lblDefinition.Text = "Definition";
            this.lblDefinition.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.btnAdd.Location = new System.Drawing.Point(22, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 48);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // pnlEditor
            // 
            this.pnlEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.pnlEditor.Controls.Add(this.btnAdd);
            this.pnlEditor.Controls.Add(this.lblTitle);
            this.pnlEditor.Controls.Add(this.lblDefinition);
            this.pnlEditor.Controls.Add(this.txtAbbreviation);
            this.pnlEditor.Controls.Add(this.lblAbbreviation);
            this.pnlEditor.Controls.Add(this.txtDefinition);
            this.pnlEditor.Location = new System.Drawing.Point(401, 12);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(499, 600);
            this.pnlEditor.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.btnRefresh.Location = new System.Drawing.Point(12, 542);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 41);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // Keywords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(912, 624);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlEditor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Keywords";
            this.Text = "Keywords";
            this.Load += new System.EventHandler(this.Keywords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox txtDefinition;
        private System.Windows.Forms.RichTextBox txtAbbreviation;
        private System.Windows.Forms.Label lblAbbreviation;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Definitions1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abbreviations;
        private System.Windows.Forms.Button btnRefresh;
    }
}