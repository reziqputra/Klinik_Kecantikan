using System;
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
    public partial class Produk : Form
    {
        private string stringConnection = "data source = MSI;" + "database=klinik_kecantikan;User ID = sa; Password = 12345";
        private SqlConnection koneksi;
        private string idprdk, idpsn, np, jp, hrg;
        public Produk()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HalamanUtama hu = new HalamanUtama();
            hu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data : " + txtIDP.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                koneksi.Open();
                string queryString = "Delete dbo.Produk_Kecantikan where id_produk='" + txtIDP.Text + "'";
                SqlCommand cmd = new SqlCommand(queryString, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Hapus Data Berhasil");
                dataGridView();
                refreshform();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string queryString = "Update dbo.Produk_Kecantikan set id_produk='" + txtIDP.Text + "', id_pasien='" + cbxIDPasien.Text + "', nama_produk='" + txtNP.Text + "', jenis_produk='" + txtJP.Text + "', harga='" + txtHRG.Text + "' where id_produk='" + txtIDP.Text + "'";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Update Data Berhasil");
            dataGridView();
            refreshform();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtHRG.Enabled = true;
            txtNP.Enabled = true;
            txtJP.Enabled = true;
            txtIDP.Enabled = true;
            cbxIDPasien.Enabled = true;
            btnOpen.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            PScbx();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtIDP.Text = row.Cells["id_produk"].Value.ToString();
                cbxIDPasien.Text = row.Cells["id_pasien"].Value.ToString();
                txtNP.Text = row.Cells["nama_produk"].Value.ToString();
                txtJP.Text = row.Cells["jenis_produk"].Value.ToString();
                txtHRG.Text = row.Cells["harga"].Value.ToString();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            txtHRG.Enabled = true;
            txtNP.Enabled = true;
            txtJP.Enabled = true;
            txtIDP.Enabled = true;
            cbxIDPasien.Enabled = true;
        }

        private void refreshform()
        {


            txtIDP.Text = "";
            txtNP.Text = "";
            txtJP.Text = "";
            txtHRG.Text = "";
            txtHRG.Enabled = false;
            txtNP.Enabled = false;
            txtJP.Enabled = false;
            txtIDP.Enabled = false;
            cbxIDPasien.Enabled = false;
            btnOpen.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idprdk = txtIDP.Text;
            idpsn = cbxIDPasien.Text;
            np = txtNP.Text;
            jp = txtJP.Text;
            hrg = txtHRG.Text;
            koneksi.Open();
            string strr = "select id_pasien from dbo.Pasien where nama_pasien = @dd";
            SqlCommand cm = new SqlCommand(strr, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("dd", idpsn));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idpsn = dr["id_pasien"].ToString();
            }
            dr.Close();

            string sr = "INSERT INTO Produk_Kecantikan (id_produk, id_pasien, nama_produk, jenis_produk, harga)" +
            "VALUES(@idr,@idp,@np,@jp,@hrg) ";
            SqlCommand cmd = new SqlCommand(sr, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("idr", idprdk);
            cmd.Parameters.Add("idp", idpsn);
            cmd.Parameters.Add("np", np);
            cmd.Parameters.Add("jp", jp);
            cmd.Parameters.Add("hrg", hrg);
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Produk_Kecantikan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void PScbx()
        {
            koneksi.Open();
            string str = "select nama_pasien from dbo.Pasien";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxIDPasien.DisplayMember = "nama_pasien";
            cbxIDPasien.ValueMember = "id_pasien";
            cbxIDPasien.DataSource = ds.Tables[0];
        }
    }
}
