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

namespace Klinik_Kecantikan
{
    public partial class HalamanUtama : Form
    {
        private string stringConnection = "data source = MSI;" + "database=klinik_kecantikan;User ID = sa; Password = 12345";
        private SqlConnection koneksi;
        public HalamanUtama()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataPasien dp = new DataPasien();
            dp.Show();
            this.Hide();
        }
    }
}
