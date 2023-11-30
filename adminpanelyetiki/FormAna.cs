using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace adminpanelyetiki
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            LOGINFORM logform = new LOGINFORM();
            logform.MdiParent = this;
            logform.Show();
        }
        private void satisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toptanciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personalkontrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personalkntrolForm personal = new personalkntrolForm();
            personal.MdiParent = this;
            personal.Text = "PERSONAL KONTROL";
            personal.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            SqlConnection baglanti = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=satis;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM personal", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            personal.dataGridView1.DataSource = dt;
            personal.Show();
            baglanti.Close();
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkindaForm hak = new hakkindaForm();
            hak.MdiParent = this;
            hak.Text = "HAKKIMIZDA";
            hak.FormBorderStyle = FormBorderStyle.FixedToolWindow ;
            hak.label1.Text = "**** yılında kurduğumuz marka şirketi, toptan üretim ile başladığı girişimcilik serüvenini mağazacılık ve e-ticaret ile güçlendirmeyi başarmış, şubeleri ile de bu serüveni en ileri boyuta taşımıştır. Sunduğumuz kullanıcı öncelikli stratejilerimiz ve ayrıcalıklı müşteri portföyü ile değerini paha biçilemez şekilde ikiye katlayarak, marka değerimizi hassasiyetle zirveye taşımayı başardık. Dünya standartlarını göz önünde bulundurarak çözüm ve güven içerikli ilkemiz ile yola çıktığımız bu serüvende; otorite rayından çıkmayarak, istikrarlı şekilde sayısız müşteriye en iyi marka sahipliğini yapmış durumdayız.\r\n\r\nKuruluşundan günümüze süregelen profesyonellik, empati odaklı, dürüstlük ve gelişime açık bakış açımız ile istikrarlı büyüme sergileyerek, e-ticaret dünyasında saygın bir konuma yükselmeye hak kazandık.\r\n\r\nMarkamız; **** alanında en kaliteli ürünleri, tüketiciye en uygun fiyat ile sunma amacıyla kurulmuş olup, geride bıraktığımız ** yıl boyunca da, sektörde yaklaşımımızı aynı titizlik dâhilinde korumaya devam etmekteyiz.\r\n\r\nMarkamız üzerinden gerçekleştirdiğiniz tüm alışverişlerinizde; mağduriyet içermeyen, hızlı teslimat, iptal/iade/değişim bilinci ile yaklaşımını sağlayan müşteri temsilcilerimiz ile en keyifli alışveriş deneyimini yaşamayı mümkün kılıyoruz.\r\n\r\nSektördeki son gelişmeleri ve kullanıcı alanındaki güncel talepleri takip ederek, çağdaş düzeydeki teknolojiyle buluşturduğumuz web adresimizi sizlere sunuyor, en iyi ekip arkadaşlarımız, güçlü ve profesyonel idari yönetimimiz ile takibini gerçekleştirerek, tüketici haklarını en iyi şekilde yaşamanızı elde etmenizi sağlıyoruz.\r\n\r\nHedefimiz; kullanıcı deneyimi ile e-ticaret camiasında “ziyaretçi memnuniyeti en yüksek” konumuna ulaşarak, halkın takdirini kazanmak ve sitemizden sorunsuz, mutlu tüketici konumunda ayrılmanızı sağlamak.\r\n\r\nÖrnek nitelikle misyonunu genişleterek, projelerini hayata geçirmeye devam eden markamız, standartların üstünde kaliteyle öncülük ederek, birçok memnuniyet beraberinde başarılı işlere imzasını atarak başarısına başarı katacak, güçlü kadro dâhilinde sorun odaklı çalışma prensibi ile organizasyonel şekilde sizin memnuniyetinizi sağlamaya devam edecektir.";
            hak.Show();
        }


    }
}
