namespace Coffee_management_store
{
    partial class EmployeeForm
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
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.btExit = new System.Windows.Forms.Button();
            this.tbSearchEmployee = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbDateSt = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.lbnameEmp = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbposition = new System.Windows.Forms.Label();
            this.lbdatastart = new System.Windows.Forms.Label();
            this.lbsalary = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.tbGmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbgmail = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.coffee_Management_DatabaseDataSet1 = new Coffee_management_store.Coffee_Management_DatabaseDataSet();
            this.tbTotalDayworking = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbReload = new System.Windows.Forms.PictureBox();
            this.ptbSearchEmp = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ptbFix = new System.Windows.Forms.PictureBox();
            this.ptbAdd = new System.Windows.Forms.PictureBox();
            this.ptbDelete = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_Management_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearchEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(790, 686);
            this.dataGridViewEmployee.TabIndex = 0;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            // 
            // btExit
            // 
            this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExit.Location = new System.Drawing.Point(1427, 604);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(136, 39);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbSearchEmployee
            // 
            this.tbSearchEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchEmployee.Location = new System.Drawing.Point(915, 12);
            this.tbSearchEmployee.Multiline = true;
            this.tbSearchEmployee.Name = "tbSearchEmployee";
            this.tbSearchEmployee.Size = new System.Drawing.Size(246, 36);
            this.tbSearchEmployee.TabIndex = 2;
            this.tbSearchEmployee.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(895, 177);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(266, 47);
            this.tbName.TabIndex = 7;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(895, 277);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(266, 47);
            this.tbID.TabIndex = 7;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(1270, 277);
            this.tbSalary.Multiline = true;
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(184, 47);
            this.tbSalary.TabIndex = 7;
            // 
            // tbDateSt
            // 
            this.tbDateSt.Location = new System.Drawing.Point(1270, 177);
            this.tbDateSt.Multiline = true;
            this.tbDateSt.Name = "tbDateSt";
            this.tbDateSt.Size = new System.Drawing.Size(184, 47);
            this.tbDateSt.TabIndex = 7;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(895, 372);
            this.tbPosition.Multiline = true;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(266, 47);
            this.tbPosition.TabIndex = 7;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(1270, 372);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(184, 47);
            this.tbStatus.TabIndex = 7;
            // 
            // lbnameEmp
            // 
            this.lbnameEmp.AutoSize = true;
            this.lbnameEmp.Location = new System.Drawing.Point(903, 208);
            this.lbnameEmp.Name = "lbnameEmp";
            this.lbnameEmp.Size = new System.Drawing.Size(41, 16);
            this.lbnameEmp.TabIndex = 9;
            this.lbnameEmp.Text = "name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(903, 308);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(20, 16);
            this.lbID.TabIndex = 9;
            this.lbID.Text = "ID";
            // 
            // lbposition
            // 
            this.lbposition.AutoSize = true;
            this.lbposition.Location = new System.Drawing.Point(903, 403);
            this.lbposition.Name = "lbposition";
            this.lbposition.Size = new System.Drawing.Size(54, 16);
            this.lbposition.TabIndex = 9;
            this.lbposition.Text = "position";
            // 
            // lbdatastart
            // 
            this.lbdatastart.AutoSize = true;
            this.lbdatastart.Location = new System.Drawing.Point(1282, 208);
            this.lbdatastart.Name = "lbdatastart";
            this.lbdatastart.Size = new System.Drawing.Size(62, 16);
            this.lbdatastart.TabIndex = 9;
            this.lbdatastart.Text = "date start";
            // 
            // lbsalary
            // 
            this.lbsalary.AutoSize = true;
            this.lbsalary.Location = new System.Drawing.Point(1282, 308);
            this.lbsalary.Name = "lbsalary";
            this.lbsalary.Size = new System.Drawing.Size(44, 16);
            this.lbsalary.TabIndex = 9;
            this.lbsalary.Text = "salary";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(1282, 403);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(42, 16);
            this.lbstatus.TabIndex = 9;
            this.lbstatus.Text = "status";
            // 
            // tbGmail
            // 
            this.tbGmail.Location = new System.Drawing.Point(1569, 177);
            this.tbGmail.Multiline = true;
            this.tbGmail.Name = "tbGmail";
            this.tbGmail.Size = new System.Drawing.Size(159, 47);
            this.tbGmail.TabIndex = 7;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(1569, 277);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(159, 47);
            this.tbPhone.TabIndex = 7;
            // 
            // lbgmail
            // 
            this.lbgmail.AutoSize = true;
            this.lbgmail.Location = new System.Drawing.Point(1581, 208);
            this.lbgmail.Name = "lbgmail";
            this.lbgmail.Size = new System.Drawing.Size(40, 16);
            this.lbgmail.TabIndex = 9;
            this.lbgmail.Text = "gmail";
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Location = new System.Drawing.Point(1581, 308);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(93, 16);
            this.lbphone.TabIndex = 9;
            this.lbphone.Text = "phone number";
            // 
            // coffee_Management_DatabaseDataSet1
            // 
            this.coffee_Management_DatabaseDataSet1.DataSetName = "Coffee_Management_DatabaseDataSet";
            this.coffee_Management_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbTotalDayworking
            // 
            this.tbTotalDayworking.Location = new System.Drawing.Point(937, 446);
            this.tbTotalDayworking.Multiline = true;
            this.tbTotalDayworking.Name = "tbTotalDayworking";
            this.tbTotalDayworking.Size = new System.Drawing.Size(159, 44);
            this.tbTotalDayworking.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total day working";
            // 
            // ptbReload
            // 
            this.ptbReload.Image = global::Coffee_management_store.Properties.Resources.restart_icon_227406;
            this.ptbReload.Location = new System.Drawing.Point(1119, 535);
            this.ptbReload.Name = "ptbReload";
            this.ptbReload.Size = new System.Drawing.Size(100, 50);
            this.ptbReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbReload.TabIndex = 10;
            this.ptbReload.TabStop = false;
            this.ptbReload.Click += new System.EventHandler(this.ptbReload_Click);
            // 
            // ptbSearchEmp
            // 
            this.ptbSearchEmp.Image = global::Coffee_management_store.Properties.Resources.magnifying_glass_icon_129144;
            this.ptbSearchEmp.Location = new System.Drawing.Point(818, 12);
            this.ptbSearchEmp.Name = "ptbSearchEmp";
            this.ptbSearchEmp.Size = new System.Drawing.Size(59, 36);
            this.ptbSearchEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSearchEmp.TabIndex = 5;
            this.ptbSearchEmp.TabStop = false;
            this.ptbSearchEmp.Click += new System.EventHandler(this.ptbSearchEmp_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Coffee_management_store.Properties.Resources.status_sign_positive_checked_check_accepted_success_icon_220294;
            this.pictureBox12.Location = new System.Drawing.Point(1195, 372);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(55, 47);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 8;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Coffee_management_store.Properties.Resources.auricular_phone_symbol_in_a_circle_icon_icons_com_56570;
            this.pictureBox10.Location = new System.Drawing.Point(1491, 277);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(56, 47);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Coffee_management_store.Properties.Resources.task_calendar_timeline_plan_start_date_due_date_icon_142241;
            this.pictureBox9.Location = new System.Drawing.Point(1195, 177);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(55, 47);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Coffee_management_store.Properties.Resources.essential_interaction_touch_finger_hand_salary_icon_226227;
            this.pictureBox11.Location = new System.Drawing.Point(1195, 277);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(55, 47);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 8;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Coffee_management_store.Properties.Resources._1486503783_bag_briefcase_business_case_job_portfolio_suitcase_81278;
            this.pictureBox7.Location = new System.Drawing.Point(818, 372);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(55, 47);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Coffee_management_store.Properties.Resources.gmail_new_logo_icon_159149;
            this.pictureBox8.Location = new System.Drawing.Point(1491, 177);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(56, 47);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Coffee_management_store.Properties.Resources.iconfinder_3_avatar_2754579_120516;
            this.pictureBox6.Location = new System.Drawing.Point(818, 177);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Coffee_management_store.Properties.Resources._4105938_account_card_id_identification_identity_card_profile_user_profile_113929;
            this.pictureBox4.Location = new System.Drawing.Point(818, 277);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // ptbFix
            // 
            this.ptbFix.Image = global::Coffee_management_store.Properties.Resources.note_task_comment_message_edit_write_108613;
            this.ptbFix.Location = new System.Drawing.Point(927, 535);
            this.ptbFix.Name = "ptbFix";
            this.ptbFix.Size = new System.Drawing.Size(56, 50);
            this.ptbFix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFix.TabIndex = 6;
            this.ptbFix.TabStop = false;
            this.ptbFix.Click += new System.EventHandler(this.ptbFix_Click);
            // 
            // ptbAdd
            // 
            this.ptbAdd.Image = global::Coffee_management_store.Properties.Resources._3298601_document_new_new_document_plus_106996;
            this.ptbAdd.Location = new System.Drawing.Point(839, 535);
            this.ptbAdd.Name = "ptbAdd";
            this.ptbAdd.Size = new System.Drawing.Size(55, 50);
            this.ptbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAdd.TabIndex = 6;
            this.ptbAdd.TabStop = false;
            this.ptbAdd.Click += new System.EventHandler(this.ptbAdd_Click);
            // 
            // ptbDelete
            // 
            this.ptbDelete.Image = global::Coffee_management_store.Properties.Resources.iconfinder_trash_4341321_120557;
            this.ptbDelete.Location = new System.Drawing.Point(1013, 535);
            this.ptbDelete.Name = "ptbDelete";
            this.ptbDelete.Size = new System.Drawing.Size(72, 50);
            this.ptbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDelete.TabIndex = 6;
            this.ptbDelete.TabStop = false;
            this.ptbDelete.Click += new System.EventHandler(this.ptbDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coffee_management_store.Properties.Resources.download__3_;
            this.pictureBox1.Location = new System.Drawing.Point(818, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(901, 96);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1768, 686);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotalDayworking);
            this.Controls.Add(this.ptbReload);
            this.Controls.Add(this.ptbSearchEmp);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.lbphone);
            this.Controls.Add(this.lbsalary);
            this.Controls.Add(this.lbposition);
            this.Controls.Add(this.lbgmail);
            this.Controls.Add(this.lbdatastart);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbnameEmp);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbGmail);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbDateSt);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.ptbFix);
            this.Controls.Add(this.ptbAdd);
            this.Controls.Add(this.ptbDelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.tbSearchEmployee);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_Management_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearchEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbSearchEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbDelete;
        private System.Windows.Forms.PictureBox ptbAdd;
        private System.Windows.Forms.PictureBox ptbFix;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbDateSt;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbnameEmp;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbposition;
        private System.Windows.Forms.Label lbdatastart;
        private System.Windows.Forms.Label lbsalary;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.TextBox tbGmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbgmail;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.PictureBox ptbSearchEmp;
        private System.Windows.Forms.PictureBox ptbReload;
        private Coffee_Management_DatabaseDataSet coffee_Management_DatabaseDataSet1;
        private System.Windows.Forms.TextBox tbTotalDayworking;
        private System.Windows.Forms.Label label1;
    }
}