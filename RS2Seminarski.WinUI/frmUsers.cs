﻿using System;
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

namespace RS2Seminarski.WinUI
{
    public partial class frmUsers : Form
    {
        public APIService ProductService { get; set; } = new APIService("User");
        public frmUsers()
        {
            InitializeComponent();
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var list = await ProductService.Get<List<User>>();
        }
    }
}
