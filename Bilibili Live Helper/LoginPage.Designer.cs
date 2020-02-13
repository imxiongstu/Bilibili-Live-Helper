namespace Bilibili_Live_Helper
{
    partial class LoginPage
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tb_UserName = new MetroFramework.Controls.MetroTextBox();
            this.tb_Password = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.metroButton1.DisplayFocus = true;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(157, 267);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(273, 44);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.TabStop = false;
            this.metroButton1.Text = "登录";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tb_UserName
            // 
            // 
            // 
            // 
            this.tb_UserName.CustomButton.AutoSize = true;
            this.tb_UserName.CustomButton.Image = null;
            this.tb_UserName.CustomButton.Location = new System.Drawing.Point(241, 2);
            this.tb_UserName.CustomButton.Name = "";
            this.tb_UserName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.tb_UserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_UserName.CustomButton.TabIndex = 1;
            this.tb_UserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_UserName.CustomButton.UseSelectable = true;
            this.tb_UserName.CustomButton.Visible = false;
            this.tb_UserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_UserName.Lines = new string[] {
        "admin"};
            this.tb_UserName.Location = new System.Drawing.Point(157, 157);
            this.tb_UserName.MaxLength = 32767;
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.PasswordChar = '\0';
            this.tb_UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_UserName.SelectedText = "";
            this.tb_UserName.SelectionLength = 0;
            this.tb_UserName.SelectionStart = 0;
            this.tb_UserName.ShortcutsEnabled = true;
            this.tb_UserName.Size = new System.Drawing.Size(273, 34);
            this.tb_UserName.TabIndex = 1;
            this.tb_UserName.Text = "admin";
            this.tb_UserName.UseCustomBackColor = true;
            this.tb_UserName.UseCustomForeColor = true;
            this.tb_UserName.UseSelectable = true;
            this.tb_UserName.UseStyleColors = true;
            this.tb_UserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_UserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_Password
            // 
            // 
            // 
            // 
            this.tb_Password.CustomButton.AutoSize = true;
            this.tb_Password.CustomButton.Image = null;
            this.tb_Password.CustomButton.Location = new System.Drawing.Point(241, 2);
            this.tb_Password.CustomButton.Name = "";
            this.tb_Password.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.tb_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Password.CustomButton.TabIndex = 1;
            this.tb_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Password.CustomButton.UseSelectable = true;
            this.tb_Password.CustomButton.Visible = false;
            this.tb_Password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_Password.Lines = new string[] {
        "123456"};
            this.tb_Password.Location = new System.Drawing.Point(157, 197);
            this.tb_Password.MaxLength = 32767;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Password.SelectedText = "";
            this.tb_Password.SelectionLength = 0;
            this.tb_Password.SelectionStart = 0;
            this.tb_Password.ShortcutsEnabled = true;
            this.tb_Password.Size = new System.Drawing.Size(273, 34);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.Text = "123456";
            this.tb_Password.UseCustomBackColor = true;
            this.tb_Password.UseCustomForeColor = true;
            this.tb_Password.UseSelectable = true;
            this.tb_Password.UseStyleColors = true;
            this.tb_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(341, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "注册账号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(157, 238);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(88, 17);
            this.metroCheckBox1.TabIndex = 4;
            this.metroCheckBox1.Text = "记住账号";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(342, 238);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(88, 17);
            this.metroCheckBox2.TabIndex = 5;
            this.metroCheckBox2.Text = "同意协议";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F);
            this.label2.Location = new System.Drawing.Point(102, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "账号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F);
            this.label3.Location = new System.Drawing.Point(102, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "密码";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(585, 375);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.metroButton1);
            this.Movable = false;
            this.Name = "LoginPage";
            this.Resizable = false;
            this.Text = "泽酱助手Beta";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox tb_UserName;
        private MetroFramework.Controls.MetroTextBox tb_Password;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}