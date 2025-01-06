using ForestResourceManagement.Controllers;
using ForestResourceManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestResourceManagement.MixForm
{
    public partial class QuanLyDongVat : Form
    {
        private FrdbContext _dbContext;
        private ForestControllerUserAccounts _controllerUserAccounts;
        private BindingSource _bindingSource;
        public QuanLyDongVat()
        {
            _dbContext = new FrdbContext();
            _controllerUserAccounts = new ForestControllerUserAccounts(_dbContext);
            InitializeComponent();
        }
    }
}
