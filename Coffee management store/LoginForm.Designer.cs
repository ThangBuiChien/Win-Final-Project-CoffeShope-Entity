namespace Coffee_management_store
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbUS = new System.Windows.Forms.Label();
            this.lbPW = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.radioManagerButton = new System.Windows.Forms.RadioButton();
            this.radioEmployeeButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(238, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your login and pasword!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN";
            // 
            // tbPassword
            // 
            this.tbPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbPassword.Location = new System.Drawing.Point(180, 225);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(363, 44);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbUsername.Location = new System.Drawing.Point(180, 165);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(9);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUsername.Size = new System.Drawing.Size(363, 44);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // lbUS
            // 
            this.lbUS.AutoSize = true;
            this.lbUS.Location = new System.Drawing.Point(200, 176);
            this.lbUS.Name = "lbUS";
            this.lbUS.Size = new System.Drawing.Size(67, 16);
            this.lbUS.TabIndex = 3;
            this.lbUS.Text = "username";
            // 
            // lbPW
            // 
            this.lbPW.AutoSize = true;
            this.lbPW.Location = new System.Drawing.Point(201, 239);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(66, 16);
            this.lbPW.TabIndex = 3;
            this.lbPW.Text = "password";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(180, 325);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(111, 55);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(370, 325);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(111, 55);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // radioManagerButton
            // 
            this.radioManagerButton.AutoSize = true;
            this.radioManagerButton.Location = new System.Drawing.Point(573, 288);
            this.radioManagerButton.Name = "radioManagerButton";
            this.radioManagerButton.Size = new System.Drawing.Size(82, 20);
            this.radioManagerButton.TabIndex = 5;
            this.radioManagerButton.TabStop = true;
            this.radioManagerButton.Text = "Manager";
            this.radioManagerButton.UseVisualStyleBackColor = true;
            // 
            // radioEmployeeButton
            // 
            this.radioEmployeeButton.AutoSize = true;
            this.radioEmployeeButton.Location = new System.Drawing.Point(573, 325);
            this.radioEmployeeButton.Name = "radioEmployeeButton";
            this.radioEmployeeButton.Size = new System.Drawing.Size(90, 20);
            this.radioEmployeeButton.TabIndex = 5;
            this.radioEmployeeButton.TabStop = true;
            this.radioEmployeeButton.Text = "Employee";
            this.radioEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.radioEmployeeButton);
            this.Controls.Add(this.radioManagerButton);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbPW);
            this.Controls.Add(this.lbUS);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUS;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.RadioButton radioManagerButton;
        private System.Windows.Forms.RadioButton radioEmployeeButton;
    }
}