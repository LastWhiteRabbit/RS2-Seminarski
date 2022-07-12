using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using RS2Seminarski.Model;
using RS2Seminarski.Model.SearchObjects;

namespace RS2Seminarski.WinUI
{
    public partial class frmUsers : Form
    {
        public APIService UserService { get; set; } = new APIService("User");
        public frmUsers()
        {
            InitializeComponent();
            dgvUserList.AutoGenerateColumns = false;
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var searchObject = new UserSearchObject();
            searchObject.UserName = txtSearchUser.Text;
            searchObject.IncludeRoles = true;

            var list = await UserService.Get<List<User>>(searchObject);

            dgvUserList.DataSource = list;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new frmAddEditUser().Show();
        }

        private void dgvUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvUserList.SelectedRows[0].DataBoundItem as User;

            frmAddEditUser frmAddEditUser = new frmAddEditUser(item);
            frmAddEditUser.ShowDialog();
        }
    }
}
