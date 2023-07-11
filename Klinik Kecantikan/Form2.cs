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
    public partial class DataPasien : Form
    {
        private string stringConnection = "data source = MSI;" + "database=klinik_kecantikan;User ID = sa; Password = 12345";
        private SqlConnection koneksi;
        private string idpasien, namapasien, umur, jk, notlp, alamat, staff, jp, rk;
        public DataPasien()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void txtNamaP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HalamanUtama hu = new HalamanUtama();
            hu.Show();
            this.Hide();
        }
        private void refreshform()
        {
            txtIdPasien.Text = "";
            
            txtUmur.Text = "";
            txtNamaP.Text = "";
            txtNoTelp.Text = "";
            txtAlamat.Text = "";
            
            txtIdPasien.Enabled = false;
            txtUmur.Enabled = false;
            txtNamaP.Enabled = false;
            txtNoTelp.Enabled = false;
            txtAlamat.Enabled = false;
            cbxStaff.Enabled = false;
            cbxJP.Enabled = false;
            cbxRK.Enabled = false;
            cbxJK.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIdPasien.Enabled = true;
            txtUmur.Enabled = true;
            txtNamaP.Enabled = true;
            txtNoTelp.Enabled = true;
            txtAlamat.Enabled = true;
            cbxStaff.Enabled = true;
            cbxJK.Enabled = true;
            cbxRK.Enabled=true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idpasien = txtIdPasien.Text;
            namapasien = txtNamaP.Text;
            umur = txtUmur.Text;
            jk = cbxJK.Text;
            notlp = txtNoTelp.Text;
            alamat = txtAlamat.Text;
            koneksi.Open();
            string sr = "INSERT INTO Pasien (id_pasien, id_staff, nama_pasien, no_telp, sex, umur, id_riwayat, id_perawatan, alamat)" +
            "VALUES(@idpa,@ids,@nmp,@notlp,@sex,@umur,@idr,@idpe,@alamat) ";
            SqlCommand cmd = new SqlCommand(sr, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idpa", idpasien);
            cmd.Parameters.Add("@ids", staff);
            cmd.Parameters.Add("@nmp", namapasien);
            cmd.Parameters.Add("@notlp", notlp);
            cmd.Parameters.Add("@sex", jk);
            cmd.Parameters.Add("@umur", umur);
            cmd.Parameters.Add("@rk", rk);
            cmd.Parameters.Add("@idpe", jp);
            cmd.Parameters.Add("@alamat", alamat);
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();


        }
    }
}
