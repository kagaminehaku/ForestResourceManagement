﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestResourceManagement
{
    public partial class MainUI : Form
    {
        private FrdbContext _dbContext;
        public MainUI()
        {
            InitializeComponent();
            _dbContext = new FrdbContext();

        }

    }
}
