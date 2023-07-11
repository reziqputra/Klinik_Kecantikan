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
    public partial class Perawatan : Form
    {
        private string stringConnection = "data source = MSI;" + "database=klinik_kecantikan;User ID = sa; Password = 12345";
        private SqlConnection koneksi;
        private string idprwtn, iddktr,idpasien, jp, durasi, harga;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtHRG.Enabled = true;
            txtDRS.Enabled = true;
            txtJP.Enabled = true;

            cbxIDP.Enabled = true;
            cbxIDD.Enabled = true;
            txtPRWTN.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;

            PScbx();
            DKcbx();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idprwtn = txtPRWTN.Text;
            iddktr = cbxIDD.Text;
            idpasien = cbxIDP.Text;
            jp = txtJP.Text;
            durasi = txtDRS.Text;
            harga = txtHRG.Text;
            koneksi.Open();
            string strr = "select id_dokter from dbo.Dokter where nama_dokter = @dd";
            SqlCommand cm = new SqlCommand(strr, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("dd", iddktr));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                iddktr = dr["id_dokter"].ToString();
            }
            dr.Close();

            string st = "select id_pasien from dbo.Pasien where nama_pasien = @pp";
            SqlCommand cmm = new SqlCommand(st, koneksi);
            cmm.CommandType = CommandType.Text;
            cmm.Parameters.Add(new SqlParameter("@pp", idpasien));
            SqlDataReader kr = cmm.ExecuteReader();
            while (kr.Read())
            {
                idpasien = kr["id_pasien"].ToString();
            }
            kr.Close();

            string sr = "INSERT INTO Perawatan_Kecantikan (id_perawatanK, id_dokter, id_pasien, jenis_perawatan, durasi, harga)" +
            "VALUES(@idpr,@idd,@idp,@jp,@drs,@hrg) ";
            SqlCommand cmd = new SqlCommand(sr, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("idpr", idprwtn);
            cmd.Parameters.Add("idd", iddktr);
            cmd.Parameters.Add("idp", idpasien);
            cmd.Parameters.Add("jp", jp);
            cmd.Parameters.Add("drs", durasi);
            cmd.Parameters.Add("umur", harga);
            
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        public Perawatan()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void DKcbx()
        {
            koneksi.Open();
            string str = "select nama_dokter from dbo.Dokter";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxIDD.DisplayMember = "nama_dokter";
            cbxIDD.ValueMember = "id_dokter";
            cbxIDD.DataSource = ds.Tables[0];
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
            cbxIDP.DisplayMember = "nama_pasien";
            cbxIDP.ValueMember = "id_pasien";
            cbxIDP.DataSource = ds.Tables[0];
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            HalamanUtama hu = new HalamanUtama();
            hu.Show();
            this.Hide();
        }
        private void refreshform()
        {
            
            
            txtJP.Text = "";
            txtDRS.Text = "";
            txtHRG.Text = "";
            txtHRG.Enabled = false;
            txtDRS.Enabled = false;
            txtJP.Enabled = false;
            
            cbxIDP.Enabled = false;
            cbxIDD.Enabled = false;
            txtPRWTN.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;


        }

    }
}
