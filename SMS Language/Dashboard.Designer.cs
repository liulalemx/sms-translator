namespace SMS_Language
{
    partial class frmSmsLanguage
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
            this.components = new System.ComponentModel.Container();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnNightMode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.picSms = new System.Windows.Forms.PictureBox();
            this.picWifiOn = new System.Windows.Forms.PictureBox();
            this.picWifiOff = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAmharic = new System.Windows.Forms.Button();
            this.btnReadOut = new System.Windows.Forms.Button();
            this.btnShortenSms = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.txtInputBox = new System.Windows.Forms.RichTextBox();
            this.txtDisplayBox = new System.Windows.Forms.RichTextBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnKeywords = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlDashboard.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifiOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifiOff)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.pnlDashboard.Controls.Add(this.pnlSettings);
            this.pnlDashboard.Controls.Add(this.picInfo);
            this.pnlDashboard.Controls.Add(this.picSettings);
            this.pnlDashboard.Controls.Add(this.picSms);
            this.pnlDashboard.Controls.Add(this.picWifiOn);
            this.pnlDashboard.Controls.Add(this.picWifiOff);
            this.pnlDashboard.Controls.Add(this.lblTitle);
            this.pnlDashboard.Controls.Add(this.btnAmharic);
            this.pnlDashboard.Controls.Add(this.btnReadOut);
            this.pnlDashboard.Controls.Add(this.btnShortenSms);
            this.pnlDashboard.Controls.Add(this.btnTranslate);
            this.pnlDashboard.Controls.Add(this.txtInputBox);
            this.pnlDashboard.Controls.Add(this.txtDisplayBox);
            this.pnlDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 65);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1107, 627);
            this.pnlDashboard.TabIndex = 0;
            this.pnlDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDashboard_Paint);
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.pnlSettings.Controls.Add(this.btnNightMode);
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Location = new System.Drawing.Point(12, 65);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(174, 106);
            this.pnlSettings.TabIndex = 6;
            this.pnlSettings.Visible = false;
            // 
            // btnNightMode
            // 
            this.btnNightMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNightMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.btnNightMode.Location = new System.Drawing.Point(44, 42);
            this.btnNightMode.Name = "btnNightMode";
            this.btnNightMode.Size = new System.Drawing.Size(62, 48);
            this.btnNightMode.TabIndex = 7;
            this.btnNightMode.Text = "ON";
            this.btnNightMode.UseVisualStyleBackColor = true;
            this.btnNightMode.Click += new System.EventHandler(this.BtnNightMode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(26, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dark Mode";
            // 
            // picInfo
            // 
            this.picInfo.Image = global::SMS_Language.Properties.Resources.icons8_info_48px;
            this.picInfo.Location = new System.Drawing.Point(65, 6);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(38, 43);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInfo.TabIndex = 5;
            this.picInfo.TabStop = false;
            this.picInfo.Click += new System.EventHandler(this.PicInfo_Click);
            // 
            // picSettings
            // 
            this.picSettings.Image = global::SMS_Language.Properties.Resources.icons8_settings_100px;
            this.picSettings.Location = new System.Drawing.Point(12, 6);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(36, 43);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSettings.TabIndex = 5;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.PicSettings_Click);
            // 
            // picSms
            // 
            this.picSms.Image = global::SMS_Language.Properties.Resources.icons8_sms_52px;
            this.picSms.Location = new System.Drawing.Point(285, 65);
            this.picSms.Name = "picSms";
            this.picSms.Size = new System.Drawing.Size(45, 43);
            this.picSms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSms.TabIndex = 5;
            this.picSms.TabStop = false;
            // 
            // picWifiOn
            // 
            this.picWifiOn.Image = global::SMS_Language.Properties.Resources.icons8_wi_fi_52px_21;
            this.picWifiOn.Location = new System.Drawing.Point(25, 536);
            this.picWifiOn.Name = "picWifiOn";
            this.picWifiOn.Size = new System.Drawing.Size(45, 43);
            this.picWifiOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWifiOn.TabIndex = 5;
            this.picWifiOn.TabStop = false;
            this.toolTip1.SetToolTip(this.picWifiOn, "You are connected to the internet");
            // 
            // picWifiOff
            // 
            this.picWifiOff.Image = global::SMS_Language.Properties.Resources.icons8_wi_fi_off_60px;
            this.picWifiOff.Location = new System.Drawing.Point(25, 536);
            this.picWifiOff.Name = "picWifiOff";
            this.picWifiOff.Size = new System.Drawing.Size(45, 43);
            this.picWifiOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWifiOff.TabIndex = 5;
            this.picWifiOff.TabStop = false;
            this.toolTip1.SetToolTip(this.picWifiOff, "You are not connected to the internet");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.lblTitle.Location = new System.Drawing.Point(336, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(414, 45);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "SMS Language Converter";
            // 
            // btnAmharic
            // 
            this.btnAmharic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAmharic.FlatAppearance.BorderSize = 0;
            this.btnAmharic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmharic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmharic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnAmharic.Location = new System.Drawing.Point(802, 271);
            this.btnAmharic.Name = "btnAmharic";
            this.btnAmharic.Size = new System.Drawing.Size(106, 67);
            this.btnAmharic.TabIndex = 1;
            this.btnAmharic.Text = "ወደ አማርኛ";
            this.btnAmharic.UseVisualStyleBackColor = false;
            this.btnAmharic.Visible = false;
            this.btnAmharic.Click += new System.EventHandler(this.btnToAmharic);
            // 
            // btnReadOut
            // 
            this.btnReadOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReadOut.FlatAppearance.BorderSize = 0;
            this.btnReadOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnReadOut.Location = new System.Drawing.Point(802, 215);
            this.btnReadOut.Name = "btnReadOut";
            this.btnReadOut.Size = new System.Drawing.Size(106, 50);
            this.btnReadOut.TabIndex = 1;
            this.btnReadOut.Text = "Read Outloud";
            this.btnReadOut.UseVisualStyleBackColor = false;
            this.btnReadOut.Visible = false;
            this.btnReadOut.Click += new System.EventHandler(this.BtnReadOut_Click);
            // 
            // btnShortenSms
            // 
            this.btnShortenSms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.btnShortenSms.FlatAppearance.BorderSize = 0;
            this.btnShortenSms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortenSms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShortenSms.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShortenSms.Location = new System.Drawing.Point(610, 466);
            this.btnShortenSms.Name = "btnShortenSms";
            this.btnShortenSms.Size = new System.Drawing.Size(186, 64);
            this.btnShortenSms.TabIndex = 1;
            this.btnShortenSms.Text = "Shorten SMS";
            this.toolTip1.SetToolTip(this.btnShortenSms, "Finds commonly abbreviated words and abbreviates them");
            this.btnShortenSms.UseVisualStyleBackColor = false;
            this.btnShortenSms.Click += new System.EventHandler(this.BtnShortenSms_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.btnTranslate.FlatAppearance.BorderSize = 0;
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTranslate.Location = new System.Drawing.Point(242, 466);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(219, 64);
            this.btnTranslate.TabIndex = 1;
            this.btnTranslate.Text = "Translate SMS";
            this.toolTip1.SetToolTip(this.btnTranslate, "Converts commonly used abbreviated SMS words to their full meaning");
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.BtnTranslate_Click);
            // 
            // txtInputBox
            // 
            this.txtInputBox.BackColor = System.Drawing.Color.White;
            this.txtInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInputBox.Location = new System.Drawing.Point(242, 369);
            this.txtInputBox.Name = "txtInputBox";
            this.txtInputBox.Size = new System.Drawing.Size(554, 51);
            this.txtInputBox.TabIndex = 0;
            this.txtInputBox.Text = "";
            // 
            // txtDisplayBox
            // 
            this.txtDisplayBox.BackColor = System.Drawing.Color.White;
            this.txtDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDisplayBox.Location = new System.Drawing.Point(242, 159);
            this.txtDisplayBox.Name = "txtDisplayBox";
            this.txtDisplayBox.ReadOnly = true;
            this.txtDisplayBox.Size = new System.Drawing.Size(554, 179);
            this.txtDisplayBox.TabIndex = 0;
            this.txtDisplayBox.Text = "";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 1);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(173, 64);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // btnKeywords
            // 
            this.btnKeywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnKeywords.FlatAppearance.BorderSize = 0;
            this.btnKeywords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeywords.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeywords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnKeywords.Location = new System.Drawing.Point(168, 1);
            this.btnKeywords.Name = "btnKeywords";
            this.btnKeywords.Size = new System.Drawing.Size(173, 64);
            this.btnKeywords.TabIndex = 1;
            this.btnKeywords.Text = "Keywords";
            this.btnKeywords.UseVisualStyleBackColor = false;
            this.btnKeywords.Click += new System.EventHandler(this.BtnKeywords_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnExit.Location = new System.Drawing.Point(1023, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 64);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmSmsLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 691);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKeywords);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.pnlDashboard);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSmsLanguage";
            this.Text = "SMS Language";
            this.Load += new System.EventHandler(this.FrmSmsLanguage_Load);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifiOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifiOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button btnAmharic;
        private System.Windows.Forms.Button btnReadOut;
        private System.Windows.Forms.Button btnShortenSms;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.RichTextBox txtInputBox;
        private System.Windows.Forms.RichTextBox txtDisplayBox;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnKeywords;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picWifiOff;
        private System.Windows.Forms.PictureBox picSms;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.PictureBox picSettings;
        private System.Windows.Forms.PictureBox picWifiOn;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNightMode;
    }
}

