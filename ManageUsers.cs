﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace management_system
{
    public partial class ManageUsers: Form
    {
        public ManageUsers()
        {
            InitializeComponent();
            SqlConnection Con = new SqlConnection("@Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\HER EXCELLENCY\\OneDrive\\Documents\\inventory.db.mdf\";Integrated Security=True;Connect Timeout=30");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void catID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
