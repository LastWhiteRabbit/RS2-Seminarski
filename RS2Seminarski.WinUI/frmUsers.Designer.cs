namespace RS2Seminarski.WinUI
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RoleNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnExercises = new System.Windows.Forms.Button();
            this.btnRoutines = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserList
            // 
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameUser,
            this.Surname,
            this.Email,
            this.Mobile,
            this.UserName,
            this.Status,
            this.RoleNames});
            this.dgvUserList.Location = new System.Drawing.Point(209, 83);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.RowHeadersWidth = 51;
            this.dgvUserList.RowTemplate.Height = 29;
            this.dgvUserList.Size = new System.Drawing.Size(483, 253);
            this.dgvUserList.TabIndex = 0;
            // 
            // NameUser
            // 
            this.NameUser.DataPropertyName = "Name";
            this.NameUser.HeaderText = "Name";
            this.NameUser.MinimumWidth = 6;
            this.NameUser.Name = "NameUser";
            this.NameUser.Width = 125;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.MinimumWidth = 6;
            this.Mobile.Name = "Mobile";
            this.Mobile.Width = 125;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 125;
            // 
            // RoleNames
            // 
            this.RoleNames.DataPropertyName = "RoleNames";
            this.RoleNames.HeaderText = "Roles";
            this.RoleNames.MinimumWidth = 6;
            this.RoleNames.Name = "RoleNames";
            this.RoleNames.Width = 125;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(319, 16);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(94, 29);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Search";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.BackgroundImage")));
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsers.Location = new System.Drawing.Point(26, 83);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(139, 44);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnExercises
            // 
            this.btnExercises.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.weight5_42665;
            this.btnExercises.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExercises.Location = new System.Drawing.Point(26, 125);
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.Size = new System.Drawing.Size(139, 44);
            this.btnExercises.TabIndex = 3;
            this.btnExercises.UseVisualStyleBackColor = true;
            // 
            // btnRoutines
            // 
            this.btnRoutines.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.clipboard_120835;
            this.btnRoutines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRoutines.Location = new System.Drawing.Point(26, 167);
            this.btnRoutines.Name = "btnRoutines";
            this.btnRoutines.Size = new System.Drawing.Size(139, 44);
            this.btnRoutines.TabIndex = 4;
            this.btnRoutines.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources._3592841_cog_gear_general_machine_office_setting_settings_107765;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Location = new System.Drawing.Point(26, 209);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(139, 44);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.stats_icon_icons_com_65379;
            this.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStats.Location = new System.Drawing.Point(26, 251);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(139, 44);
            this.btnStats.TabIndex = 6;
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.adduser_añadir_3553;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.Location = new System.Drawing.Point(12, 348);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(53, 58);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditUser.Location = new System.Drawing.Point(71, 348);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(53, 58);
            this.btnEditUser.TabIndex = 8;
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteUser.Location = new System.Drawing.Point(130, 348);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(53, 58);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(209, 50);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(204, 27);
            this.txtSearchUser.TabIndex = 10;
            // 
            // pbUser
            // 
            this.pbUser.Location = new System.Drawing.Point(476, 12);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(78, 65);
            this.pbUser.TabIndex = 11;
            this.pbUser.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(579, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRole.Location = new System.Drawing.Point(596, 50);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Role";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.logout_3622;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(670, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(46, 43);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(213, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "IronVault";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnRoutines);
            this.Controls.Add(this.btnExercises);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvUserList);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvUserList;
        private Button btnShow;
        private Button btnUsers;
        private Button btnExercises;
        private Button btnRoutines;
        private Button btnSettings;
        private Button btnStats;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private TextBox txtSearchUser;
        private PictureBox pbUser;
        private Label lblUsername;
        private Label lblRole;
        private Button btnLogout;
        private Label label1;
        private DataGridViewTextBoxColumn NameUser;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn RoleNames;
    }
}