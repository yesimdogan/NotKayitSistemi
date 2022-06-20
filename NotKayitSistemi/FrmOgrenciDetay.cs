﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotKayitSistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public string numara;

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbNotKayit;Integrated Security=True");
       
       
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERS where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblSinav1.Text = dr[4].ToString();
                lblSinav2.Text = dr[5].ToString();
                lblSinav3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                lblDurum.Text = dr[8].ToString();
            }

            baglanti.Close();
        }

        private void lblNumara_Click(object sender, EventArgs e)
        {

        }

        private void lblNumara_Click_1(object sender, EventArgs e)
        {

        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {

        }
    }
}
