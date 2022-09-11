using RS2Seminarski.Model;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WinUI.Services;
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
    public partial class frmRoutines : Form
    {
        public APIService RoutineService { get; set; } = new APIService("Routine");

        public frmRoutines()
        {
            InitializeComponent();
            dgvRoutineList.AutoGenerateColumns = false;

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var frm = new frmUsers();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }

        private void btnExercises_Click(object sender, EventArgs e)
        {
            var frm = new frmExercises();
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
            var searchObject = new RoutineSearchObject();
            searchObject.RoutineName = txtSearch.Text;

            var list = await RoutineService.Get<List<Routine>>(searchObject);

            dgvRoutineList.DataSource = list; 
        }
    }
}
