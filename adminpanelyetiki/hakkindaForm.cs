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

namespace adminpanelyetiki
{
    public partial class hakkindaForm : Form
    {
        public hakkindaForm()
        {
            InitializeComponent();
        }

        private void aboutrichTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_SizeChanged(object sender, EventArgs e)
        {
            //yazılara göre label boyutunu ayarladık
            byte currentSize = Convert.ToByte(label1.Font.Size);

            label1.Font = new System.Drawing.Font(label1.Font.Name, currentSize - 1);

        }
    }
}
