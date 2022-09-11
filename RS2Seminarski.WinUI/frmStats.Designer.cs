namespace RS2Seminarski.WinUI
{
    partial class frmStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStats));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btnDeleteExercise = new System.Windows.Forms.Button();
            this.btnEditExercise = new System.Windows.Forms.Button();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRoutines = new System.Windows.Forms.Button();
            this.btnExercises = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.formsPlot2 = new ScottPlot.FormsPlot();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label1.TabIndex = 47;
            this.label1.Text = "IronVault";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.logout_3622;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(670, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(46, 43);
            this.btnLogout.TabIndex = 46;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRole.Location = new System.Drawing.Point(596, 50);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 45;
            this.lblRole.Text = "Role";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(579, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 44;
            this.lblUsername.Text = "Username";
            // 
            // pbUser
            // 
            this.pbUser.Location = new System.Drawing.Point(476, 12);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(78, 65);
            this.pbUser.TabIndex = 43;
            this.pbUser.TabStop = false;
            // 
            // btnDeleteExercise
            // 
            this.btnDeleteExercise.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btnDeleteExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteExercise.Location = new System.Drawing.Point(130, 348);
            this.btnDeleteExercise.Name = "btnDeleteExercise";
            this.btnDeleteExercise.Size = new System.Drawing.Size(53, 58);
            this.btnDeleteExercise.TabIndex = 41;
            this.btnDeleteExercise.UseVisualStyleBackColor = true;
            // 
            // btnEditExercise
            // 
            this.btnEditExercise.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.btnEditExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditExercise.Location = new System.Drawing.Point(71, 348);
            this.btnEditExercise.Name = "btnEditExercise";
            this.btnEditExercise.Size = new System.Drawing.Size(53, 58);
            this.btnEditExercise.TabIndex = 40;
            this.btnEditExercise.UseVisualStyleBackColor = true;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.plus_icon_183962;
            this.btnAddExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddExercise.Location = new System.Drawing.Point(12, 348);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(53, 58);
            this.btnAddExercise.TabIndex = 39;
            this.btnAddExercise.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.stats_icon_icons_com_65379;
            this.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStats.Location = new System.Drawing.Point(26, 251);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(139, 44);
            this.btnStats.TabIndex = 38;
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources._3592841_cog_gear_general_machine_office_setting_settings_107765;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Location = new System.Drawing.Point(26, 209);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(139, 44);
            this.btnSettings.TabIndex = 37;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRoutines
            // 
            this.btnRoutines.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.clipboard_120835;
            this.btnRoutines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRoutines.Location = new System.Drawing.Point(26, 167);
            this.btnRoutines.Name = "btnRoutines";
            this.btnRoutines.Size = new System.Drawing.Size(139, 44);
            this.btnRoutines.TabIndex = 36;
            this.btnRoutines.UseVisualStyleBackColor = true;
            this.btnRoutines.Click += new System.EventHandler(this.btnRoutines_Click);
            // 
            // btnExercises
            // 
            this.btnExercises.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.weight5_42665;
            this.btnExercises.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExercises.Location = new System.Drawing.Point(26, 125);
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.Size = new System.Drawing.Size(139, 44);
            this.btnExercises.TabIndex = 35;
            this.btnExercises.UseVisualStyleBackColor = true;
            this.btnExercises.Click += new System.EventHandler(this.btnExercises_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.BackgroundImage")));
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsers.Location = new System.Drawing.Point(26, 83);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(139, 44);
            this.btnUsers.TabIndex = 34;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.formsPlot2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbSearchBy);
            this.groupBox1.Controls.Add(this.formsPlot1);
            this.groupBox1.Location = new System.Drawing.Point(213, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 320);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // formsPlot2
            // 
            this.formsPlot2.Location = new System.Drawing.Point(10, 81);
            this.formsPlot2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlot2.Name = "formsPlot2";
            this.formsPlot2.Size = new System.Drawing.Size(484, 255);
            this.formsPlot2.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(385, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Location = new System.Drawing.Point(60, 39);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(319, 28);
            this.cmbSearchBy.TabIndex = 7;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(10, 81);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(484, 255);
            this.formsPlot1.TabIndex = 6;
            // 
            // frmStats
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
            this.Controls.Add(this.btnDeleteExercise);
            this.Controls.Add(this.btnEditExercise);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnRoutines);
            this.Controls.Add(this.btnExercises);
            this.Controls.Add(this.btnUsers);
            this.Name = "frmStats";
            this.Text = "frmStats";
            this.Load += new System.EventHandler(this.frmStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Label lblRole;
        private Label lblUsername;
        private PictureBox pbUser;
        private Button btnDeleteExercise;
        private Button btnEditExercise;
        private Button btnAddExercise;
        private Button btnStats;
        private Button btnSettings;
        private Button btnRoutines;
        private Button btnExercises;
        private Button btnUsers;
        private GroupBox groupBox1;
        private ScottPlot.FormsPlot formsPlot1;
        private Button btnSearch;
        private ComboBox cmbSearchBy;
        private ScottPlot.FormsPlot formsPlot2;
    }
}