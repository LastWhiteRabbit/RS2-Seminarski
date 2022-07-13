namespace RS2Seminarski.WinUI
{
    partial class frmAddEditUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbRoles = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btnDeleteRoutine = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbRoles);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnBrowseImage);
            this.groupBox1.Controls.Add(this.btnSaveChanges);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(201, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 323);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            // 
            // clbRoles
            // 
            this.clbRoles.FormattingEnabled = true;
            this.clbRoles.Location = new System.Drawing.Point(6, 231);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(159, 70);
            this.clbRoles.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 96;
            this.label8.Text = "Image";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(260, 282);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(80, 31);
            this.btnBrowseImage.TabIndex = 95;
            this.btnBrowseImage.Text = "Browse...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveChanges.Location = new System.Drawing.Point(370, 275);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(126, 38);
            this.btnSaveChanges.TabIndex = 94;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(249, 198);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(228, 27);
            this.txtConfirmPassword.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 91;
            this.label9.Text = "Confirm password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(249, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(228, 27);
            this.txtPassword.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 89;
            this.label7.Text = "Password:";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(249, 70);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(71, 24);
            this.cbStatus.TabIndex = 88;
            this.cbStatus.Text = "Status";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(249, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(228, 27);
            this.txtUsername.TabIndex = 16;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Username:";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(6, 198);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(228, 27);
            this.txtMobile.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mobile:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 27);
            this.txtEmail.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(6, 93);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(228, 27);
            this.txtSurname.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 27);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(205, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 81;
            this.label1.Text = "IronVault";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.logout_3622;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(662, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(46, 43);
            this.btnLogout.TabIndex = 80;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRole.Location = new System.Drawing.Point(588, 50);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 79;
            this.lblRole.Text = "Role";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(571, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 78;
            this.lblUsername.Text = "Username";
            // 
            // pbUser
            // 
            this.pbUser.Location = new System.Drawing.Point(468, 12);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(78, 65);
            this.pbUser.TabIndex = 77;
            this.pbUser.TabStop = false;
            // 
            // btnDeleteRoutine
            // 
            this.btnDeleteRoutine.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btnDeleteRoutine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteRoutine.Location = new System.Drawing.Point(122, 348);
            this.btnDeleteRoutine.Name = "btnDeleteRoutine";
            this.btnDeleteRoutine.Size = new System.Drawing.Size(53, 58);
            this.btnDeleteRoutine.TabIndex = 75;
            this.btnDeleteRoutine.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.btnDeleteRoutine);
            this.Name = "frmAddEditUser";
            this.Text = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Button btnLogout;
        private Label lblRole;
        private Label lblUsername;
        private PictureBox pbUser;
        private Button btnDeleteRoutine;
        private Label label8;
        private Button btnBrowseImage;
        private Button btnSaveChanges;
        private TextBox txtConfirmPassword;
        private Label label9;
        private TextBox txtPassword;
        private Label label7;
        private CheckBox cbStatus;
        private TextBox txtUsername;
        private Label label5;
        private TextBox txtMobile;
        private Label label6;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtSurname;
        private Label label3;
        private CheckedListBox clbRoles;
        private ErrorProvider errorProvider;
    }
}