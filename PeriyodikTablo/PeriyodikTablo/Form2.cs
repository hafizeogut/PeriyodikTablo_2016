using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PeriyodikTablo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cboxGrub.SelectedIndex = 0; 
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.Oledb.4.0;Data Source = vt\\vt.mdb");
        private void Ara()
        {
            baglanti.Open();
            string Ara = Convert.ToString(txtAra.Text);
            OleDbCommand aramaKomutu = new OleDbCommand("SELECT * FROM PeriyodikTablo WHERE ElementAdi like '%" + Ara + "%'", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(aramaKomutu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGoster.DataSource = dt;
            baglanti.Close();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
              
             
                if (txtAra.Text == "")
                {
                    MessageBox.Show("İLK ÖNCE VERİ GİRİŞİ YAPMALISINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    Ara();
            }

        }

        private void btnForm1eGec_Click(object sender, EventArgs e)
        {
            Form1 gecisYap = new Form1();
            gecisYap.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Temizle(); 
        }

        private void btnPanelCikis_Click(object sender, EventArgs e)
        {
            pElement.Visible = false;
            pElement.Width = 10;
            pElement.Height = 10;
            pElement.Left = 10;
            pElement.Top = 10;
            btnCikis.Visible = true;
            txtAra.Visible = true;
            btnAra.Visible = true;
            btnForm1eGec.Visible = true;
            btnHepsiniGoster.Visible = true;
            lbl1.Visible = false;
            gboxElement.Visible = true;
            btnTemizle.Visible = true;
            label3.Visible = true;
            txtAra.Text = "";
            txtAra.Focus();
        } 
        private void dgvGoster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pElement.Visible = true;
            pElement.Width = 521;
            pElement.Height = 526;
            pElement.Left = 214;
            pElement.Top = 0;
            lblElementAdi.Text = dgvGoster.Rows[e.RowIndex].Cells[1].Value.ToString();
            lblElementSerisi.Text = dgvGoster.Rows[e.RowIndex].Cells[2].Value.ToString();
            lblPeriyot.Text = dgvGoster.Rows[e.RowIndex].Cells[3].Value.ToString();
            lblAtomNumarasi.Text = dgvGoster.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblAtomSembolu.Text = dgvGoster.Rows[e.RowIndex].Cells[5].Value.ToString();
            lblGorunus.Text = dgvGoster.Rows[e.RowIndex].Cells[6].Value.ToString();
            lblEvrendekiYeri.Text = dgvGoster.Rows[e.RowIndex].Cells[7].Value.ToString();
            lblIzotop.Text = dgvGoster.Rows[e.RowIndex].Cells[8].Value.ToString();
            lblProton.Text = dgvGoster.Rows[e.RowIndex].Cells[9].Value.ToString();
            lblNotron.Text = dgvGoster.Rows[e.RowIndex].Cells[10].Value.ToString();
            lblElektron.Text = dgvGoster.Rows[e.RowIndex].Cells[11].Value.ToString();
            lblKatman.Text = dgvGoster.Rows[e.RowIndex].Cells[12].Value.ToString();
            lblMaddeninHali.Text = dgvGoster.Rows[e.RowIndex].Cells[13].Value.ToString(); 
            label3.Visible = false;
            txtAra.Visible = false;
            btnAra.Visible = false;
            btnForm1eGec.Visible = false;
            btnCikis.Visible = false;
            lbl1.Visible = false;
            btnHepsiniGoster.Visible = false;
            gboxElement.Visible = false;
            btnTemizle.Visible = false;
        }
        private void gosterKomut()
        {
            baglanti.Open();
            OleDbCommand gosterKomut = new OleDbCommand("SELECT * FROM PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(gosterKomut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGoster.DataSource = dt;
            baglanti.Close();  
            dgvGoster.Columns[1].HeaderText = "ELEMENT ADI";
            dgvGoster.Columns[2].HeaderText = "ELEMENT SERİSİ";
            dgvGoster.Columns[3].HeaderText = "GRUP,PERİYOT,BLOK";
            dgvGoster.Columns[4].HeaderText = "ATOM NUMARASI";
            dgvGoster.Columns[5].HeaderText = "SEMBOLÜ";
            dgvGoster.Columns[6].HeaderText = "GÖRÜNÜŞÜ";
            dgvGoster.Columns[7].HeaderText = "EVRENDEKİ YERİ";
            dgvGoster.Columns[8].HeaderText = "İZOTOPLARI";
            dgvGoster.Columns[9].HeaderText = "PROTON SAYISI";
            dgvGoster.Columns[10].HeaderText = "NOTRON SAYISI";
            dgvGoster.Columns[11].HeaderText = "ELEKTRON SAYISI";
            dgvGoster.Columns[12].HeaderText = "KATMAN SAYISI";
            dgvGoster.Columns[13].HeaderText = "MADDENİN HALİ"; 
         
        }
        private void btnHepsiniGoster_Click(object sender, EventArgs e)
        {
            gosterKomut();
        }
        private void Temizle()
        {
            txtAra.Text = "";
            txtAra.Focus();
            DataTable dt = new DataTable();
            dgvGoster.DataSource = dt;
            dt.Clear();
            lblAtomNumarasi.Text = "";
            lblAtomSembolu.Text = "";
            lblElektron.Text = ""; 
            lblElementAdi.Text = "";
            lblElementSerisi.Text = "";
            lblEvrendekiYeri.Text = "";
            lblGorunus.Text = "";
            lblIzotop.Text = "";
            lblKatman.Text = "";
            lblMaddeninHali.Text = ""; 
            lblPeriyot.Text = "";
            lblProton.Text = "";


        }
        private void btnTemizle_Click(object sender, EventArgs e)
        { 
            Temizle(); 
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
              
           string kelime = txtAra.Text;
            txtAra.Text = kelime.ToUpper();
            Ara(); 
        }
       

        private void cboxGrub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboxGrub.SelectedIndex == 9) || (cboxGrub.SelectedIndex == 10) || (cboxGrub.SelectedIndex == 11) || (cboxGrub.SelectedIndex == 12))
            {
                baglanti.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from PeriyodikTablo where MaddeninHali ='" + cboxGrub.SelectedItem.ToString() + "'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGoster.DataSource = dt;
                baglanti.Close();
            }
            else
           {
            baglanti.Open();
            OleDbDataAdapter da =new OleDbDataAdapter("select * from PeriyodikTablo where ElementSerisi ='"+cboxGrub.SelectedItem.ToString()+"'",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGoster.DataSource = dt;
            baglanti.Close();
           }
        } 

         
    }
}
