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

namespace Disconnected_Environment
{
    public partial class Form3 : Form
    {
        private string stringConnection = "data source=fzhnsa\\MSSQLSERVER01;" + "database=prodi;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        private BindingSource CustomerBindingSource;

        private void clearBinding()
        {
            this.txtNIM.DataBindings.Clear();
            this.txtNama.DataBindings.Clear();
            this.txtAlamat.DataBindings.Clear();
            this.cbxJK.DataBindings.Clear();
            this.dtTanggalLahir.DataBindings.Clear();
            this.cbxProdi.DataBindings.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNIM.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            cbxJK.SelectedIndex = - 1;
            cbxProdi.SelectedIndex = -1;
            dtTanggalLahir.Value = DateTime.Now;
        }
        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            CustomerBindingSource = new BindingSource();
            refreshform();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshform()
        {
            txtNIM.Enabled = true;
            txtNama.Enabled = true;
            cbxJK.Enabled = true;
            txtAlamat.Enabled = true;
            dtTanggalLahir.Enabled = true;
            cbxProdi.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            clearBinding();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtTanggalLahir.Value = DateTime.Today;
            txtNIM.Enabled = true;
            txtNama.Enabled = true;
            cbxJK.Enabled = true;
            txtAlamat.Enabled = true;
            dtTanggalLahir.Enabled = true;
            cbxProdi.Enabled = true;
            Prodicbx();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            nim = txtNIM.Text.Trim();
            nama = txtNama.Text.Trim();
            alamat = txtAlamat.Text.Trim();
            jk = cbxJK.SelectedItem.ToString();
            prodi = cbxProdi.SelectedValue.ToString();
            tgl = dtTanggalLahir.Value;
            if (string.IsNullOrEmpty(nim) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(alamat) || string.IsNullOrEmpty(jk) || string.IsNullOrEmpty(prodi))
            {
                MessageBox.Show("Please fill in al identity fields!");
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO mahasiswa (nim, nama_mahasiswa, alamat, jeniis_kelamin, tgl_lahir, id_prodi) VALUES (@nim, @nama_mahasiswa, @alamat, @jenis_kel, @tgl_lahir, @id_prodi)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.AddWithValue("@nim", nim);
                cmd.Parameters.AddWithValue("@nama_mahasiswa", nama);
                cmd.Parameters.AddWithValue("@jenis_kel", jk);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@tgl_lahir", tgl);
                cmd.Parameters.AddWithValue("@id_prodi", prodi);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                MessageBox.Show("Data Berhasil Disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshform();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
                
        }

        private void Prodicbx()
        {
            koneksi.Open();
            string StringConnection = "select id_prodi, nama_prodi from dbo.Prodi";
            SqlCommand cmd = new SqlCommand(StringConnection, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            koneksi.Close();
            cbxProdi.DisplayMember = "nama_prodi";
            cbxProdi.ValueMember = "id_prodi";
            cbxProdi.DataSource = dt;
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
