namespace RS2Seminarski.WinUI
{
    partial class frmAddEditExercise
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btnDeleteRoutine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAlternativeExercise = new System.Windows.Forms.ComboBox();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clbTypes = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.pbExerciseImage = new System.Windows.Forms.PictureBox();
            this.btnSaveChangesAddExercise = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clbMuscles = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExerciseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox5.SuspendLayout();
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
            this.label1.TabIndex = 63;
            this.label1.Text = "IronVault";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.logout_3622;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(670, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(46, 43);
            this.btnLogout.TabIndex = 62;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRole.Location = new System.Drawing.Point(596, 50);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 61;
            this.lblRole.Text = "Role";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(579, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 60;
            this.lblUsername.Text = "Username";
            // 
            // pbUser
            // 
            this.pbUser.Location = new System.Drawing.Point(476, 12);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(78, 65);
            this.pbUser.TabIndex = 59;
            this.pbUser.TabStop = false;
            // 
            // btnDeleteRoutine
            // 
            this.btnDeleteRoutine.BackgroundImage = global::RS2Seminarski.WinUI.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btnDeleteRoutine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteRoutine.Location = new System.Drawing.Point(17, 348);
            this.btnDeleteRoutine.Name = "btnDeleteRoutine";
            this.btnDeleteRoutine.Size = new System.Drawing.Size(53, 58);
            this.btnDeleteRoutine.TabIndex = 57;
            this.btnDeleteRoutine.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAbout);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbAlternativeExercise);
            this.groupBox1.Controls.Add(this.txtInstruction);
            this.groupBox1.Controls.Add(this.cmbLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 125);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "About:";
            // 
            // txtAbout
            // 
            this.txtAbout.Location = new System.Drawing.Point(424, 46);
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(178, 70);
            this.txtAbout.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Instruction:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbAlternativeExercise
            // 
            this.cmbAlternativeExercise.FormattingEnabled = true;
            this.cmbAlternativeExercise.Location = new System.Drawing.Point(123, 88);
            this.cmbAlternativeExercise.Name = "cmbAlternativeExercise";
            this.cmbAlternativeExercise.Size = new System.Drawing.Size(111, 28);
            this.cmbAlternativeExercise.TabIndex = 7;
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(240, 46);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new System.Drawing.Size(178, 70);
            this.txtInstruction.TabIndex = 6;
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(6, 88);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(111, 28);
            this.cmbLevel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alternative exercise:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level:";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clbTypes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(96, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 197);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            // 
            // clbTypes
            // 
            this.clbTypes.FormattingEnabled = true;
            this.clbTypes.Location = new System.Drawing.Point(8, 53);
            this.clbTypes.Name = "clbTypes";
            this.clbTypes.Size = new System.Drawing.Size(142, 114);
            this.clbTypes.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Type:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnBrowseImage);
            this.groupBox4.Controls.Add(this.pbExerciseImage);
            this.groupBox4.Location = new System.Drawing.Point(479, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 153);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Image";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(105, 77);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(80, 31);
            this.btnBrowseImage.TabIndex = 1;
            this.btnBrowseImage.Text = "Browse...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            // 
            // pbExerciseImage
            // 
            this.pbExerciseImage.Location = new System.Drawing.Point(6, 21);
            this.pbExerciseImage.Name = "pbExerciseImage";
            this.pbExerciseImage.Size = new System.Drawing.Size(92, 87);
            this.pbExerciseImage.TabIndex = 0;
            this.pbExerciseImage.TabStop = false;
            // 
            // btnSaveChangesAddExercise
            // 
            this.btnSaveChangesAddExercise.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveChangesAddExercise.Location = new System.Drawing.Point(584, 368);
            this.btnSaveChangesAddExercise.Name = "btnSaveChangesAddExercise";
            this.btnSaveChangesAddExercise.Size = new System.Drawing.Size(126, 38);
            this.btnSaveChangesAddExercise.TabIndex = 68;
            this.btnSaveChangesAddExercise.Text = "Save changes";
            this.btnSaveChangesAddExercise.UseVisualStyleBackColor = false;
            this.btnSaveChangesAddExercise.Click += new System.EventHandler(this.btnSaveChangesAddExercise_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clbMuscles);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(281, 209);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(164, 197);
            this.groupBox5.TabIndex = 66;
            this.groupBox5.TabStop = false;
            // 
            // clbMuscles
            // 
            this.clbMuscles.FormattingEnabled = true;
            this.clbMuscles.Location = new System.Drawing.Point(8, 53);
            this.clbMuscles.Name = "clbMuscles";
            this.clbMuscles.Size = new System.Drawing.Size(142, 114);
            this.clbMuscles.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Main muscles:";
            // 
            // frmAddEditExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 418);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnSaveChangesAddExercise);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.btnDeleteRoutine);
            this.Name = "frmAddEditExercise";
            this.Text = "frmAddEditExercise";
            this.Load += new System.EventHandler(this.frmAddEditExercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExerciseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Label lblRole;
        private Label lblUsername;
        private PictureBox pbUser;
        private Button btnDeleteRoutine;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox cmbAlternativeExercise;
        private TextBox txtInstruction;
        private ComboBox cmbLevel;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private GroupBox groupBox2;
        private Label label6;
        private GroupBox groupBox4;
        private Label label8;
        private Button btnBrowseImage;
        private PictureBox pbExerciseImage;
        private Button btnSaveChangesAddExercise;
        private ErrorProvider errorProvider;
        private CheckedListBox clbTypes;
        private Label label9;
        private TextBox txtAbout;
        private GroupBox groupBox5;
        private CheckedListBox clbMuscles;
        private Label label10;
    }
}