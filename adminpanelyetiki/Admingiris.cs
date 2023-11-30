using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace adminpanelyetiki
{
    public partial class LOGINFORM : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=satis;Integrated Security=True");
        SqlDataAdapter da;
        public LOGINFORM()
        {
            InitializeComponent();
        }

        private void girisbutton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM personal WHERE ad = @ad AND sifre = @sifre";
            da = new SqlDataAdapter(sorgu, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@ad", usernametextBox.Text);
            da.SelectCommand.Parameters.AddWithValue("@sifre", passtextBox.Text);
            DataTable dr= new DataTable();
            da.Fill(dr);
            if (dr.Rows.Count > 0)
            {
                yetki.ad = dr.Rows[0]["ad"].ToString();
                yetki.soyad = dr.Rows[0]["soyad"].ToString();
                yetki.yetkiid = dr.Rows[0]["yetkiid"].ToString();
                if (yetki.yetkiid == "1")
                {
                    ((FormAna)this.ParentForm).toptanciToolStripMenuItem.Enabled = true;
                    ((FormAna)this.ParentForm).personalkontrlToolStripMenuItem.Enabled = true;
                }
                ((FormAna)this.ParentForm).menuStrip1.Visible = true;
                ((FormAna)this.ParentForm).welcomeStripStatusLabel1.Text = "Sayın " + yetki.ad + " " +yetki.soyad+", sisteme hoş geldiniz.";
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı giriş!\nBilgilerinizi kontrol ederek tekrar deneyiniz.");
            }
            baglanti.Close();
            
        }

        private void LOGINFORM_Load(object sender, EventArgs e)
        {

        }
    }
}
