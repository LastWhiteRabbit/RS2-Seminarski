using RS2Seminarski.Model;
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
    public partial class frmAddEditUser : Form
    {
        public APIService UserService { get; set; } = new APIService("User");
        public APIService RoleService { get; set; } = new APIService("Role");

        public frmAddEditUser()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private async void frmAddEditUser_Load(object sender, EventArgs e)
        {
            await LoadRoles();

        }
        private async Task LoadRoles()
        {
            var roles = await RoleService.Get<List<Role>>();
            clbRoles.DataSource = roles;
            clbRoles.DisplayMember = "Name";
        }
    }
}
