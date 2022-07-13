using RS2Seminarski.Model;
using RS2Seminarski.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS2Seminarski.WinUI
{
    public partial class frmExercises : Form
    {
        public APIService ExerciseService { get; set; } = new APIService("Exercise");
        public APIService LevelService { get; set; } = new APIService("Level");

        public frmExercises()
        {
            InitializeComponent();
            dgvExerciseList.AutoGenerateColumns = false;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var frm = new frmUsers();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }

        private void btnRoutines_Click(object sender, EventArgs e)
        {
            var frm = new frmRoutines();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var frm = new frmSettings();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            var frm = new frmStats();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var searchObject = new ExerciseSearchObject();
            searchObject.ExerciseName = txtSearch.Text;

            var list = await ExerciseService.Get<List<Exercise>>(searchObject);

            dgvExerciseList.DataSource = list;
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            new frmAddEditExercise().Show();

        }
    }
}
