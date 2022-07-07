namespace RS2Seminarski.WinUI
{
    partial class frmExercises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercises));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteExercise = new System.Windows.Forms.Button();
            this.btnEditExercise = new System.Windows.Forms.Button();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRoutines = new System.Windows.Forms.Button();
            this.btnExercises = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvExerciseList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExerciseList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(213, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "IronVault";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.logout_3622;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(670, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(46, 43);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRole.Location = new System.Drawing.Point(596, 50);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 29;
            this.lblRole.Text = "Role";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(579, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 28;
            this.lblUsername.Text = "Username";
            // 
            // pbUser
            // 
            this.pbUser.Location = new System.Drawing.Point(476, 12);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(78, 65);
            this.pbUser.TabIndex = 27;
            this.pbUser.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(209, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 27);
            this.txtSearch.TabIndex = 26;
            // 
            // btnDeleteExercise
            // 
            this.btnDeleteExercise.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btnDeleteExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteExercise.Location = new System.Drawing.Point(130, 348);
            this.btnDeleteExercise.Name = "btnDeleteExercise";
            this.btnDeleteExercise.Size = new System.Drawing.Size(53, 58);
            this.btnDeleteExercise.TabIndex = 25;
            this.btnDeleteExercise.UseVisualStyleBackColor = true;
            // 
            // btnEditExercise
            // 
            this.btnEditExercise.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.btnEditExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditExercise.Location = new System.Drawing.Point(71, 348);
            this.btnEditExercise.Name = "btnEditExercise";
            this.btnEditExercise.Size = new System.Drawing.Size(53, 58);
            this.btnEditExercise.TabIndex = 24;
            this.btnEditExercise.UseVisualStyleBackColor = true;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.plus_icon_183962;
            this.btnAddExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddExercise.Location = new System.Drawing.Point(12, 348);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(53, 58);
            this.btnAddExercise.TabIndex = 23;
            this.btnAddExercise.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.stats_icon_icons_com_65379;
            this.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStats.Location = new System.Drawing.Point(26, 251);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(139, 44);
            this.btnStats.TabIndex = 22;
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources._3592841_cog_gear_general_machine_office_setting_settings_107765;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Location = new System.Drawing.Point(26, 209);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(139, 44);
            this.btnSettings.TabIndex = 21;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnRoutines
            // 
            this.btnRoutines.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.clipboard_120835;
            this.btnRoutines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRoutines.Location = new System.Drawing.Point(26, 167);
            this.btnRoutines.Name = "btnRoutines";
            this.btnRoutines.Size = new System.Drawing.Size(139, 44);
            this.btnRoutines.TabIndex = 20;
            this.btnRoutines.UseVisualStyleBackColor = true;
            // 
            // btnExercises
            // 
            this.btnExercises.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.weight5_42665;
            this.btnExercises.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExercises.Location = new System.Drawing.Point(26, 125);
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.Size = new System.Drawing.Size(139, 44);
            this.btnExercises.TabIndex = 19;
            this.btnExercises.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.BackgroundImage")));
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsers.Location = new System.Drawing.Point(26, 83);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(139, 44);
            this.btnUsers.TabIndex = 18;
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(319, 16);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(94, 29);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // dgvExerciseList
            // 
            this.dgvExerciseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExerciseList.Location = new System.Drawing.Point(209, 83);
            this.dgvExerciseList.Name = "dgvExerciseList";
            this.dgvExerciseList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvExerciseList.RowTemplate.Height = 29;
            this.dgvExerciseList.Size = new System.Drawing.Size(483, 253);
            this.dgvExerciseList.TabIndex = 16;
            // 
            // frmExercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDeleteExercise);
            this.Controls.Add(this.btnEditExercise);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnRoutines);
            this.Controls.Add(this.btnExercises);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvExerciseList);
            this.Name = "frmExercises";
            this.Text = "frmExercises";
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExerciseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Label lblRole;
        private Label lblUsername;
        private PictureBox pbUser;
        private TextBox txtSearch;
        private Button btnDeleteExercise;
        private Button btnEditExercise;
        private Button btnAddExercise;
        private Button btnStats;
        private Button btnSettings;
        private Button btnRoutines;
        private Button btnExercises;
        private Button btnUsers;
        private Button btnShow;
        private DataGridView dgvExerciseList;
    }
}