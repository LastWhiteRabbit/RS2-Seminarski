using RS2Seminarski.WinUI.Helpers;
using RS2Seminarski.WinUI.Services;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RS2Seminarski.WinUI
{
    public partial class frmStats : Form
    {
        private StatsAPI statsAPI;
        public frmStats()
        {
            InitializeComponent();
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

        private void frmStats_Load(object sender, EventArgs e)
        {
            cmbSearchBy.DataSource = cmbHelper.charts;

            loadExercisePerType();
        }

        private async void loadExercisePerType()
        {
            formsPlot2.Hide();
            formsPlot1.Show();
            formsPlot1.Plot.Clear();
            var response = await statsAPI.GetExercisesPerType();

            var labels = Enumerable.Range(0, response.Count)
                                   .Select(i => $"{response[i].Label}\n({response[i].Value})")
                                   .ToArray();

            var pie = formsPlot1.Plot.AddPie(response.Select(x => (double)x.Value).ToArray());

            pie.SliceLabels = labels;
            pie.ShowLabels = true;
            formsPlot1.Plot.Legend();
            formsPlot1.Refresh();

            formsPlot1.Plot.YLabel("");
            formsPlot1.Plot.XLabel("");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
