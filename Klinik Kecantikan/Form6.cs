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
    public partial class Dokter : Form
    {
        private string stringConnection = "data source = MSI;" + "database=klinik_kecantikan;User ID = sa; Password = 12345";
        private SqlConnection koneksi;
        private string idd, nd, nt, jk, s, p;
        public Dokter()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshform();
        }
        private void refreshform()
        {


            txtIDD.Text = "";
            txtND.Text = "";
            txtNT.Text = "";
            txtJK.Text = "";
            txtS.Text = "";
            txtS.Enabled = false;
            txtIDD.Enabled = false;
            txtND.Enabled = false;
            txtNT.Enabled = false;
            txtJK.Enabled = false;
            cbxP.Enabled = false;
            btnOpen.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data : " + txtIDD.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                koneksi.Open();
                string queryString = "Delete dbo.Dokter where id_dokter='" + txtIDD.Text + "'";
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
            string queryString = "Update dbo.Dokter set id_dokter='" + txtIDD.Text + "', nama_dokter='" + txtND.Text + "', no_telp='" + txtNT.Text + "', sex='" + txtJK.Text + "', spesialisasi='" + txtS.Text + "', id_pengalaman='" + cbxP.Text + "' where id_dokter='" + txtIDD.Text + "'";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Update Data Berhasil");
            dataGridView();
            refreshform();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HalamanUtama hu = new HalamanUtama();
            hu.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtS.Enabled = true;
            txtIDD.Enabled = true;
            txtND.Enabled = true;
            txtNT.Enabled = true;
            txtJK.Enabled = true;
            cbxP.Enabled = true;
            btnOpen.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            IPcbx();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Dokter";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void IPcbx()
        {
            koneksi.Open();
            string str = "select pengalaman from dbo.Pengalaman_Kerja";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxP.DisplayMember = "pengalaman";
            cbxP.ValueMember = "id_pengalaman";
            cbxP.DataSource = ds.Tables[0];
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                txtIDD.Text = row.Cells["id_dokter"].Value.ToString();
                txtND.Text = row.Cells["nama_dokter"].Value.ToString();
                txtNT.Text = row.Cells["no_telp"].Value.ToString();
                txtJK.Text = row.Cells["sex"].Value.ToString();
                txtS.Text = row.Cells["spesialisasi"].Value.ToString();
                cbxP.Text = row.Cells["id_pengalaman"].Value.ToString();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            txtS.Enabled = true;
            txtIDD.Enabled = true;
            txtND.Enabled = true;
            txtNT.Enabled = true;
            txtJK.Enabled = true;
            cbxP.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idd = txtIDD.Text;
            nd = txtND.Text;
            nt = txtNT.Text;
            jk = txtJK.Text;
            s = txtS.Text;
            p = cbxP.Text;
            koneksi.Open();
            string strr = "select id_pengalaman from dbo.Pengalaman_Kerja where pengalaman = @dd";
            SqlCommand cm = new SqlCommand(strr, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("dd", p));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                p = dr["id_pengalaman"].ToString();
            }
            dr.Close();

            string sr = "INSERT INTO Dokter (id_dokter, nama_dokter, no_telp, sex, spesialisasi, id_pengalaman)" +
            "VALUES(@idd,@nd,@nt,@jk,@s,@p) ";
            SqlCommand cmd = new SqlCommand(sr, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("idd", idd);
            cmd.Parameters.Add("nd", nd);
            cmd.Parameters.Add("nt", nt);
            cmd.Parameters.Add("jk", jk);
            cmd.Parameters.Add("s", s);
            cmd.Parameters.Add("p", p);
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }
    }
}
