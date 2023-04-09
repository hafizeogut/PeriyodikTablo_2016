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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.Oledb.4.0;Data Source = vt\\vt.mdb");
        Form2 arama = new Form2();
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pKontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrKayanYazi_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void tmrTarihZaman_Tick(object sender, EventArgs e)
        {
            tsslTarih.Text = DateTime.Now.ToLongDateString();
            tsslSaat.Text = DateTime.Now.ToLongTimeString();
           
        }


        private void VisibleAktf()
        {
            btnAramaYap.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            lblDmetal.Visible = true;
            lblHolojen.Visible = true;
            lblSoygaz.Visible = true;
            lblYmetal.Visible = true;
            lblAmetal.Visible = true;
            lblGecmetal.Visible = true;
            lblAraGec.Visible = true;
            lblAlkTMetaller.Visible = true;
            btnAktinit.Text = " 57-71 ";
            label70.ForeColor = Color.Black;
            btnLantanin.Text = " 89-103 ";
            label69.ForeColor = Color.Black;

        }
        private void Pasiflik()
        {
            btnAramaYap.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            lblDmetal.Visible = false;
            lblHolojen.Visible = false;
            lblSoygaz.Visible = false;
            lblYmetal.Visible = false;
            lblAmetal.Visible = false;
            lblGecmetal.Visible = false;
            lblAraGec.Visible = false;
            lblAlkTMetaller.Visible = false;
            pElement.BackgroundImage = Properties.Resources.ArkaRenk; 
            pElement.Visible = true; 
            pElement.Width = 870;
            pElement.Height = 601;
            pElement.Left = 12;
            pElement.Top = 0; 
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {  
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            arama.Show();
            this.Hide(); 
        }

        private void kULLANIMALANLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://tr.wikipedia.org/wiki/Periyodik_tablo-dan yardım alabilirsiniz", "-PERİYODİK İŞLEM İÇİN", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
        }

        private void kULLANIMALALARIToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pKullanAln.Width = 1357;
            pKullanAln.Height = 692;
            pKullanAln.Left = 2;
            btnKullanAln.Top = 2;
            btnKullanAln.Width = 1348;
            btnKullanAln.Height = 681;
            btnKullanAln.Left = 4;
            btnKullanAln.Top = 6;
            btnKullanKapatt.Visible = true;
            btnKullanKapatt.Width = 79;
            btnKullanKapatt.Height = 65;
            btnKullanKapatt.Left = 1273;
            btnKullanKapatt.Top = 6;
            btnKullanAln.Visible = true;
            pKullanAln.Visible = true;
            pKontrol.Visible = false;
        }

        private void btnKullanKapatt_Click(object sender, EventArgs e)
        {

            pKullanAln.Width = 10;
            pKullanAln.Height = 10;
            pKullanAln.Left = 10;
            btnKullanAln.Top = 10;
            btnKullanAln.Width = 10;
            btnKullanAln.Height = 10;
            btnKullanAln.Left = 10;
            btnKullanAln.Top = 10;
            btnKullanKapatt.Width = 10;
            btnKullanKapatt.Height = 10;
            btnKullanKapatt.Left = 10;
            btnKullanKapatt.Top = 10;
            btnKullanKapatt.Visible = false;
            btnKullanAln.Visible = false;
            pKullanAln.Visible = false;
            pElement.Visible = true;
            pKontrol.Visible = true;
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#'CILAR", "HAKKIMIZDA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            pElement.Width = 10;
            pElement.Height = 10;
            pElement.Left = 10;
            pElement.Top = 10;
            pElement.Visible = false;
            pboxResim.ImageLocation = "";
            lblElementAdi.Text = "";
            lblElementSerisi.Text = "";
            lblPeriyot.Text = "";
            lblAtomNumarasi.Text = "";
            lblAtomSembolu.Text = "";
            lblGorunus.Text = "";
            lblEvrendekiYeri.Text = "";
            lblIzotop.Text = "";
            lblProton.Text = "";
            lblNotron.Text = "";
            lblElektron.Text = "";
            lblKatman.Text = "";
            lblMaddeninHali.Text = "";
            VisibleAktf();
        } 
        private void btnHidrojen_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "HIDROJEN.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Helement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[0][1].ToString();
            lblElementSerisi.Text = dt.Rows[0][2].ToString();
            lblPeriyot.Text = dt.Rows[0][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[0][4].ToString();
            lblAtomSembolu.Text = dt.Rows[0][5].ToString();
            lblGorunus.Text = dt.Rows[0][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[0][7].ToString();
            lblIzotop.Text = dt.Rows[0][8].ToString();
            lblProton.Text = dt.Rows[0][9].ToString();
            lblNotron.Text = dt.Rows[0][10].ToString();
            lblElektron.Text = dt.Rows[0][11].ToString();
            lblKatman.Text = dt.Rows[0][12].ToString();
            lblMaddeninHali.Text = dt.Rows[0][13].ToString();
         
        }

        private void btnHelyum_Click(object sender, EventArgs e)
        {

            Pasiflik(); 
            pboxResim.ImageLocation = "HELYUM.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.HeElement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[1][1].ToString();
            lblElementSerisi.Text = dt.Rows[1][2].ToString();
            lblPeriyot.Text = dt.Rows[1][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[1][4].ToString();
            lblAtomSembolu.Text = dt.Rows[1][5].ToString();
            lblGorunus.Text = dt.Rows[1][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[1][7].ToString();
            lblIzotop.Text = dt.Rows[1][8].ToString();
            lblProton.Text = dt.Rows[1][9].ToString();
            lblNotron.Text = dt.Rows[1][10].ToString();
            lblElektron.Text = dt.Rows[1][11].ToString();
            lblKatman.Text = dt.Rows[1][12].ToString();
            lblMaddeninHali.Text = dt.Rows[1][13].ToString();

            
        }

        private void btnLityum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "lityum.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.LITYUMelement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[2][1].ToString();
            lblElementSerisi.Text = dt.Rows[2][2].ToString();
            lblPeriyot.Text = dt.Rows[2][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[2][4].ToString();
            lblAtomSembolu.Text = dt.Rows[2][5].ToString();
            lblGorunus.Text = dt.Rows[2][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[2][7].ToString();
            lblIzotop.Text = dt.Rows[2][8].ToString();
            lblProton.Text = dt.Rows[2][9].ToString();
            lblNotron.Text = dt.Rows[2][10].ToString();
            lblElektron.Text = dt.Rows[2][11].ToString();
            lblKatman.Text = dt.Rows[2][12].ToString();
            lblMaddeninHali.Text = dt.Rows[2][13].ToString(); 
        }

        private void btnBerilyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Be.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.BeElement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[3][1].ToString();
            lblElementSerisi.Text = dt.Rows[3][2].ToString();
            lblPeriyot.Text = dt.Rows[3][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[3][4].ToString();
            lblAtomSembolu.Text = dt.Rows[3][5].ToString();
            lblGorunus.Text = dt.Rows[3][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[3][7].ToString();
            lblIzotop.Text = dt.Rows[3][8].ToString();
            lblProton.Text = dt.Rows[3][9].ToString();
            lblNotron.Text = dt.Rows[3][10].ToString();
            lblElektron.Text = dt.Rows[3][11].ToString();
            lblKatman.Text = dt.Rows[3][12].ToString();
            lblMaddeninHali.Text = dt.Rows[3][13].ToString(); 
        }

        private void btnBor_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "bor_elementi.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.BorE;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[4][1].ToString();
            lblElementSerisi.Text = dt.Rows[4][2].ToString();
            lblPeriyot.Text = dt.Rows[4][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[4][4].ToString();
            lblAtomSembolu.Text = dt.Rows[4][5].ToString();
            lblGorunus.Text = dt.Rows[4][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[4][7].ToString();
            lblIzotop.Text = dt.Rows[4][8].ToString();
            lblProton.Text = dt.Rows[4][9].ToString();
            lblNotron.Text = dt.Rows[4][10].ToString();
            lblElektron.Text = dt.Rows[4][11].ToString();
            lblKatman.Text = dt.Rows[4][12].ToString();
            lblMaddeninHali.Text = dt.Rows[4][13].ToString();
             
        }

        private void btnKarbon_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "C.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Celement;

            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[5][1].ToString();
            lblElementSerisi.Text = dt.Rows[5][2].ToString();
            lblPeriyot.Text = dt.Rows[5][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[5][4].ToString();
            lblAtomSembolu.Text = dt.Rows[5][5].ToString();
            lblGorunus.Text = dt.Rows[5][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[5][7].ToString();
            lblIzotop.Text = dt.Rows[5][8].ToString();
            lblProton.Text = dt.Rows[5][9].ToString();
            lblNotron.Text = dt.Rows[5][10].ToString();
            lblElektron.Text = dt.Rows[5][11].ToString();
            lblKatman.Text = dt.Rows[5][12].ToString();
            lblMaddeninHali.Text = dt.Rows[5][13].ToString();
             
        }

        private void btnAzot_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "AZOTTT.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Nelement; 
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[6][1].ToString();
            lblElementSerisi.Text = dt.Rows[6][2].ToString();
            lblPeriyot.Text = dt.Rows[6][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[6][4].ToString();
            lblAtomSembolu.Text = dt.Rows[6][5].ToString();
            lblGorunus.Text = dt.Rows[6][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[6][7].ToString();
            lblIzotop.Text = dt.Rows[6][8].ToString();
            lblProton.Text = dt.Rows[6][9].ToString();
            lblNotron.Text = dt.Rows[6][10].ToString();
            lblElektron.Text = dt.Rows[6][11].ToString();
            lblKatman.Text = dt.Rows[6][12].ToString();
            lblMaddeninHali.Text = dt.Rows[6][13].ToString();
        }

        private void btnOksijen_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "OKSIJENNN.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Oelement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[7][1].ToString();
            lblElementSerisi.Text = dt.Rows[7][2].ToString();
            lblPeriyot.Text = dt.Rows[7][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[7][4].ToString();
            lblAtomSembolu.Text = dt.Rows[7][5].ToString();
            lblGorunus.Text = dt.Rows[7][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[7][7].ToString();
            lblIzotop.Text = dt.Rows[7][8].ToString();
            lblProton.Text = dt.Rows[7][9].ToString();
            lblNotron.Text = dt.Rows[7][10].ToString();
            lblElektron.Text = dt.Rows[7][11].ToString();
            lblKatman.Text = dt.Rows[7][12].ToString();
            lblMaddeninHali.Text = dt.Rows[7][13].ToString();
        }

        private void btnFlor_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "flor.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Felement;

            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[8][1].ToString();
            lblElementSerisi.Text = dt.Rows[8][2].ToString();
            lblPeriyot.Text = dt.Rows[8][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[8][4].ToString();
            lblAtomSembolu.Text = dt.Rows[8][5].ToString();
            lblGorunus.Text = dt.Rows[8][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[9][7].ToString();
            lblIzotop.Text = dt.Rows[8][8].ToString();
            lblProton.Text = dt.Rows[8][9].ToString();
            lblNotron.Text = dt.Rows[8][10].ToString();
            lblElektron.Text = dt.Rows[8][11].ToString();
            lblKatman.Text = dt.Rows[8][12].ToString();
            lblMaddeninHali.Text = dt.Rows[8][13].ToString();
        }

        private void btnNeon_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ne.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Nelement;

            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[9][1].ToString();
            lblElementSerisi.Text = dt.Rows[9][2].ToString();
            lblPeriyot.Text = dt.Rows[9][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[9][4].ToString();
            lblAtomSembolu.Text = dt.Rows[9][5].ToString();
            lblGorunus.Text = dt.Rows[9][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[9][7].ToString();
            lblIzotop.Text = dt.Rows[9][8].ToString();
            lblProton.Text = dt.Rows[9][9].ToString();
            lblNotron.Text = dt.Rows[9][10].ToString();
            lblElektron.Text = dt.Rows[9][11].ToString();
            lblKatman.Text = dt.Rows[9][12].ToString();
            lblMaddeninHali.Text = dt.Rows[9][13].ToString();
        }

        private void btnSodyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Na.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.NaElement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[10][1].ToString();
            lblElementSerisi.Text = dt.Rows[10][2].ToString();
            lblPeriyot.Text = dt.Rows[10][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[10][4].ToString();
            lblAtomSembolu.Text = dt.Rows[10][5].ToString();
            lblGorunus.Text = dt.Rows[10][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[10][7].ToString();
            lblIzotop.Text = dt.Rows[10][8].ToString();
            lblProton.Text = dt.Rows[10][9].ToString();
            lblNotron.Text = dt.Rows[10][10].ToString();
            lblElektron.Text = dt.Rows[10][11].ToString();
            lblKatman.Text = dt.Rows[10][12].ToString();
            lblMaddeninHali.Text = dt.Rows[10][13].ToString();
        }

        private void btnMagnezyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Mg.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.MgElement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[11][1].ToString();
            lblElementSerisi.Text = dt.Rows[11][2].ToString();
            lblPeriyot.Text = dt.Rows[11][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[11][4].ToString();
            lblAtomSembolu.Text = dt.Rows[11][5].ToString();
            lblGorunus.Text = dt.Rows[11][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[11][7].ToString();
            lblIzotop.Text = dt.Rows[11][8].ToString();
            lblProton.Text = dt.Rows[11][9].ToString();
            lblNotron.Text = dt.Rows[11][10].ToString();
            lblElektron.Text = dt.Rows[11][11].ToString();
            lblKatman.Text = dt.Rows[11][12].ToString();
            lblMaddeninHali.Text = dt.Rows[11][13].ToString();
        }

        private void btnAliminyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Al.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Al; 
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[12][1].ToString();
            lblElementSerisi.Text = dt.Rows[12][2].ToString();
            lblPeriyot.Text = dt.Rows[12][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[12][4].ToString();
            lblAtomSembolu.Text = dt.Rows[12][5].ToString();
            lblGorunus.Text = dt.Rows[12][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[12][7].ToString();
            lblIzotop.Text = dt.Rows[12][8].ToString();
            lblProton.Text = dt.Rows[12][9].ToString();
            lblNotron.Text = dt.Rows[12][10].ToString();
            lblElektron.Text = dt.Rows[12][11].ToString();
            lblKatman.Text = dt.Rows[12][12].ToString();
            lblMaddeninHali.Text = dt.Rows[12][13].ToString();
           

        }

        private void btnSilisyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Si.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.SILISYUM;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[13][1].ToString();
            lblElementSerisi.Text = dt.Rows[13][2].ToString();
            lblPeriyot.Text = dt.Rows[13][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[13][4].ToString();
            lblAtomSembolu.Text = dt.Rows[13][5].ToString();
            lblGorunus.Text = dt.Rows[13][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[13][7].ToString();
            lblIzotop.Text = dt.Rows[13][8].ToString();
            lblProton.Text = dt.Rows[13][9].ToString();
            lblNotron.Text = dt.Rows[13][10].ToString();
            lblElektron.Text = dt.Rows[13][11].ToString();
            lblKatman.Text = dt.Rows[13][12].ToString();
            lblMaddeninHali.Text = dt.Rows[13][13].ToString();
        }

        private void btnFosfor_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "fosfor.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.FOSFORE;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[14][1].ToString();
            lblElementSerisi.Text = dt.Rows[14][2].ToString();
            lblPeriyot.Text = dt.Rows[14][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[14][4].ToString();
            lblAtomSembolu.Text = dt.Rows[14][5].ToString();
            lblGorunus.Text = dt.Rows[14][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[14][7].ToString();
            lblIzotop.Text = dt.Rows[14][8].ToString();
            lblProton.Text = dt.Rows[14][9].ToString();
            lblNotron.Text = dt.Rows[14][10].ToString();
            lblElektron.Text = dt.Rows[14][11].ToString();
            lblKatman.Text = dt.Rows[14][12].ToString();
            lblMaddeninHali.Text = dt.Rows[14][13].ToString();
        }

        private void btnKukurt_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "S.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Selement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[15][1].ToString();
            lblElementSerisi.Text = dt.Rows[15][2].ToString();
            lblPeriyot.Text = dt.Rows[15][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[15][4].ToString();
            lblAtomSembolu.Text = dt.Rows[15][5].ToString();
            lblGorunus.Text = dt.Rows[15][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[15][7].ToString();
            lblIzotop.Text = dt.Rows[15][8].ToString();
            lblProton.Text = dt.Rows[15][9].ToString();
            lblNotron.Text = dt.Rows[15][10].ToString();
            lblElektron.Text = dt.Rows[15][11].ToString();
            lblKatman.Text = dt.Rows[15][12].ToString();
            lblMaddeninHali.Text = dt.Rows[15][13].ToString();
        }

        private void btnClor_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "klor.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.CLelement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[16][1].ToString();
            lblElementSerisi.Text = dt.Rows[16][2].ToString();
            lblPeriyot.Text = dt.Rows[16][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[16][4].ToString();
            lblAtomSembolu.Text = dt.Rows[16][5].ToString();
            lblGorunus.Text = dt.Rows[16][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[16][7].ToString();
            lblIzotop.Text = dt.Rows[16][8].ToString();
            lblProton.Text = dt.Rows[16][9].ToString();
            lblNotron.Text = dt.Rows[16][10].ToString();
            lblElektron.Text = dt.Rows[16][11].ToString();
            lblKatman.Text = dt.Rows[16][12].ToString();
            lblMaddeninHali.Text = dt.Rows[16][13].ToString();

        }  
        private void btnArgon_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ar.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.ArE;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[17][1].ToString();
            lblElementSerisi.Text = dt.Rows[17][2].ToString();
            lblPeriyot.Text = dt.Rows[17][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[17][4].ToString();
            lblAtomSembolu.Text = dt.Rows[17][5].ToString();
            lblGorunus.Text = dt.Rows[17][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[17][7].ToString();
            lblIzotop.Text = dt.Rows[17][8].ToString();
            lblProton.Text = dt.Rows[17][9].ToString();
            lblNotron.Text = dt.Rows[17][10].ToString();
            lblElektron.Text = dt.Rows[17][11].ToString();
            lblKatman.Text = dt.Rows[17][12].ToString();
            lblMaddeninHali.Text = dt.Rows[17][13].ToString();
        }

        private void btnPotasyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "K.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Kelement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[18][1].ToString();
            lblElementSerisi.Text = dt.Rows[18][2].ToString();
            lblPeriyot.Text = dt.Rows[18][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[18][4].ToString();
            lblAtomSembolu.Text = dt.Rows[18][5].ToString();
            lblGorunus.Text = dt.Rows[18][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[18][7].ToString();
            lblIzotop.Text = dt.Rows[18][8].ToString();
            lblProton.Text = dt.Rows[18][9].ToString();
            lblNotron.Text = dt.Rows[18][10].ToString();
            lblElektron.Text = dt.Rows[18][11].ToString();
            lblKatman.Text = dt.Rows[18][12].ToString();
            lblMaddeninHali.Text = dt.Rows[18][13].ToString();
        }

        private void btnKalsiyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ca.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.CaElement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[19][1].ToString();
            lblElementSerisi.Text = dt.Rows[19][2].ToString();
            lblPeriyot.Text = dt.Rows[19][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[19][4].ToString();
            lblAtomSembolu.Text = dt.Rows[19][5].ToString();
            lblGorunus.Text = dt.Rows[19][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[19][7].ToString();
            lblIzotop.Text = dt.Rows[19][8].ToString();
            lblProton.Text = dt.Rows[19][9].ToString();
            lblNotron.Text = dt.Rows[19][10].ToString();
            lblElektron.Text = dt.Rows[19][11].ToString();
            lblKatman.Text = dt.Rows[19][12].ToString();
            lblMaddeninHali.Text = dt.Rows[19][13].ToString();
        }

        private void btnSkandiyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "sc.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.SKANDINYUM;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[20][1].ToString();
            lblElementSerisi.Text = dt.Rows[20][2].ToString();
            lblPeriyot.Text = dt.Rows[20][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[20][4].ToString();
            lblAtomSembolu.Text = dt.Rows[20][5].ToString();
            lblGorunus.Text = dt.Rows[20][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[20][7].ToString();
            lblIzotop.Text = dt.Rows[20][8].ToString();
            lblProton.Text = dt.Rows[20][9].ToString();
            lblNotron.Text = dt.Rows[20][10].ToString();
            lblElektron.Text = dt.Rows[20][11].ToString();
            lblKatman.Text = dt.Rows[20][12].ToString();
            lblMaddeninHali.Text = dt.Rows[20][13].ToString();
        }

        private void btnTitanyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "titanyum.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Titanyum;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[21][1].ToString();
            lblElementSerisi.Text = dt.Rows[21][2].ToString();
            lblPeriyot.Text = dt.Rows[21][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[21][4].ToString();
            lblAtomSembolu.Text = dt.Rows[21][5].ToString();
            lblGorunus.Text = dt.Rows[21][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[21][7].ToString();
            lblIzotop.Text = dt.Rows[21][8].ToString();
            lblProton.Text = dt.Rows[21][9].ToString();
            lblNotron.Text = dt.Rows[21][10].ToString();
            lblElektron.Text = dt.Rows[21][11].ToString();
            lblKatman.Text = dt.Rows[21][12].ToString();
            lblMaddeninHali.Text = dt.Rows[21][13].ToString();
        }

        private void btnVanadyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "vanadyum.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Vanadyumm;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[22][1].ToString();
            lblElementSerisi.Text = dt.Rows[22][2].ToString();
            lblPeriyot.Text = dt.Rows[22][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[22][4].ToString();
            lblAtomSembolu.Text = dt.Rows[22][5].ToString();
            lblGorunus.Text = dt.Rows[22][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[22][7].ToString();
            lblIzotop.Text = dt.Rows[22][8].ToString();
            lblProton.Text = dt.Rows[22][9].ToString();
            lblNotron.Text = dt.Rows[22][10].ToString();
            lblElektron.Text = dt.Rows[22][11].ToString();
            lblKatman.Text = dt.Rows[22][12].ToString();
            lblMaddeninHali.Text = dt.Rows[22][13].ToString();
        }

        private void btnKromE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "krom.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Kr;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[23][1].ToString();
            lblElementSerisi.Text = dt.Rows[23][2].ToString();
            lblPeriyot.Text = dt.Rows[23][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[23][4].ToString();
            lblAtomSembolu.Text = dt.Rows[23][5].ToString();
            lblGorunus.Text = dt.Rows[23][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[23][7].ToString();
            lblIzotop.Text = dt.Rows[23][8].ToString();
            lblProton.Text = dt.Rows[23][9].ToString();
            lblNotron.Text = dt.Rows[23][10].ToString();
            lblElektron.Text = dt.Rows[23][11].ToString();
            lblKatman.Text = dt.Rows[23][12].ToString();
            lblMaddeninHali.Text = dt.Rows[23][13].ToString();
        }

        private void btnMangenezE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "mn.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Mangenez;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[24][1].ToString();
            lblElementSerisi.Text = dt.Rows[24][2].ToString();
            lblPeriyot.Text = dt.Rows[24][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[24][4].ToString();
            lblAtomSembolu.Text = dt.Rows[24][5].ToString();
            lblGorunus.Text = dt.Rows[24][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[24][7].ToString();
            lblIzotop.Text = dt.Rows[24][8].ToString();
            lblProton.Text = dt.Rows[24][9].ToString();
            lblNotron.Text = dt.Rows[24][10].ToString();
            lblElektron.Text = dt.Rows[24][11].ToString();
            lblKatman.Text = dt.Rows[24][12].ToString();
            lblMaddeninHali.Text = dt.Rows[24][13].ToString(); 
        }

        private void btnDemirE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Fe.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.DEMIR;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[25][1].ToString();
            lblElementSerisi.Text = dt.Rows[25][2].ToString();
            lblPeriyot.Text = dt.Rows[25][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[25][4].ToString();
            lblAtomSembolu.Text = dt.Rows[25][5].ToString();
            lblGorunus.Text = dt.Rows[25][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[25][7].ToString();
            lblIzotop.Text = dt.Rows[25][8].ToString();
            lblProton.Text = dt.Rows[25][9].ToString();
            lblNotron.Text = dt.Rows[25][10].ToString();
            lblElektron.Text = dt.Rows[25][11].ToString();
            lblKatman.Text = dt.Rows[25][12].ToString();
            lblMaddeninHali.Text = dt.Rows[25][13].ToString();
        }

        private void btnKobaltE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Co.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Co;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[26][1].ToString();
            lblElementSerisi.Text = dt.Rows[26][2].ToString();
            lblPeriyot.Text = dt.Rows[26][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[26][4].ToString();
            lblAtomSembolu.Text = dt.Rows[26][5].ToString();
            lblGorunus.Text = dt.Rows[26][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[26][7].ToString();
            lblIzotop.Text = dt.Rows[26][8].ToString();
            lblProton.Text = dt.Rows[26][9].ToString();
            lblNotron.Text = dt.Rows[26][10].ToString();
            lblElektron.Text = dt.Rows[26][11].ToString();
            lblKatman.Text = dt.Rows[26][12].ToString();
            lblMaddeninHali.Text = dt.Rows[26][13].ToString();
        }

        private void btnNikelE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "nikel.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.NIKEL;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[27][1].ToString();
            lblElementSerisi.Text = dt.Rows[27][2].ToString();
            lblPeriyot.Text = dt.Rows[27][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[27][4].ToString();
            lblAtomSembolu.Text = dt.Rows[27][5].ToString();
            lblGorunus.Text = dt.Rows[27][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[27][7].ToString();
            lblIzotop.Text = dt.Rows[27][8].ToString();
            lblProton.Text = dt.Rows[27][9].ToString();
            lblNotron.Text = dt.Rows[27][10].ToString();
            lblElektron.Text = dt.Rows[27][11].ToString();
            lblKatman.Text = dt.Rows[27][12].ToString();
            lblMaddeninHali.Text = dt.Rows[27][13].ToString();
        }

        private void btnBakirE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Cu.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Cu;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[28][1].ToString();
            lblElementSerisi.Text = dt.Rows[28][2].ToString();
            lblPeriyot.Text = dt.Rows[28][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[28][4].ToString();
            lblAtomSembolu.Text = dt.Rows[28][5].ToString();
            lblGorunus.Text = dt.Rows[28][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[28][7].ToString();
            lblIzotop.Text = dt.Rows[28][8].ToString();
            lblProton.Text = dt.Rows[28][9].ToString();
            lblNotron.Text = dt.Rows[28][10].ToString();
            lblElektron.Text = dt.Rows[28][11].ToString();
            lblKatman.Text = dt.Rows[28][12].ToString();
            lblMaddeninHali.Text = dt.Rows[28][13].ToString();
        }

        private void btnCinkoE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "cinko.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Zn;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[29][1].ToString();
            lblElementSerisi.Text = dt.Rows[29][2].ToString();
            lblPeriyot.Text = dt.Rows[29][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[29][4].ToString();
            lblAtomSembolu.Text = dt.Rows[29][5].ToString();
            lblGorunus.Text = dt.Rows[29][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[29][7].ToString();
            lblIzotop.Text = dt.Rows[29][8].ToString();
            lblProton.Text = dt.Rows[29][9].ToString();
            lblNotron.Text = dt.Rows[29][10].ToString();
            lblElektron.Text = dt.Rows[29][11].ToString();
            lblKatman.Text = dt.Rows[29][12].ToString();
            lblMaddeninHali.Text = dt.Rows[29][13].ToString();
        }

        private void btnGalyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ga.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ga;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[30][1].ToString();
            lblElementSerisi.Text = dt.Rows[30][2].ToString();
            lblPeriyot.Text = dt.Rows[30][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[30][4].ToString();
            lblAtomSembolu.Text = dt.Rows[30][5].ToString();
            lblGorunus.Text = dt.Rows[30][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[30][7].ToString();
            lblIzotop.Text = dt.Rows[30][8].ToString();
            lblProton.Text = dt.Rows[30][9].ToString();
            lblNotron.Text = dt.Rows[30][10].ToString();
            lblElektron.Text = dt.Rows[30][11].ToString();
            lblKatman.Text = dt.Rows[30][12].ToString();
            lblMaddeninHali.Text = dt.Rows[30][13].ToString();
        }

        private void btnGeryumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ge.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ger;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[31][1].ToString();
            lblElementSerisi.Text = dt.Rows[31][2].ToString();
            lblPeriyot.Text = dt.Rows[31][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[31][4].ToString();
            lblAtomSembolu.Text = dt.Rows[31][5].ToString();
            lblGorunus.Text = dt.Rows[31][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[31][7].ToString();
            lblIzotop.Text = dt.Rows[31][8].ToString();
            lblProton.Text = dt.Rows[31][9].ToString();
            lblNotron.Text = dt.Rows[31][10].ToString();
            lblElektron.Text = dt.Rows[31][11].ToString();
            lblKatman.Text = dt.Rows[31][12].ToString();
            lblMaddeninHali.Text = dt.Rows[31][13].ToString();
        }

        private void btnArsenikE_Click(object sender, EventArgs e)
        { 
            Pasiflik(); 
            pboxResim.ImageLocation = "As.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.As;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[32][1].ToString();
            lblElementSerisi.Text = dt.Rows[32][2].ToString();
            lblPeriyot.Text = dt.Rows[32][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[32][4].ToString();
            lblAtomSembolu.Text = dt.Rows[32][5].ToString();
            lblGorunus.Text = dt.Rows[32][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[32][7].ToString();
            lblIzotop.Text = dt.Rows[32][8].ToString();
            lblProton.Text = dt.Rows[32][9].ToString();
            lblNotron.Text = dt.Rows[32][10].ToString();
            lblElektron.Text = dt.Rows[32][11].ToString();
            lblKatman.Text = dt.Rows[32][12].ToString();
            lblMaddeninHali.Text = dt.Rows[32][13].ToString();
        }

        private void btnSelenyumE_Click(object sender, EventArgs e)
        {
            Pasiflik();  
            pboxResim.ImageLocation = "Se.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Se;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[33][1].ToString();
            lblElementSerisi.Text = dt.Rows[33][2].ToString();
            lblPeriyot.Text = dt.Rows[33][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[33][4].ToString();
            lblAtomSembolu.Text = dt.Rows[33][5].ToString();
            lblGorunus.Text = dt.Rows[33][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[33][7].ToString();
            lblIzotop.Text = dt.Rows[33][8].ToString();
            lblProton.Text = dt.Rows[33][9].ToString();
            lblNotron.Text = dt.Rows[33][10].ToString();
            lblElektron.Text = dt.Rows[33][11].ToString();
            lblKatman.Text = dt.Rows[33][12].ToString();
            lblMaddeninHali.Text = dt.Rows[33][13].ToString(); 
        }

        private void btnBromE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "brom.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.BrE;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[34][1].ToString();
            lblElementSerisi.Text = dt.Rows[34][2].ToString();
            lblPeriyot.Text = dt.Rows[34][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[34][4].ToString();
            lblAtomSembolu.Text = dt.Rows[34][5].ToString();
            lblGorunus.Text = dt.Rows[34][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[34][7].ToString();
            lblIzotop.Text = dt.Rows[34][8].ToString();
            lblProton.Text = dt.Rows[34][9].ToString();
            lblNotron.Text = dt.Rows[34][10].ToString();
            lblElektron.Text = dt.Rows[34][11].ToString();
            lblKatman.Text = dt.Rows[34][12].ToString();
            lblMaddeninHali.Text = dt.Rows[34][13].ToString();
        }

        private void btnKriptonE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Kr.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Kr;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[35][1].ToString();
            lblElementSerisi.Text = dt.Rows[35][2].ToString();
            lblPeriyot.Text = dt.Rows[35][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[35][4].ToString();
            lblAtomSembolu.Text = dt.Rows[35][5].ToString();
            lblGorunus.Text = dt.Rows[35][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[35][7].ToString();
            lblIzotop.Text = dt.Rows[35][8].ToString();
            lblProton.Text = dt.Rows[35][9].ToString();
            lblNotron.Text = dt.Rows[35][10].ToString();
            lblElektron.Text = dt.Rows[35][11].ToString();
            lblKatman.Text = dt.Rows[35][12].ToString();
            lblMaddeninHali.Text = dt.Rows[35][13].ToString();
        }

        private void btnRubidyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Rb.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Rb;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[36][1].ToString();
            lblElementSerisi.Text = dt.Rows[36][2].ToString();
            lblPeriyot.Text = dt.Rows[36][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[36][4].ToString();
            lblAtomSembolu.Text = dt.Rows[36][5].ToString();
            lblGorunus.Text = dt.Rows[36][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[36][7].ToString();
            lblIzotop.Text = dt.Rows[36][8].ToString();
            lblProton.Text = dt.Rows[36][9].ToString();
            lblNotron.Text = dt.Rows[36][10].ToString();
            lblElektron.Text = dt.Rows[36][11].ToString();
            lblKatman.Text = dt.Rows[36][12].ToString();
            lblMaddeninHali.Text = dt.Rows[36][13].ToString();
        }

        private void btnStronisyumE_Click(object sender, EventArgs e)
        { 
            Pasiflik(); 
            pboxResim.ImageLocation = "Sr.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Sr;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[37][1].ToString();
            lblElementSerisi.Text = dt.Rows[37][2].ToString();
            lblPeriyot.Text = dt.Rows[37][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[37][4].ToString();
            lblAtomSembolu.Text = dt.Rows[37][5].ToString();
            lblGorunus.Text = dt.Rows[37][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[37][7].ToString();
            lblIzotop.Text = dt.Rows[37][8].ToString();
            lblProton.Text = dt.Rows[37][9].ToString();
            lblNotron.Text = dt.Rows[37][10].ToString();
            lblElektron.Text = dt.Rows[37][11].ToString();
            lblKatman.Text = dt.Rows[37][12].ToString();
            lblMaddeninHali.Text = dt.Rows[37][13].ToString();
        }

        private void btnItriyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Itriyum.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Y;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[38][1].ToString();
            lblElementSerisi.Text = dt.Rows[38][2].ToString();
            lblPeriyot.Text = dt.Rows[38][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[38][4].ToString();
            lblAtomSembolu.Text = dt.Rows[38][5].ToString();
            lblGorunus.Text = dt.Rows[38][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[38][7].ToString();
            lblIzotop.Text = dt.Rows[38][8].ToString();
            lblProton.Text = dt.Rows[38][9].ToString();
            lblNotron.Text = dt.Rows[38][10].ToString();
            lblElektron.Text = dt.Rows[38][11].ToString();
            lblKatman.Text = dt.Rows[38][12].ToString();
            lblMaddeninHali.Text = dt.Rows[38][13].ToString();
        }

        private void btnZirkanyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Zr.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Zr;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[39][1].ToString();
            lblElementSerisi.Text = dt.Rows[39][2].ToString();
            lblPeriyot.Text = dt.Rows[39][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[39][4].ToString();
            lblAtomSembolu.Text = dt.Rows[39][5].ToString();
            lblGorunus.Text = dt.Rows[39][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[39][7].ToString();
            lblIzotop.Text = dt.Rows[39][8].ToString();
            lblProton.Text = dt.Rows[39][9].ToString();
            lblNotron.Text = dt.Rows[39][10].ToString();
            lblElektron.Text = dt.Rows[39][11].ToString();
            lblKatman.Text = dt.Rows[39][12].ToString();
            lblMaddeninHali.Text = dt.Rows[39][13].ToString();
        }

        private void btnNiyabyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Nb.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Nb;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[40][1].ToString();
            lblElementSerisi.Text = dt.Rows[40][2].ToString();
            lblPeriyot.Text = dt.Rows[40][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[40][4].ToString();
            lblAtomSembolu.Text = dt.Rows[40][5].ToString();
            lblGorunus.Text = dt.Rows[40][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[40][7].ToString();
            lblIzotop.Text = dt.Rows[40][8].ToString();
            lblProton.Text = dt.Rows[40][9].ToString();
            lblNotron.Text = dt.Rows[40][10].ToString();
            lblElektron.Text = dt.Rows[40][11].ToString();
            lblKatman.Text = dt.Rows[40][12].ToString();
            lblMaddeninHali.Text = dt.Rows[40][13].ToString();
        }

        private void btnMolindenE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Mo.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.MoElement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[41][1].ToString();
            lblElementSerisi.Text = dt.Rows[41][2].ToString();
            lblPeriyot.Text = dt.Rows[41][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[41][4].ToString();
            lblAtomSembolu.Text = dt.Rows[41][5].ToString();
            lblGorunus.Text = dt.Rows[41][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[41][7].ToString();
            lblIzotop.Text = dt.Rows[41][8].ToString();
            lblProton.Text = dt.Rows[41][9].ToString();
            lblNotron.Text = dt.Rows[41][10].ToString();
            lblElektron.Text = dt.Rows[41][11].ToString();
            lblKatman.Text = dt.Rows[41][12].ToString();
            lblMaddeninHali.Text = dt.Rows[41][13].ToString();
        }

        private void btnTeknesyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Tc.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Tc;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[42][1].ToString();
            lblElementSerisi.Text = dt.Rows[42][2].ToString();
            lblPeriyot.Text = dt.Rows[42][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[42][4].ToString();
            lblAtomSembolu.Text = dt.Rows[42][5].ToString();
            lblGorunus.Text = dt.Rows[42][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[42][7].ToString();
            lblIzotop.Text = dt.Rows[42][8].ToString();
            lblProton.Text = dt.Rows[42][9].ToString();
            lblNotron.Text = dt.Rows[42][10].ToString();
            lblElektron.Text = dt.Rows[42][11].ToString();
            lblKatman.Text = dt.Rows[42][12].ToString();
            lblMaddeninHali.Text = dt.Rows[42][13].ToString();
        }

        private void btnRutentumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ru.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ru;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[43][1].ToString();
            lblElementSerisi.Text = dt.Rows[43][2].ToString();
            lblPeriyot.Text = dt.Rows[43][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[43][4].ToString();
            lblAtomSembolu.Text = dt.Rows[43][5].ToString();
            lblGorunus.Text = dt.Rows[43][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[43][7].ToString();
            lblIzotop.Text = dt.Rows[43][8].ToString();
            lblProton.Text = dt.Rows[43][9].ToString();
            lblNotron.Text = dt.Rows[43][10].ToString();
            lblElektron.Text = dt.Rows[43][11].ToString();
            lblKatman.Text = dt.Rows[43][12].ToString();
            lblMaddeninHali.Text = dt.Rows[43][13].ToString();
        }

        private void btnRodyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Rh.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Rh;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[44][1].ToString();
            lblElementSerisi.Text = dt.Rows[44][2].ToString();
            lblPeriyot.Text = dt.Rows[44][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[44][4].ToString();
            lblAtomSembolu.Text = dt.Rows[44][5].ToString();
            lblGorunus.Text = dt.Rows[44][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[44][7].ToString();
            lblIzotop.Text = dt.Rows[44][8].ToString();
            lblProton.Text = dt.Rows[44][9].ToString();
            lblNotron.Text = dt.Rows[44][10].ToString();
            lblElektron.Text = dt.Rows[44][11].ToString();
            lblKatman.Text = dt.Rows[44][12].ToString();
            lblMaddeninHali.Text = dt.Rows[44][13].ToString();
        }

        private void btnPalladyumE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Pd.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Pd;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[45][1].ToString();
            lblElementSerisi.Text = dt.Rows[45][2].ToString();
            lblPeriyot.Text = dt.Rows[45][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[45][4].ToString();
            lblAtomSembolu.Text = dt.Rows[45][5].ToString();
            lblGorunus.Text = dt.Rows[45][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[45][7].ToString();
            lblIzotop.Text = dt.Rows[45][8].ToString();
            lblProton.Text = dt.Rows[45][9].ToString();
            lblNotron.Text = dt.Rows[45][10].ToString();
            lblElektron.Text = dt.Rows[45][11].ToString();
            lblKatman.Text = dt.Rows[45][12].ToString();
            lblMaddeninHali.Text = dt.Rows[45][13].ToString(); 
        }

        private void btnGumusE_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ag.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Sm;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[46][1].ToString();
            lblElementSerisi.Text = dt.Rows[46][2].ToString();
            lblPeriyot.Text = dt.Rows[46][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[46][4].ToString();
            lblAtomSembolu.Text = dt.Rows[46][5].ToString();
            lblGorunus.Text = dt.Rows[46][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[46][7].ToString();
            lblIzotop.Text = dt.Rows[46][8].ToString();
            lblProton.Text = dt.Rows[46][9].ToString();
            lblNotron.Text = dt.Rows[46][10].ToString();
            lblElektron.Text = dt.Rows[46][11].ToString();
            lblKatman.Text = dt.Rows[46][12].ToString();
            lblMaddeninHali.Text = dt.Rows[46][13].ToString();
        }

        private void btnKadmiyumE_Click(object sender, EventArgs e)
        {
            Pasiflik();
            btnIzotop.BackgroundImage = Properties.Resources.Cd; 
            pboxResim.ImageLocation = "Cd.jpg";
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[47][1].ToString();
            lblElementSerisi.Text = dt.Rows[47][2].ToString();
            lblPeriyot.Text = dt.Rows[47][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[47][4].ToString();
            lblAtomSembolu.Text = dt.Rows[47][5].ToString();
            lblGorunus.Text = dt.Rows[47][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[47][7].ToString();
            lblIzotop.Text = dt.Rows[47][8].ToString();
            lblProton.Text = dt.Rows[47][9].ToString();
            lblNotron.Text = dt.Rows[47][10].ToString();
            lblElektron.Text = dt.Rows[47][11].ToString();
            lblKatman.Text = dt.Rows[47][12].ToString();
            lblMaddeninHali.Text = dt.Rows[47][13].ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "In.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.In;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[48][1].ToString();
            lblElementSerisi.Text = dt.Rows[48][2].ToString();
            lblPeriyot.Text = dt.Rows[48][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[48][4].ToString();
            lblAtomSembolu.Text = dt.Rows[48][5].ToString();
            lblGorunus.Text = dt.Rows[48][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[48][7].ToString();
            lblIzotop.Text = dt.Rows[48][8].ToString();
            lblProton.Text = dt.Rows[48][9].ToString();
            lblNotron.Text = dt.Rows[48][10].ToString();
            lblElektron.Text = dt.Rows[48][11].ToString();
            lblKatman.Text = dt.Rows[48][12].ToString();
            lblMaddeninHali.Text = dt.Rows[48][13].ToString();
        }

        private void btnKalay_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Sn.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.SnElement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[49][1].ToString();
            lblElementSerisi.Text = dt.Rows[49][2].ToString();
            lblPeriyot.Text = dt.Rows[49][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[49][4].ToString();
            lblAtomSembolu.Text = dt.Rows[49][5].ToString();
            lblGorunus.Text = dt.Rows[49][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[49][7].ToString();
            lblIzotop.Text = dt.Rows[49][8].ToString();
            lblProton.Text = dt.Rows[49][9].ToString();
            lblNotron.Text = dt.Rows[49][10].ToString();
            lblElektron.Text = dt.Rows[49][11].ToString();
            lblKatman.Text = dt.Rows[49][12].ToString();
            lblMaddeninHali.Text = dt.Rows[49][13].ToString();
        }

        private void btnAntimon_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Sb.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.SbElement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[50][1].ToString();
            lblElementSerisi.Text = dt.Rows[50][2].ToString();
            lblPeriyot.Text = dt.Rows[50][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[50][4].ToString();
            lblAtomSembolu.Text = dt.Rows[50][5].ToString();
            lblGorunus.Text = dt.Rows[50][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[50][7].ToString();
            lblIzotop.Text = dt.Rows[50][8].ToString();
            lblProton.Text = dt.Rows[50][9].ToString();
            lblNotron.Text = dt.Rows[50][10].ToString();
            lblElektron.Text = dt.Rows[50][11].ToString();
            lblKatman.Text = dt.Rows[50][12].ToString();
            lblMaddeninHali.Text = dt.Rows[50][13].ToString();
        }

        private void btnTellur_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Tellur.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.TeElement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[51][1].ToString();
            lblElementSerisi.Text = dt.Rows[51][2].ToString();
            lblPeriyot.Text = dt.Rows[51][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[51][4].ToString();
            lblAtomSembolu.Text = dt.Rows[51][5].ToString();
            lblGorunus.Text = dt.Rows[51][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[51][7].ToString();
            lblIzotop.Text = dt.Rows[51][8].ToString();
            lblProton.Text = dt.Rows[51][9].ToString();
            lblNotron.Text = dt.Rows[51][10].ToString();
            lblElektron.Text = dt.Rows[51][11].ToString();
            lblKatman.Text = dt.Rows[51][12].ToString();
            lblMaddeninHali.Text = dt.Rows[51][13].ToString();
        }

        private void btnIyot_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "IYOT.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.I;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[52][1].ToString();
            lblElementSerisi.Text = dt.Rows[52][2].ToString();
            lblPeriyot.Text = dt.Rows[52][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[52][4].ToString();
            lblAtomSembolu.Text = dt.Rows[52][5].ToString();
            lblGorunus.Text = dt.Rows[52][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[52][7].ToString();
            lblIzotop.Text = dt.Rows[52][8].ToString();
            lblProton.Text = dt.Rows[52][9].ToString();
            lblNotron.Text = dt.Rows[52][10].ToString();
            lblElektron.Text = dt.Rows[52][11].ToString();
            lblKatman.Text = dt.Rows[52][12].ToString();
            lblMaddeninHali.Text = dt.Rows[52][13].ToString();
        }

        private void btnXenon_Click(object sender, EventArgs e)
        {
            Pasiflik();  
            pboxResim.ImageLocation = "Xe.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Xe;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[53][1].ToString();
            lblElementSerisi.Text = dt.Rows[53][2].ToString();
            lblPeriyot.Text = dt.Rows[53][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[53][4].ToString();
            lblAtomSembolu.Text = dt.Rows[53][5].ToString();
            lblGorunus.Text = dt.Rows[53][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[53][7].ToString();
            lblIzotop.Text = dt.Rows[53][8].ToString();
            lblProton.Text = dt.Rows[53][9].ToString();
            lblNotron.Text = dt.Rows[53][10].ToString();
            lblElektron.Text = dt.Rows[53][11].ToString();
            lblKatman.Text = dt.Rows[53][12].ToString();
            lblMaddeninHali.Text = dt.Rows[53][13].ToString();
        }

        private void btnSezyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Cs.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Cs;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[54][1].ToString();
            lblElementSerisi.Text = dt.Rows[54][2].ToString();
            lblPeriyot.Text = dt.Rows[54][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[54][4].ToString();
            lblAtomSembolu.Text = dt.Rows[54][5].ToString();
            lblGorunus.Text = dt.Rows[54][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[54][7].ToString();
            lblIzotop.Text = dt.Rows[54][8].ToString();
            lblProton.Text = dt.Rows[54][9].ToString();
            lblNotron.Text = dt.Rows[54][10].ToString();
            lblElektron.Text = dt.Rows[54][11].ToString();
            lblKatman.Text = dt.Rows[54][12].ToString();
            lblMaddeninHali.Text = dt.Rows[54][13].ToString();
        } 

        private void btnBaryum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ba.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ba;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[55][1].ToString();
            lblElementSerisi.Text = dt.Rows[55][2].ToString();
            lblPeriyot.Text = dt.Rows[55][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[55][4].ToString();
            lblAtomSembolu.Text = dt.Rows[55][5].ToString();
            lblGorunus.Text = dt.Rows[55][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[55][7].ToString();
            lblIzotop.Text = dt.Rows[55][8].ToString();
            lblProton.Text = dt.Rows[55][9].ToString();
            lblNotron.Text = dt.Rows[55][10].ToString();
            lblElektron.Text = dt.Rows[55][11].ToString();
            lblKatman.Text = dt.Rows[55][12].ToString();
            lblMaddeninHali.Text = dt.Rows[55][13].ToString();
        }

        private void btnLantanin_Click(object sender, EventArgs e)
        {
            btnLantanin.Focus();
        }

        private void btnLantan_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Lantan.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.La;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[56][1].ToString();
            lblElementSerisi.Text = dt.Rows[56][2].ToString();
            lblPeriyot.Text = dt.Rows[56][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[56][4].ToString();
            lblAtomSembolu.Text = dt.Rows[56][5].ToString();
            lblGorunus.Text = dt.Rows[56][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[56][7].ToString();
            lblIzotop.Text = dt.Rows[56][8].ToString();
            lblProton.Text = dt.Rows[56][9].ToString();
            lblNotron.Text = dt.Rows[56][10].ToString();
            lblElektron.Text = dt.Rows[56][11].ToString();
            lblKatman.Text = dt.Rows[56][12].ToString();
            lblMaddeninHali.Text = dt.Rows[56][13].ToString();
        }

        private void btnSeryum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ce.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ce;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[57][1].ToString();
            lblElementSerisi.Text = dt.Rows[57][2].ToString();
            lblPeriyot.Text = dt.Rows[57][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[57][4].ToString();
            lblAtomSembolu.Text = dt.Rows[57][5].ToString();
            lblGorunus.Text = dt.Rows[57][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[57][7].ToString();
            lblIzotop.Text = dt.Rows[57][8].ToString();
            lblProton.Text = dt.Rows[57][9].ToString();
            lblNotron.Text = dt.Rows[57][10].ToString();
            lblElektron.Text = dt.Rows[57][11].ToString();
            lblKatman.Text = dt.Rows[57][12].ToString();
            lblMaddeninHali.Text = dt.Rows[57][13].ToString();
        }

        private void btnPresoidim_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "SEODIM.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.R;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[58][1].ToString();
            lblElementSerisi.Text = dt.Rows[58][2].ToString();
            lblPeriyot.Text = dt.Rows[58][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[58][4].ToString();
            lblAtomSembolu.Text = dt.Rows[58][5].ToString();
            lblGorunus.Text = dt.Rows[58][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[58][7].ToString();
            lblIzotop.Text = dt.Rows[58][8].ToString();
            lblProton.Text = dt.Rows[58][9].ToString();
            lblNotron.Text = dt.Rows[58][10].ToString();
            lblElektron.Text = dt.Rows[58][11].ToString();
            lblKatman.Text = dt.Rows[58][12].ToString();
            lblMaddeninHali.Text = dt.Rows[58][13].ToString();
        }

        private void btnNeoidim_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "NEOIDIM.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Nd;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[59][1].ToString();
            lblElementSerisi.Text = dt.Rows[59][2].ToString();
            lblPeriyot.Text = dt.Rows[59][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[59][4].ToString();
            lblAtomSembolu.Text = dt.Rows[59][5].ToString();
            lblGorunus.Text = dt.Rows[59][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[59][7].ToString();
            lblIzotop.Text = dt.Rows[59][8].ToString();
            lblProton.Text = dt.Rows[59][9].ToString();
            lblNotron.Text = dt.Rows[59][10].ToString();
            lblElektron.Text = dt.Rows[59][11].ToString();
            lblKatman.Text = dt.Rows[59][12].ToString();
            lblMaddeninHali.Text = dt.Rows[59][13].ToString();
        }

        private void btnPrometyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Prometyum.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.M;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[60][1].ToString();
            lblElementSerisi.Text = dt.Rows[60][2].ToString();
            lblPeriyot.Text = dt.Rows[60][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[60][4].ToString();
            lblAtomSembolu.Text = dt.Rows[60][5].ToString();
            lblGorunus.Text = dt.Rows[60][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[60][7].ToString();
            lblIzotop.Text = dt.Rows[60][8].ToString();
            lblProton.Text = dt.Rows[60][9].ToString();
            lblNotron.Text = dt.Rows[60][10].ToString();
            lblElektron.Text = dt.Rows[60][11].ToString();
            lblKatman.Text = dt.Rows[60][12].ToString();
            lblMaddeninHali.Text = dt.Rows[60][13].ToString();
        }

        private void btnSamaryum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Sm.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Sm;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[61][1].ToString();
            lblElementSerisi.Text = dt.Rows[61][2].ToString();
            lblPeriyot.Text = dt.Rows[61][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[61][4].ToString();
            lblAtomSembolu.Text = dt.Rows[61][5].ToString();
            lblGorunus.Text = dt.Rows[61][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[61][7].ToString();
            lblIzotop.Text = dt.Rows[61][8].ToString();
            lblProton.Text = dt.Rows[61][9].ToString();
            lblNotron.Text = dt.Rows[61][10].ToString();
            lblElektron.Text = dt.Rows[61][11].ToString();
            lblKatman.Text = dt.Rows[61][12].ToString();
            lblMaddeninHali.Text = dt.Rows[61][13].ToString();
        }

        private void btnEvropyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Eu.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Eur;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[62][1].ToString();
            lblElementSerisi.Text = dt.Rows[62][2].ToString();
            lblPeriyot.Text = dt.Rows[62][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[62][4].ToString();
            lblAtomSembolu.Text = dt.Rows[62][5].ToString();
            lblGorunus.Text = dt.Rows[62][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[62][7].ToString();
            lblIzotop.Text = dt.Rows[62][8].ToString();
            lblProton.Text = dt.Rows[62][9].ToString();
            lblNotron.Text = dt.Rows[62][10].ToString();
            lblElektron.Text = dt.Rows[62][11].ToString();
            lblKatman.Text = dt.Rows[62][12].ToString();
            lblMaddeninHali.Text = dt.Rows[62][13].ToString();
        }

        private void btnGadolinyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Gd.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.GD;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[63][1].ToString();
            lblElementSerisi.Text = dt.Rows[63][2].ToString();
            lblPeriyot.Text = dt.Rows[63][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[63][4].ToString();
            lblAtomSembolu.Text = dt.Rows[63][5].ToString();
            lblGorunus.Text = dt.Rows[63][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[63][7].ToString();
            lblIzotop.Text = dt.Rows[63][8].ToString();
            lblProton.Text = dt.Rows[63][9].ToString();
            lblNotron.Text = dt.Rows[63][10].ToString();
            lblElektron.Text = dt.Rows[63][11].ToString();
            lblKatman.Text = dt.Rows[63][12].ToString();
            lblMaddeninHali.Text = dt.Rows[63][13].ToString();
        }

        private void btnTerbinyum_Click(object sender, EventArgs e)
        {
            Pasiflik();  
            pboxResim.ImageLocation = "Tb.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Tb;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[64][1].ToString();
            lblElementSerisi.Text = dt.Rows[64][2].ToString();
            lblPeriyot.Text = dt.Rows[64][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[64][4].ToString();
            lblAtomSembolu.Text = dt.Rows[64][5].ToString();
            lblGorunus.Text = dt.Rows[64][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[64][7].ToString();
            lblIzotop.Text = dt.Rows[64][8].ToString();
            lblProton.Text = dt.Rows[64][9].ToString();
            lblNotron.Text = dt.Rows[64][10].ToString();
            lblElektron.Text = dt.Rows[64][11].ToString();
            lblKatman.Text = dt.Rows[64][12].ToString();
            lblMaddeninHali.Text = dt.Rows[64][13].ToString();
        }

        private void btnDisprosunyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Dy.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Dy;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[65][1].ToString();
            lblElementSerisi.Text = dt.Rows[65][2].ToString();
            lblPeriyot.Text = dt.Rows[65][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[65][4].ToString();
            lblAtomSembolu.Text = dt.Rows[65][5].ToString();
            lblGorunus.Text = dt.Rows[65][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[65][7].ToString();
            lblIzotop.Text = dt.Rows[65][8].ToString();
            lblProton.Text = dt.Rows[65][9].ToString();
            lblNotron.Text = dt.Rows[65][10].ToString();
            lblElektron.Text = dt.Rows[65][11].ToString();
            lblKatman.Text = dt.Rows[65][12].ToString();
            lblMaddeninHali.Text = dt.Rows[65][13].ToString();
        }

        private void btnHolmiyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ho.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ho;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[66][1].ToString();
            lblElementSerisi.Text = dt.Rows[66][2].ToString();
            lblPeriyot.Text = dt.Rows[66][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[66][4].ToString();
            lblAtomSembolu.Text = dt.Rows[66][5].ToString();
            lblGorunus.Text = dt.Rows[66][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[66][7].ToString();
            lblIzotop.Text = dt.Rows[66][8].ToString();
            lblProton.Text = dt.Rows[66][9].ToString();
            lblNotron.Text = dt.Rows[66][10].ToString();
            lblElektron.Text = dt.Rows[66][11].ToString();
            lblKatman.Text = dt.Rows[66][12].ToString();
            lblMaddeninHali.Text = dt.Rows[66][13].ToString();
        }

        private void btnErbiyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Er.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Er;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[67][1].ToString();
            lblElementSerisi.Text = dt.Rows[67][2].ToString();
            lblPeriyot.Text = dt.Rows[67][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[67][4].ToString();
            lblAtomSembolu.Text = dt.Rows[67][5].ToString();
            lblGorunus.Text = dt.Rows[67][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[67][7].ToString();
            lblIzotop.Text = dt.Rows[67][8].ToString();
            lblProton.Text = dt.Rows[67][9].ToString();
            lblNotron.Text = dt.Rows[67][10].ToString();
            lblElektron.Text = dt.Rows[67][11].ToString();
            lblKatman.Text = dt.Rows[67][12].ToString();
            lblMaddeninHali.Text = dt.Rows[67][13].ToString();
        }

        private void btnTulyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Tm.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Tm;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[68][1].ToString();
            lblElementSerisi.Text = dt.Rows[68][2].ToString();
            lblPeriyot.Text = dt.Rows[68][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[68][4].ToString();
            lblAtomSembolu.Text = dt.Rows[68][5].ToString();
            lblGorunus.Text = dt.Rows[68][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[68][7].ToString();
            lblIzotop.Text = dt.Rows[68][8].ToString();
            lblProton.Text = dt.Rows[68][9].ToString();
            lblNotron.Text = dt.Rows[68][10].ToString();
            lblElektron.Text = dt.Rows[68][11].ToString();
            lblKatman.Text = dt.Rows[68][12].ToString();
            lblMaddeninHali.Text = dt.Rows[68][13].ToString();
        }

        private void btnIterbiryum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Yb.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Yb;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[69][1].ToString();
            lblElementSerisi.Text = dt.Rows[69][2].ToString();
            lblPeriyot.Text = dt.Rows[69][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[69][4].ToString();
            lblAtomSembolu.Text = dt.Rows[69][5].ToString();
            lblGorunus.Text = dt.Rows[69][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[69][7].ToString();
            lblIzotop.Text = dt.Rows[69][8].ToString();
            lblProton.Text = dt.Rows[69][9].ToString();
            lblNotron.Text = dt.Rows[69][10].ToString();
            lblElektron.Text = dt.Rows[69][11].ToString();
            lblKatman.Text = dt.Rows[69][12].ToString();
            lblMaddeninHali.Text = dt.Rows[69][13].ToString(); 
        }

        private void btnLutesyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Lu.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Lu;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[70][1].ToString();
            lblElementSerisi.Text = dt.Rows[70][2].ToString();
            lblPeriyot.Text = dt.Rows[70][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[70][4].ToString();
            lblAtomSembolu.Text = dt.Rows[70][5].ToString();
            lblGorunus.Text = dt.Rows[70][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[70][7].ToString();
            lblIzotop.Text = dt.Rows[70][8].ToString();
            lblProton.Text = dt.Rows[70][9].ToString();
            lblNotron.Text = dt.Rows[70][10].ToString();
            lblElektron.Text = dt.Rows[70][11].ToString();
            lblKatman.Text = dt.Rows[70][12].ToString();
            lblMaddeninHali.Text = dt.Rows[70][13].ToString(); 
        }

        private void btnHafniyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Hf.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Hf;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[71][1].ToString();
            lblElementSerisi.Text = dt.Rows[71][2].ToString();
            lblPeriyot.Text = dt.Rows[71][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[71][4].ToString();
            lblAtomSembolu.Text = dt.Rows[71][5].ToString();
            lblGorunus.Text = dt.Rows[71][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[71][7].ToString();
            lblIzotop.Text = dt.Rows[71][8].ToString();
            lblProton.Text = dt.Rows[71][9].ToString();
            lblNotron.Text = dt.Rows[71][10].ToString();
            lblElektron.Text = dt.Rows[71][11].ToString();
            lblKatman.Text = dt.Rows[71][12].ToString();
            lblMaddeninHali.Text = dt.Rows[71][13].ToString(); 
        }

        private void btnTantal_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Tantal.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ta;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[72][1].ToString();
            lblElementSerisi.Text = dt.Rows[72][2].ToString();
            lblPeriyot.Text = dt.Rows[72][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[72][4].ToString();
            lblAtomSembolu.Text = dt.Rows[72][5].ToString();
            lblGorunus.Text = dt.Rows[72][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[72][7].ToString();
            lblIzotop.Text = dt.Rows[72][8].ToString();
            lblProton.Text = dt.Rows[72][9].ToString();
            lblNotron.Text = dt.Rows[72][10].ToString();
            lblElektron.Text = dt.Rows[72][11].ToString();
            lblKatman.Text = dt.Rows[72][12].ToString();
            lblMaddeninHali.Text = dt.Rows[72][13].ToString();
        }

        private void btnTungston_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "W.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.W;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[73][1].ToString();
            lblElementSerisi.Text = dt.Rows[73][2].ToString();
            lblPeriyot.Text = dt.Rows[73][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[73][4].ToString();
            lblAtomSembolu.Text = dt.Rows[73][5].ToString();
            lblGorunus.Text = dt.Rows[73][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[73][7].ToString();
            lblIzotop.Text = dt.Rows[73][8].ToString();
            lblProton.Text = dt.Rows[73][9].ToString();
            lblNotron.Text = dt.Rows[73][10].ToString();
            lblElektron.Text = dt.Rows[73][11].ToString();
            lblKatman.Text = dt.Rows[73][12].ToString();
            lblMaddeninHali.Text = dt.Rows[73][13].ToString(); 
        }

        private void btnRenyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Renyumm.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Re;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[74][1].ToString();
            lblElementSerisi.Text = dt.Rows[74][2].ToString();
            lblPeriyot.Text = dt.Rows[74][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[74][4].ToString();
            lblAtomSembolu.Text = dt.Rows[74][5].ToString();
            lblGorunus.Text = dt.Rows[74][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[74][7].ToString();
            lblIzotop.Text = dt.Rows[74][8].ToString();
            lblProton.Text = dt.Rows[74][9].ToString();
            lblNotron.Text = dt.Rows[74][10].ToString();
            lblElektron.Text = dt.Rows[74][11].ToString();
            lblKatman.Text = dt.Rows[74][12].ToString();
            lblMaddeninHali.Text = dt.Rows[74][13].ToString();
        }

        private void btnOsmiyum_Click(object sender, EventArgs e)
        {
            Pasiflik();  
            pboxResim.ImageLocation = "Os.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Os;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[75][1].ToString();
            lblElementSerisi.Text = dt.Rows[75][2].ToString();
            lblPeriyot.Text = dt.Rows[75][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[75][4].ToString();
            lblAtomSembolu.Text = dt.Rows[75][5].ToString();
            lblGorunus.Text = dt.Rows[75][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[75][7].ToString();
            lblIzotop.Text = dt.Rows[75][8].ToString();
            lblProton.Text = dt.Rows[75][9].ToString();
            lblNotron.Text = dt.Rows[75][10].ToString();
            lblElektron.Text = dt.Rows[75][11].ToString();
            lblKatman.Text = dt.Rows[75][12].ToString();
            lblMaddeninHali.Text = dt.Rows[75][13].ToString();
        }

        private void btnIridyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ir.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ir;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[76][1].ToString();
            lblElementSerisi.Text = dt.Rows[76][2].ToString();
            lblPeriyot.Text = dt.Rows[76][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[76][4].ToString();
            lblAtomSembolu.Text = dt.Rows[76][5].ToString();
            lblGorunus.Text = dt.Rows[76][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[49][7].ToString();
            lblIzotop.Text = dt.Rows[76][8].ToString();
            lblProton.Text = dt.Rows[76][9].ToString();
            lblNotron.Text = dt.Rows[76][10].ToString();
            lblElektron.Text = dt.Rows[76][11].ToString();
            lblKatman.Text = dt.Rows[76][12].ToString();
            lblMaddeninHali.Text = dt.Rows[76][13].ToString();
        }

        private void btnPlatin_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Pt.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Pt;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[77][1].ToString();
            lblElementSerisi.Text = dt.Rows[77][2].ToString();
            lblPeriyot.Text = dt.Rows[77][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[77][4].ToString();
            lblAtomSembolu.Text = dt.Rows[77][5].ToString();
            lblGorunus.Text = dt.Rows[77][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[77][7].ToString();
            lblIzotop.Text = dt.Rows[77][8].ToString();
            lblProton.Text = dt.Rows[77][9].ToString();
            lblNotron.Text = dt.Rows[77][10].ToString();
            lblElektron.Text = dt.Rows[77][11].ToString();
            lblKatman.Text = dt.Rows[77][12].ToString();
            lblMaddeninHali.Text = dt.Rows[77][13].ToString();
        }

        private void btnAltin_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Au.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Au;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[78][1].ToString();
            lblElementSerisi.Text = dt.Rows[78][2].ToString();
            lblPeriyot.Text = dt.Rows[78][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[78][4].ToString();
            lblAtomSembolu.Text = dt.Rows[78][5].ToString();
            lblGorunus.Text = dt.Rows[78][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[78][7].ToString();
            lblIzotop.Text = dt.Rows[78][8].ToString();
            lblProton.Text = dt.Rows[78][9].ToString();
            lblNotron.Text = dt.Rows[78][10].ToString();
            lblElektron.Text = dt.Rows[78][11].ToString();
            lblKatman.Text = dt.Rows[78][12].ToString();
            lblMaddeninHali.Text = dt.Rows[78][13].ToString();
        }

        private void btnCiva_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Hg.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Hg;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[79][1].ToString();
            lblElementSerisi.Text = dt.Rows[79][2].ToString();
            lblPeriyot.Text = dt.Rows[79][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[79][4].ToString();
            lblAtomSembolu.Text = dt.Rows[79][5].ToString();
            lblGorunus.Text = dt.Rows[79][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[79][7].ToString();
            lblIzotop.Text = dt.Rows[79][8].ToString();
            lblProton.Text = dt.Rows[79][9].ToString();
            lblNotron.Text = dt.Rows[79][10].ToString();
            lblElektron.Text = dt.Rows[79][11].ToString();
            lblKatman.Text = dt.Rows[79][12].ToString();
            lblMaddeninHali.Text = dt.Rows[79][13].ToString();
        }

        private void btnTalyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Tl.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Tl;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[80][1].ToString();
            lblElementSerisi.Text = dt.Rows[80][2].ToString();
            lblPeriyot.Text = dt.Rows[80][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[80][4].ToString();
            lblAtomSembolu.Text = dt.Rows[80][5].ToString();
            lblGorunus.Text = dt.Rows[80][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[80][7].ToString();
            lblIzotop.Text = dt.Rows[80][8].ToString();
            lblProton.Text = dt.Rows[80][9].ToString();
            lblNotron.Text = dt.Rows[80][10].ToString();
            lblElektron.Text = dt.Rows[80][11].ToString();
            lblKatman.Text = dt.Rows[80][12].ToString();
            lblMaddeninHali.Text = dt.Rows[80][13].ToString();
        }

        private void btnKursun_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Pb.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.pbb;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[81][1].ToString();
            lblElementSerisi.Text = dt.Rows[81][2].ToString();
            lblPeriyot.Text = dt.Rows[81][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[81][4].ToString();
            lblAtomSembolu.Text = dt.Rows[81][5].ToString();
            lblGorunus.Text = dt.Rows[81][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[81][7].ToString();
            lblIzotop.Text = dt.Rows[81][8].ToString();
            lblProton.Text = dt.Rows[81][9].ToString();
            lblNotron.Text = dt.Rows[81][10].ToString();
            lblElektron.Text = dt.Rows[81][11].ToString();
            lblKatman.Text = dt.Rows[81][12].ToString();
            lblMaddeninHali.Text = dt.Rows[81][13].ToString();  
        }

        private void btnBizmut_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Bi.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.BI;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[82][1].ToString();
            lblElementSerisi.Text = dt.Rows[82][2].ToString();
            lblPeriyot.Text = dt.Rows[82][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[82][4].ToString();
            lblAtomSembolu.Text = dt.Rows[82][5].ToString();
            lblGorunus.Text = dt.Rows[82][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[82][7].ToString();
            lblIzotop.Text = dt.Rows[82][8].ToString();
            lblProton.Text = dt.Rows[82][9].ToString();
            lblNotron.Text = dt.Rows[82][10].ToString();
            lblElektron.Text = dt.Rows[82][11].ToString();
            lblKatman.Text = dt.Rows[82][12].ToString();
            lblMaddeninHali.Text = dt.Rows[82][13].ToString(); 
        }

        private void btnPolonyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Po.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Po;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[83][1].ToString();
            lblElementSerisi.Text = dt.Rows[83][2].ToString();
            lblPeriyot.Text = dt.Rows[83][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[83][4].ToString();
            lblAtomSembolu.Text = dt.Rows[83][5].ToString();
            lblGorunus.Text = dt.Rows[83][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[83][7].ToString();
            lblIzotop.Text = dt.Rows[83][8].ToString();
            lblProton.Text = dt.Rows[83][9].ToString();
            lblNotron.Text = dt.Rows[83][10].ToString();
            lblElektron.Text = dt.Rows[83][11].ToString();
            lblKatman.Text = dt.Rows[83][12].ToString();
            lblMaddeninHali.Text = dt.Rows[83][13].ToString();
        }

        private void btnAstatin_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "At.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.At;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[84][1].ToString();
            lblElementSerisi.Text = dt.Rows[84][2].ToString();
            lblPeriyot.Text = dt.Rows[84][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[84][4].ToString();
            lblAtomSembolu.Text = dt.Rows[84][5].ToString();
            lblGorunus.Text = dt.Rows[84][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[84][7].ToString();
            lblIzotop.Text = dt.Rows[84][8].ToString();
            lblProton.Text = dt.Rows[84][9].ToString();
            lblNotron.Text = dt.Rows[84][10].ToString();
            lblElektron.Text = dt.Rows[84][11].ToString();
            lblKatman.Text = dt.Rows[84][12].ToString();
            lblMaddeninHali.Text = dt.Rows[84][13].ToString();
        }

        private void btnRadon_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Rn.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Rn;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[85][1].ToString();
            lblElementSerisi.Text = dt.Rows[85][2].ToString();
            lblPeriyot.Text = dt.Rows[85][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[85][4].ToString();
            lblAtomSembolu.Text = dt.Rows[85][5].ToString();
            lblGorunus.Text = dt.Rows[85][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[85][7].ToString();
            lblIzotop.Text = dt.Rows[85][8].ToString();
            lblProton.Text = dt.Rows[85][9].ToString();
            lblNotron.Text = dt.Rows[85][10].ToString();
            lblElektron.Text = dt.Rows[85][11].ToString();
            lblKatman.Text = dt.Rows[85][12].ToString();
            lblMaddeninHali.Text = dt.Rows[85][13].ToString();
        }

        private void btnFransiyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Fr.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Fr;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[86][1].ToString();
            lblElementSerisi.Text = dt.Rows[86][2].ToString();
            lblPeriyot.Text = dt.Rows[86][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[86][4].ToString();
            lblAtomSembolu.Text = dt.Rows[86][5].ToString();
            lblGorunus.Text = dt.Rows[86][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[86][7].ToString();
            lblIzotop.Text = dt.Rows[86][8].ToString();
            lblProton.Text = dt.Rows[86][9].ToString();
            lblNotron.Text = dt.Rows[86][10].ToString();
            lblElektron.Text = dt.Rows[86][11].ToString();
            lblKatman.Text = dt.Rows[86][12].ToString();
            lblMaddeninHali.Text = dt.Rows[86][13].ToString();
        }

        private void btnRadyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ra.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ra;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[87][1].ToString();
            lblElementSerisi.Text = dt.Rows[87][2].ToString();
            lblPeriyot.Text = dt.Rows[87][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[87][4].ToString();
            lblAtomSembolu.Text = dt.Rows[87][5].ToString();
            lblGorunus.Text = dt.Rows[87][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[87][7].ToString();
            lblIzotop.Text = dt.Rows[87][8].ToString();
            lblProton.Text = dt.Rows[87][9].ToString();
            lblNotron.Text = dt.Rows[87][10].ToString();
            lblElektron.Text = dt.Rows[87][11].ToString();
            lblKatman.Text = dt.Rows[87][12].ToString();
            lblMaddeninHali.Text = dt.Rows[87][13].ToString();
        }

        private void btnAktinit_Click(object sender, EventArgs e)
        {
            btnAktinyum.Focus();
        }

        private void btnAktinyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ac.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ac;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[88][1].ToString();
            lblElementSerisi.Text = dt.Rows[88][2].ToString();
            lblPeriyot.Text = dt.Rows[88][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[88][4].ToString();
            lblAtomSembolu.Text = dt.Rows[88][5].ToString();
            lblGorunus.Text = dt.Rows[88][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[88][7].ToString();
            lblIzotop.Text = dt.Rows[88][8].ToString();
            lblProton.Text = dt.Rows[88][9].ToString();
            lblNotron.Text = dt.Rows[88][10].ToString();
            lblElektron.Text = dt.Rows[88][11].ToString();
            lblKatman.Text = dt.Rows[88][12].ToString();
            lblMaddeninHali.Text = dt.Rows[88][13].ToString();
        }

        private void btnToryum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Th.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Th;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[89][1].ToString();
            lblElementSerisi.Text = dt.Rows[89][2].ToString();
            lblPeriyot.Text = dt.Rows[89][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[89][4].ToString();
            lblAtomSembolu.Text = dt.Rows[89][5].ToString();
            lblGorunus.Text = dt.Rows[89][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[89][7].ToString();
            lblIzotop.Text = dt.Rows[89][8].ToString();
            lblProton.Text = dt.Rows[89][9].ToString();
            lblNotron.Text = dt.Rows[89][10].ToString();
            lblElektron.Text = dt.Rows[89][11].ToString();
            lblKatman.Text = dt.Rows[89][12].ToString();
            lblMaddeninHali.Text = dt.Rows[89][13].ToString();
        }

        private void btnProtaktinyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Pa.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Pa;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[90][1].ToString();
            lblElementSerisi.Text = dt.Rows[90][2].ToString();
            lblPeriyot.Text = dt.Rows[90][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[90][4].ToString();
            lblAtomSembolu.Text = dt.Rows[90][5].ToString();
            lblGorunus.Text = dt.Rows[90][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[90][7].ToString();
            lblIzotop.Text = dt.Rows[90][8].ToString();
            lblProton.Text = dt.Rows[90][9].ToString();
            lblNotron.Text = dt.Rows[90][10].ToString();
            lblElektron.Text = dt.Rows[90][11].ToString();
            lblKatman.Text = dt.Rows[90][12].ToString();
            lblMaddeninHali.Text = dt.Rows[90][13].ToString();
        }

        private void btnUranyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "U.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.U;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[91][1].ToString();
            lblElementSerisi.Text = dt.Rows[91][2].ToString();
            lblPeriyot.Text = dt.Rows[91][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[91][4].ToString();
            lblAtomSembolu.Text = dt.Rows[91][5].ToString();
            lblGorunus.Text = dt.Rows[91][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[91][7].ToString();
            lblIzotop.Text = dt.Rows[91][8].ToString();
            lblProton.Text = dt.Rows[91][9].ToString();
            lblNotron.Text = dt.Rows[91][10].ToString();
            lblElektron.Text = dt.Rows[91][11].ToString();
            lblKatman.Text = dt.Rows[91][12].ToString();
            lblMaddeninHali.Text = dt.Rows[91][13].ToString();
        }

        private void btnNeptunyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Np.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.NEP;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[92][1].ToString();
            lblElementSerisi.Text = dt.Rows[92][2].ToString();
            lblPeriyot.Text = dt.Rows[92][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[92][4].ToString();
            lblAtomSembolu.Text = dt.Rows[92][5].ToString();
            lblGorunus.Text = dt.Rows[92][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[92][7].ToString();
            lblIzotop.Text = dt.Rows[92][8].ToString();
            lblProton.Text = dt.Rows[92][9].ToString();
            lblNotron.Text = dt.Rows[92][10].ToString();
            lblElektron.Text = dt.Rows[92][11].ToString();
            lblKatman.Text = dt.Rows[92][12].ToString();
            lblMaddeninHali.Text = dt.Rows[92][13].ToString();
        }

        private void btnPulutanyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Pu.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Pulutanyum;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[93][1].ToString();
            lblElementSerisi.Text = dt.Rows[93][2].ToString();
            lblPeriyot.Text = dt.Rows[93][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[93][4].ToString();
            lblAtomSembolu.Text = dt.Rows[93][5].ToString();
            lblGorunus.Text = dt.Rows[93][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[93][7].ToString();
            lblIzotop.Text = dt.Rows[93][8].ToString();
            lblProton.Text = dt.Rows[93][9].ToString();
            lblNotron.Text = dt.Rows[93][10].ToString();
            lblElektron.Text = dt.Rows[93][11].ToString();
            lblKatman.Text = dt.Rows[93][12].ToString();
            lblMaddeninHali.Text = dt.Rows[93][13].ToString();
        }

        private void btnAmerikyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Amer.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ame;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[94][1].ToString();
            lblElementSerisi.Text = dt.Rows[94][2].ToString();
            lblPeriyot.Text = dt.Rows[94][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[94][4].ToString();
            lblAtomSembolu.Text = dt.Rows[94][5].ToString();
            lblGorunus.Text = dt.Rows[94][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[94][7].ToString();
            lblIzotop.Text = dt.Rows[94][8].ToString();
            lblProton.Text = dt.Rows[94][9].ToString();
            lblNotron.Text = dt.Rows[94][10].ToString();
            lblElektron.Text = dt.Rows[94][11].ToString();
            lblKatman.Text = dt.Rows[94][12].ToString();
            lblMaddeninHali.Text = dt.Rows[94][13].ToString();
        }

        private void btnKuriyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Cm.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Cm;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[95][1].ToString();
            lblElementSerisi.Text = dt.Rows[95][2].ToString();
            lblPeriyot.Text = dt.Rows[95][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[95][4].ToString();
            lblAtomSembolu.Text = dt.Rows[95][5].ToString();
            lblGorunus.Text = dt.Rows[95][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[95][7].ToString();
            lblIzotop.Text = dt.Rows[95][8].ToString();
            lblProton.Text = dt.Rows[95][9].ToString();
            lblNotron.Text = dt.Rows[95][10].ToString();
            lblElektron.Text = dt.Rows[95][11].ToString();
            lblKatman.Text = dt.Rows[95][12].ToString();
            lblMaddeninHali.Text = dt.Rows[95][13].ToString();
        }

        private void btnBerkelyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Bk.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.BkElement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[96][1].ToString();
            lblElementSerisi.Text = dt.Rows[96][2].ToString();
            lblPeriyot.Text = dt.Rows[96][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[96][4].ToString();
            lblAtomSembolu.Text = dt.Rows[96][5].ToString();
            lblGorunus.Text = dt.Rows[96][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[96][7].ToString();
            lblIzotop.Text = dt.Rows[96][8].ToString();
            lblProton.Text = dt.Rows[96][9].ToString();
            lblNotron.Text = dt.Rows[96][10].ToString();
            lblElektron.Text = dt.Rows[96][11].ToString();
            lblKatman.Text = dt.Rows[96][12].ToString();
            lblMaddeninHali.Text = dt.Rows[96][13].ToString();
        }

        private void btnKaliforniyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Cf.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Cf;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[97][1].ToString();
            lblElementSerisi.Text = dt.Rows[97][2].ToString();
            lblPeriyot.Text = dt.Rows[97][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[97][4].ToString();
            lblAtomSembolu.Text = dt.Rows[97][5].ToString();
            lblGorunus.Text = dt.Rows[97][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[97][7].ToString();
            lblIzotop.Text = dt.Rows[97][8].ToString();
            lblProton.Text = dt.Rows[97][9].ToString();
            lblNotron.Text = dt.Rows[97][10].ToString();
            lblElektron.Text = dt.Rows[97][11].ToString();
            lblKatman.Text = dt.Rows[97][12].ToString();
            lblMaddeninHali.Text = dt.Rows[97][13].ToString();
        }

        private void btnEinsteinyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Es.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.EINS;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[98][1].ToString();
            lblElementSerisi.Text = dt.Rows[98][2].ToString();
            lblPeriyot.Text = dt.Rows[98][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[98][4].ToString();
            lblAtomSembolu.Text = dt.Rows[98][5].ToString();
            lblGorunus.Text = dt.Rows[98][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[98][7].ToString();
            lblIzotop.Text = dt.Rows[98][8].ToString();
            lblProton.Text = dt.Rows[98][9].ToString();
            lblNotron.Text = dt.Rows[98][10].ToString();
            lblElektron.Text = dt.Rows[98][11].ToString();
            lblKatman.Text = dt.Rows[98][12].ToString();
            lblMaddeninHali.Text = dt.Rows[98][13].ToString();
        }

        private void btnFermiyum_Click(object sender, EventArgs e)
        {
            Pasiflik();  
            pboxResim.ImageLocation = "Fm.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Fm;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[99][1].ToString();
            lblElementSerisi.Text = dt.Rows[99][2].ToString();
            lblPeriyot.Text = dt.Rows[99][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[99][4].ToString();
            lblAtomSembolu.Text = dt.Rows[99][5].ToString();
            lblGorunus.Text = dt.Rows[99][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[99][7].ToString();
            lblIzotop.Text = dt.Rows[99][8].ToString();
            lblProton.Text = dt.Rows[99][9].ToString();
            lblNotron.Text = dt.Rows[99][10].ToString();
            lblElektron.Text = dt.Rows[99][11].ToString();
            lblKatman.Text = dt.Rows[99][12].ToString();
            lblMaddeninHali.Text = dt.Rows[99][13].ToString();
        }

        private void btnMendelevyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Md.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Md;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[100][1].ToString();
            lblElementSerisi.Text = dt.Rows[100][2].ToString();
            lblPeriyot.Text = dt.Rows[100][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[100][4].ToString();
            lblAtomSembolu.Text = dt.Rows[100][5].ToString();
            lblGorunus.Text = dt.Rows[100][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[100][7].ToString();
            lblIzotop.Text = dt.Rows[100][8].ToString();
            lblProton.Text = dt.Rows[100][9].ToString();
            lblNotron.Text = dt.Rows[100][10].ToString();
            lblElektron.Text = dt.Rows[100][11].ToString();
            lblKatman.Text = dt.Rows[100][12].ToString();
            lblMaddeninHali.Text = dt.Rows[100][13].ToString();
        }

        private void btnNobelyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Lr.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Ra;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[101][1].ToString();
            lblElementSerisi.Text = dt.Rows[101][2].ToString();
            lblPeriyot.Text = dt.Rows[101][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[101][4].ToString();
            lblAtomSembolu.Text = dt.Rows[101][5].ToString();
            lblGorunus.Text = dt.Rows[101][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[101][7].ToString();
            lblIzotop.Text = dt.Rows[101][8].ToString();
            lblProton.Text = dt.Rows[101][9].ToString();
            lblNotron.Text = dt.Rows[101][10].ToString();
            lblElektron.Text = dt.Rows[101][11].ToString();
            lblKatman.Text = dt.Rows[101][12].ToString();
            lblMaddeninHali.Text = dt.Rows[101][13].ToString();
        }

        private void btnLawrensiyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Lr.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Lr;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[102][1].ToString();
            lblElementSerisi.Text = dt.Rows[102][2].ToString();
            lblPeriyot.Text = dt.Rows[102][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[102][4].ToString();
            lblAtomSembolu.Text = dt.Rows[102][5].ToString();
            lblGorunus.Text = dt.Rows[102][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[102][7].ToString();
            lblIzotop.Text = dt.Rows[102][8].ToString();
            lblProton.Text = dt.Rows[102][9].ToString();
            lblNotron.Text = dt.Rows[102][10].ToString();
            lblElektron.Text = dt.Rows[102][11].ToString();
            lblKatman.Text = dt.Rows[102][12].ToString();
            lblMaddeninHali.Text = dt.Rows[102][13].ToString();
        }

        private void btnRifherdiyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Rf.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Rf;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[103][1].ToString();
            lblElementSerisi.Text = dt.Rows[103][2].ToString();
            lblPeriyot.Text = dt.Rows[103][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[103][4].ToString();
            lblAtomSembolu.Text = dt.Rows[103][5].ToString();
            lblGorunus.Text = dt.Rows[103][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[103][7].ToString();
            lblIzotop.Text = dt.Rows[103][8].ToString();
            lblProton.Text = dt.Rows[103][9].ToString();
            lblNotron.Text = dt.Rows[103][10].ToString();
            lblElektron.Text = dt.Rows[103][11].ToString();
            lblKatman.Text = dt.Rows[103][12].ToString();
            lblMaddeninHali.Text = dt.Rows[103][13].ToString();
        }

        private void btnDubniyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Db.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Db;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[104][1].ToString();
            lblElementSerisi.Text = dt.Rows[104][2].ToString();
            lblPeriyot.Text = dt.Rows[104][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[104][4].ToString();
            lblAtomSembolu.Text = dt.Rows[104][5].ToString();
            lblGorunus.Text = dt.Rows[104][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[104][7].ToString();
            lblIzotop.Text = dt.Rows[104][8].ToString();
            lblProton.Text = dt.Rows[104][9].ToString();
            lblNotron.Text = dt.Rows[104][10].ToString();
            lblElektron.Text = dt.Rows[104][11].ToString();
            lblKatman.Text = dt.Rows[104][12].ToString();
            lblMaddeninHali.Text = dt.Rows[104][13].ToString();
        }

        private void btnSeaborgiyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Sg.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Sg;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[105][1].ToString();
            lblElementSerisi.Text = dt.Rows[105][2].ToString();
            lblPeriyot.Text = dt.Rows[105][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[105][4].ToString();
            lblAtomSembolu.Text = dt.Rows[105][5].ToString();
            lblGorunus.Text = dt.Rows[105][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[105][7].ToString();
            lblIzotop.Text = dt.Rows[105][8].ToString();
            lblProton.Text = dt.Rows[105][9].ToString();
            lblNotron.Text = dt.Rows[105][10].ToString();
            lblElektron.Text = dt.Rows[105][11].ToString();
            lblKatman.Text = dt.Rows[105][12].ToString();
            lblMaddeninHali.Text = dt.Rows[105][13].ToString();
        }

        private void btnBohriyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Bh.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Bh;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[106][1].ToString();
            lblElementSerisi.Text = dt.Rows[106][2].ToString();
            lblPeriyot.Text = dt.Rows[106][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[106][4].ToString();
            lblAtomSembolu.Text = dt.Rows[106][5].ToString();
            lblGorunus.Text = dt.Rows[106][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[106][7].ToString();
            lblIzotop.Text = dt.Rows[106][8].ToString();
            lblProton.Text = dt.Rows[106][9].ToString();
            lblNotron.Text = dt.Rows[106][10].ToString();
            lblElektron.Text = dt.Rows[106][11].ToString();
            lblKatman.Text = dt.Rows[106][12].ToString();
            lblMaddeninHali.Text = dt.Rows[106][13].ToString();
        }

        private void btnHassiyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Hs.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Hs;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[107][1].ToString();
            lblElementSerisi.Text = dt.Rows[107][2].ToString();
            lblPeriyot.Text = dt.Rows[107][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[107][4].ToString();
            lblAtomSembolu.Text = dt.Rows[107][5].ToString();
            lblGorunus.Text = dt.Rows[107][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[107][7].ToString();
            lblIzotop.Text = dt.Rows[107][8].ToString();
            lblProton.Text = dt.Rows[107][9].ToString();
            lblNotron.Text = dt.Rows[107][10].ToString();
            lblElektron.Text = dt.Rows[107][11].ToString();
            lblKatman.Text = dt.Rows[107][12].ToString();
            lblMaddeninHali.Text = dt.Rows[107][13].ToString();
        }

        private void btnNeitneriyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Mt.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Mt;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[108][1].ToString();
            lblElementSerisi.Text = dt.Rows[108][2].ToString();
            lblPeriyot.Text = dt.Rows[108][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[108][4].ToString();
            lblAtomSembolu.Text = dt.Rows[108][5].ToString();
            lblGorunus.Text = dt.Rows[108][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[108][7].ToString();
            lblIzotop.Text = dt.Rows[108][8].ToString();
            lblProton.Text = dt.Rows[108][9].ToString();
            lblNotron.Text = dt.Rows[108][10].ToString();
            lblElektron.Text = dt.Rows[108][11].ToString();
            lblKatman.Text = dt.Rows[108][12].ToString();
            lblMaddeninHali.Text = dt.Rows[108][13].ToString();
        }

        private void btnDarmstadtiyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Ds.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Darmstadtium;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[109][1].ToString();
            lblElementSerisi.Text = dt.Rows[109][2].ToString();
            lblPeriyot.Text = dt.Rows[109][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[109][4].ToString();
            lblAtomSembolu.Text = dt.Rows[109][5].ToString();
            lblGorunus.Text = dt.Rows[109][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[109][7].ToString();
            lblIzotop.Text = dt.Rows[109][8].ToString();
            lblProton.Text = dt.Rows[109][9].ToString();
            lblNotron.Text = dt.Rows[109][10].ToString();
            lblElektron.Text = dt.Rows[109][11].ToString();
            lblKatman.Text = dt.Rows[109][12].ToString();
            lblMaddeninHali.Text = dt.Rows[109][13].ToString();
        }

        private void btnRontgenyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Rg.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Rg;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[110][1].ToString();
            lblElementSerisi.Text = dt.Rows[110][2].ToString();
            lblPeriyot.Text = dt.Rows[110][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[110][4].ToString();
            lblAtomSembolu.Text = dt.Rows[110][5].ToString();
            lblGorunus.Text = dt.Rows[110][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[110][7].ToString();
            lblIzotop.Text = dt.Rows[110][8].ToString();
            lblProton.Text = dt.Rows[110][9].ToString();
            lblNotron.Text = dt.Rows[110][10].ToString();
            lblElektron.Text = dt.Rows[110][11].ToString();
            lblKatman.Text = dt.Rows[110][12].ToString();
            lblMaddeninHali.Text = dt.Rows[110][13].ToString();
        }

        private void btnCn_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Cn.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Cn;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[111][1].ToString();
            lblElementSerisi.Text = dt.Rows[111][2].ToString();
            lblPeriyot.Text = dt.Rows[111][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[111][4].ToString();
            lblAtomSembolu.Text = dt.Rows[111][5].ToString();
            lblGorunus.Text = dt.Rows[111][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[111][7].ToString();
            lblIzotop.Text = dt.Rows[111][8].ToString();
            lblProton.Text = dt.Rows[111][9].ToString();
            lblNotron.Text = dt.Rows[111][10].ToString();
            lblElektron.Text = dt.Rows[111][11].ToString();
            lblKatman.Text = dt.Rows[111][12].ToString();
            lblMaddeninHali.Text = dt.Rows[111][13].ToString();
        }

        private void btnUut_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Uut.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.UutElement;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[112][1].ToString();
            lblElementSerisi.Text = dt.Rows[112][2].ToString();
            lblPeriyot.Text = dt.Rows[112][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[112][4].ToString();
            lblAtomSembolu.Text = dt.Rows[112][5].ToString();
            lblGorunus.Text = dt.Rows[112][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[112][7].ToString();
            lblIzotop.Text = dt.Rows[112][8].ToString();
            lblProton.Text = dt.Rows[112][9].ToString();
            lblNotron.Text = dt.Rows[112][10].ToString();
            lblElektron.Text = dt.Rows[112][11].ToString();
            lblKatman.Text = dt.Rows[112][12].ToString();
            lblMaddeninHali.Text = dt.Rows[112][13].ToString();
        }

        private void btnFlerovyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Fl.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Elementtt;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[113][1].ToString();
            lblElementSerisi.Text = dt.Rows[113][2].ToString();
            lblPeriyot.Text = dt.Rows[113][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[113][4].ToString();
            lblAtomSembolu.Text = dt.Rows[113][5].ToString();
            lblGorunus.Text = dt.Rows[113][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[113][7].ToString();
            lblIzotop.Text = dt.Rows[113][8].ToString();
            lblProton.Text = dt.Rows[113][9].ToString();
            lblNotron.Text = dt.Rows[113][10].ToString();
            lblElektron.Text = dt.Rows[113][11].ToString();
            lblKatman.Text = dt.Rows[113][12].ToString();
            lblMaddeninHali.Text = dt.Rows[113][13].ToString();
        }

        private void btnUnunpentiyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "uuuu.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.uuuu;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[114][1].ToString();
            lblElementSerisi.Text = dt.Rows[114][2].ToString();
            lblPeriyot.Text = dt.Rows[114][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[114][4].ToString();
            lblAtomSembolu.Text = dt.Rows[114][5].ToString();
            lblGorunus.Text = dt.Rows[114][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[114][7].ToString();
            lblIzotop.Text = dt.Rows[114][8].ToString();
            lblProton.Text = dt.Rows[114][9].ToString();
            lblNotron.Text = dt.Rows[114][10].ToString();
            lblElektron.Text = dt.Rows[114][11].ToString();
            lblKatman.Text = dt.Rows[114][12].ToString();
            lblMaddeninHali.Text = dt.Rows[114][13].ToString();
        }

        private void btnLivermoryum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Lv.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.Lv;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[115][1].ToString();
            lblElementSerisi.Text = dt.Rows[115][2].ToString();
            lblPeriyot.Text = dt.Rows[115][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[115][4].ToString();
            lblAtomSembolu.Text = dt.Rows[115][5].ToString();
            lblGorunus.Text = dt.Rows[115][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[115][7].ToString();
            lblIzotop.Text = dt.Rows[115][8].ToString();
            lblProton.Text = dt.Rows[115][9].ToString();
            lblNotron.Text = dt.Rows[115][10].ToString();
            lblElektron.Text = dt.Rows[115][11].ToString();
            lblKatman.Text = dt.Rows[115][12].ToString();
            lblMaddeninHali.Text = dt.Rows[115][13].ToString();
        }

        private void btnUnunseptiyum_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Uus.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.UUS;
            baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[116][1].ToString();
            lblElementSerisi.Text = dt.Rows[116][2].ToString();
            lblPeriyot.Text = dt.Rows[116][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[116][4].ToString();
            lblAtomSembolu.Text = dt.Rows[116][5].ToString();
            lblGorunus.Text = dt.Rows[116][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[116][7].ToString();
            lblIzotop.Text = dt.Rows[116][8].ToString();
            lblProton.Text = dt.Rows[116][9].ToString();
            lblNotron.Text = dt.Rows[116][10].ToString();
            lblElektron.Text = dt.Rows[116][11].ToString();
            lblKatman.Text = dt.Rows[116][12].ToString();
            lblMaddeninHali.Text = dt.Rows[116][13].ToString();
        }

        private void btUnunoktiyumn_Click(object sender, EventArgs e)
        {
            Pasiflik(); 
            pboxResim.ImageLocation = "Uuo.jpg";
            btnIzotop.BackgroundImage = Properties.Resources.UUOO; baglanti.Open();
            OleDbCommand Element = new OleDbCommand("SELECT * FROM  PeriyodikTablo", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(Element);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            lblElementAdi.Text = dt.Rows[117][1].ToString();
            lblElementSerisi.Text = dt.Rows[117][2].ToString();
            lblPeriyot.Text = dt.Rows[117][3].ToString();
            lblAtomNumarasi.Text = dt.Rows[117][4].ToString();
            lblAtomSembolu.Text = dt.Rows[117][5].ToString();
            lblGorunus.Text = dt.Rows[117][6].ToString();
            lblEvrendekiYeri.Text = dt.Rows[117][7].ToString();
            lblIzotop.Text = dt.Rows[117][8].ToString();
            lblProton.Text = dt.Rows[117][9].ToString();
            lblNotron.Text = dt.Rows[117][10].ToString();
            lblElektron.Text = dt.Rows[117][11].ToString();
            lblKatman.Text = dt.Rows[117][12].ToString();
            lblMaddeninHali.Text = dt.Rows[117][13].ToString();
        }

        private void btnLantanin_MouseEnter(object sender, EventArgs e)
        {  
  
        }

        private void btnLantanin_MouseHover(object sender, EventArgs e)
        {
            btnLantan.FlatAppearance.BorderColor=Color.Red;
            btnSeryum.FlatAppearance.BorderColor = Color.Red;
            btnPresoidim.FlatAppearance.BorderColor = Color.Red;
            btnNeoidim.FlatAppearance.BorderColor = Color.Red;
            btnPrometyum.FlatAppearance.BorderColor = Color.Red;
            btnSamaryum.FlatAppearance.BorderColor = Color.Red;
            btnEvropyum.FlatAppearance.BorderColor = Color.Red;
            btnGadolinyum.FlatAppearance.BorderColor = Color.Red;
            btnTerbinyum.FlatAppearance.BorderColor = Color.Red; 
            btnDisprosunyum.FlatAppearance.BorderColor = Color.Red;
            btnHolmiyum.FlatAppearance.BorderColor = Color.Red;
            btnErbiyum.FlatAppearance.BorderColor = Color.Red;
            btnTulyum.FlatAppearance.BorderColor = Color.Red;
            btnIterbiryum.FlatAppearance.BorderColor = Color.Red;
            btnLutesyum.FlatAppearance.BorderColor = Color.Red;

        }
        private void btnLantanin_MouseLeave(object sender, EventArgs e)
        {
            btnLantan.FlatAppearance.BorderColor = Color.Black;
            btnSeryum.FlatAppearance.BorderColor = Color.Black;
            btnPresoidim.FlatAppearance.BorderColor = Color.Black;
            btnNeoidim.FlatAppearance.BorderColor = Color.Black;
            btnPrometyum.FlatAppearance.BorderColor = Color.Black;
            btnSamaryum.FlatAppearance.BorderColor = Color.Black;
            btnEvropyum.FlatAppearance.BorderColor = Color.Black;
            btnGadolinyum.FlatAppearance.BorderColor = Color.Black;
            btnTerbinyum.FlatAppearance.BorderColor = Color.Black;
            btnDisprosunyum.FlatAppearance.BorderColor = Color.Black;
            btnHolmiyum.FlatAppearance.BorderColor = Color.Black;
            btnErbiyum.FlatAppearance.BorderColor = Color.Black;
            btnTulyum.FlatAppearance.BorderColor = Color.Black;
            btnIterbiryum.FlatAppearance.BorderColor = Color.Black;
            btnLutesyum.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnAktinit_MouseHover(object sender, EventArgs e)
        {
            btnAktinyum.FlatAppearance.BorderColor = Color.Red;
            btnToryum.FlatAppearance.BorderColor = Color.Red;
            btnProtaktinyum.FlatAppearance.BorderColor = Color.Red;
            btnUranyum.FlatAppearance.BorderColor = Color.Red;
            btnNeptunyum.FlatAppearance.BorderColor = Color.Red;
            btnPulutanyum.FlatAppearance.BorderColor = Color.Red;
            btnAmerikyum.FlatAppearance.BorderColor = Color.Red;
            btnKuriyum.FlatAppearance.BorderColor = Color.Red;
            btnBerkelyum.FlatAppearance.BorderColor = Color.Red;
            btnKaliforniyum.FlatAppearance.BorderColor = Color.Red;
            btnEinsteinyum.FlatAppearance.BorderColor = Color.Red;
            btnFermiyum.FlatAppearance.BorderColor = Color.Red;
            btnMendelevyum.FlatAppearance.BorderColor = Color.Red;
            btnNobelyum.FlatAppearance.BorderColor = Color.Red;
            btnLawrensiyum.FlatAppearance.BorderColor = Color.Red;

        } 


        private void btnAktinit_MouseLeave(object sender, EventArgs e)
        {

            btnAktinyum.FlatAppearance.BorderColor = Color.Black;
            btnToryum.FlatAppearance.BorderColor = Color.Black;
            btnProtaktinyum.FlatAppearance.BorderColor = Color.Black;
            btnUranyum.FlatAppearance.BorderColor = Color.Black;
            btnNeptunyum.FlatAppearance.BorderColor = Color.Black;
            btnPulutanyum.FlatAppearance.BorderColor = Color.Black;
            btnAmerikyum.FlatAppearance.BorderColor = Color.Black;
            btnKuriyum.FlatAppearance.BorderColor = Color.Black;
            btnBerkelyum.FlatAppearance.BorderColor = Color.Black;
            btnKaliforniyum.FlatAppearance.BorderColor = Color.Black;
            btnEinsteinyum.FlatAppearance.BorderColor = Color.Black;
            btnFermiyum.FlatAppearance.BorderColor = Color.Black;
            btnMendelevyum.FlatAppearance.BorderColor = Color.Black;
            btnNobelyum.FlatAppearance.BorderColor = Color.Black;
            btnLawrensiyum.FlatAppearance.BorderColor = Color.Black;
        }
         
       

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void tsmCik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmGizle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tsmAc_Click(object sender, EventArgs e)
        { 
            this.Show();
        }

        private void tsmHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#'CILAR", "HAKKIMIZDA", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        

         }
        
    }
 
