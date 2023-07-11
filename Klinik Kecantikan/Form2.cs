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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtIdPasien.Text = row.Cells["id_pasien"].Value.ToString();
                txtNamaP.Text = row.Cells["nama_pasien"].Value.ToString();
                txtUmur.Text = row.Cells["umur"].Value.ToString();
                txtJK.Text = row.Cells["sex"].Value.ToString();
                txtNoTelp.Text = row.Cells["no_telp"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                cbxStaff.Text = row.Cells["id_staff"].Value.ToString();
                cbxJP.Text = row.Cells["id_perawatan"].Value.ToString();
                cbxRK.Text = row.Cells["id_riwayat"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            txtIdPasien.Enabled = true;
            txtUmur.Enabled = true;
            txtNamaP.Enabled = true;
            txtNoTelp.Enabled = true;
            txtAlamat.Enabled = true;
            cbxStaff.Enabled = true;
            txtJK.Enabled = true;
            cbxRK.Enabled = true;
            cbxJP.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data : " + txtIdPasien.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                koneksi.Open();
                string queryString = "Delete dbo.Pasien where id_pasien='" + txtIdPasien.Text + "'";
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
            string queryString = "Update dbo.Pasien set id_staff='" + cbxStaff.Text + "', nama_pasien='" + txtNamaP.Text + "', no_telp='" + txtNoTelp.Text + "', sex='" + txtJK.Text + "', umur='" + txtUmur.Text + "', id_riwayat='" + cbxRK.Text + "', id_perawatan='" + cbxJP.Text + "', alamat='" + txtAlamat.Text + "' where id_pasien='" + txtIdPasien.Text + "'";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Update Data Berhasil");
            dataGridView();
            refreshform();
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
            txtJK.Enabled = false;
            btnAdd.Enabled = true;
            btnOpen.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
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
            txtJK.Enabled = true;
            cbxRK.Enabled=true;
            cbxJP.Enabled=true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            Staffcbx();
            RKcbx();
            JPcbx();

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
            jk = txtJK.Text;
            notlp = txtNoTelp.Text;
            staff = cbxStaff.Text;
            jp = cbxJP.Text;
            rk = cbxRK.Text;
            alamat = txtAlamat.Text;
            koneksi.Open();
            string strr = "select id_staff from dbo.Staff where nama_staff = @dd";
            SqlCommand cm = new SqlCommand(strr, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("dd", staff));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                staff = dr["id_staff"].ToString();
            }
            dr.Close();

            string st = "select id_riwayat from dbo.Riwayat_Kesehatan where nama_penyakit = @pp";
            SqlCommand cmm = new SqlCommand(st, koneksi);
            cmm.CommandType = CommandType.Text;
            cmm.Parameters.Add(new SqlParameter("@pp", rk));
            SqlDataReader kr = cmm.ExecuteReader();
            while (kr.Read())
            {
                rk = kr["id_riwayat"].ToString();
            }
            kr.Close();

            string srr = "select id_perawatan from dbo.Jenis_Perawatan where nama_perawatan = @rr";
            SqlCommand cmn = new SqlCommand(srr, koneksi);
            cmn.CommandType = CommandType.Text;
            cmn.Parameters.Add(new SqlParameter("@rr", jp));
            SqlDataReader rd = cmn.ExecuteReader();
            while (rd.Read())
            {
                jp = rd["id_perawatan"].ToString();
            }
            rd.Close();
            string sr = "INSERT INTO Pasien (id_pasien, id_staff, nama_pasien, no_telp, sex, umur, id_riwayat, id_perawatan, alamat)" +
            "VALUES(@idpa,@ids,@nmp,@notlp,@sex,@umur,@idr,@idpe,@alamat) ";
            SqlCommand cmd = new SqlCommand(sr, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("idpa", idpasien);
            cmd.Parameters.Add("ids", staff);
            cmd.Parameters.Add("nmp", namapasien);
            cmd.Parameters.Add("notlp", notlp);
            cmd.Parameters.Add("sex", jk);
            cmd.Parameters.Add("umur", umur);
            cmd.Parameters.Add("idr", rk);
            cmd.Parameters.Add("idpe", jp);
            cmd.Parameters.Add("alamat", alamat);
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();


        }
        private void Staffcbx()
        {
            koneksi.Open();
            string str = "select nama_staff from dbo.Staff";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxStaff.DisplayMember = "nama_staff";
            cbxStaff.ValueMember = "id_staff";
            cbxStaff.DataSource = ds.Tables[0];

        }

        private void RKcbx()
        {
            koneksi.Open();
            string str = "select nama_penyakit from dbo.Riwayat_Kesehatan";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxRK.DisplayMember = "nama_penyakit";
            cbxRK.ValueMember = "id_riwayat";
            cbxRK.DataSource = ds.Tables[0];
        }
        private void JPcbx()
        {
            koneksi.Open();
            string str = "select nama_perawatan from dbo.Jenis_Perawatan";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxJP.DisplayMember = "nama_perawatan";
            cbxJP.ValueMember = "id_perawatan";
            cbxJP.DataSource = ds.Tables[0];
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Pasien";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
    }
}
