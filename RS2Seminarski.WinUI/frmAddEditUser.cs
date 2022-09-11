using RS2Seminarski.Model;
using RS2Seminarski.Model.Requests;
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
    public partial class frmAddEditUser : Form
    {
        public APIService UserService { get; set; } = new APIService("User");
        public APIService RoleService { get; set; } = new APIService("Role");

        private User _model = null;

        public frmAddEditUser(User model = null)
        {
            InitializeComponent();
            _model = model;
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var roleList = clbRoles.CheckedItems.Cast<Role>().ToList();
                var roleIdList = roleList.Select(x => x.RoleId).ToList();

                if (_model == null)
                {
                    UserInsertRequest insertRequest = new UserInsertRequest()
                    {
                        Name = txtName.Text,
                        Surname = txtSurname.Text,
                        Email = txtEmail.Text,
                        Mobile = txtMobile.Text,
                        UserName = txtUsername.Text,
                        Password = txtPassword.Text,
                        PasswordConfirmation = txtConfirmPassword.Text,
                        Status = cbStatus.Checked,
                        RoleIdList = roleIdList
                    };

                    var user = await UserService.Post<User>(insertRequest);
                }

                else
                {
                    UserUpdateRequest updateRequest = new UserUpdateRequest
                    {
                        Name = txtName.Text,
                        Surname = txtSurname.Text,
                        Email = txtEmail.Text,
                        Mobile = txtMobile.Text,
                        Password = txtPassword.Text,
                        PasswordConfirmation = txtConfirmPassword.Text,
                        Status = cbStatus.Checked
                    };
                    _model = await UserService.Put<User>(_model.UserId, updateRequest);
                }
            }
        }

        private async void frmAddEditUser_Load(object sender, EventArgs e)
        {
            await LoadRoles();

            if(_model != null)
            {
                txtName.Text = _model.Name;
                txtSurname.Text = _model.Surname;
                txtEmail.Text = _model.Email;
                txtMobile.Text = _model.Mobile;
                cbStatus.Checked = _model.Status.GetValueOrDefault(false);
                txtUsername.Text = _model.UserName;
            }

        }
        private async Task LoadRoles()
        {
            var roles = await RoleService.Get<List<Role>>();
            clbRoles.DataSource = roles;
            clbRoles.DisplayMember = "Name";
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider.SetError(txtUsername, "Username should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUsername, "");
            }
        }
    }
}
