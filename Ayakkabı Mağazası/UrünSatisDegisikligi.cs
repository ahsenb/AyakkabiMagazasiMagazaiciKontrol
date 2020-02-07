using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayakkabı_Mağazası
{
    public partial class UrünSatisDegisikligi : Form
    {
        public UrünSatisDegisikligi()
        {
            InitializeComponent();
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        
        private void UrünSatisDegisikligi_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                ProductManager productManager = new ProductManager(new AyakkabıAdapter());
                productManager.Save();
            }
            else
            {
                ProductManager productManager = new ProductManager(new Canta());
                productManager.Save();
            }
            Bitis b = new Bitis();
            b.Show();
            this.Hide();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
