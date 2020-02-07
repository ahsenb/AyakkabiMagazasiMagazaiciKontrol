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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        Button btn;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                btn = new Button();
                btn.Name = i.ToString();
                btn.Text = i.ToString();
                btn.Width = 50;
                btn.Height = 50;
                btn.Click += new EventHandler(btn_Click);
                btn.TabIndex = i;
                flowLayoutPanel1.Controls.Add(btn);

            }
            listBox1.Items.Add("Ürün Satış Değişikliği                                   :1");
            listBox1.Items.Add("Ayakkabı Siparişi Ver                            :2");
            listBox1.Items.Add("Eleman Ekle                                              :3");
            listBox1.Items.Add("Hesaplama                                                :4");
            listBox1.Items.Add("Mağazanın Işıklarını ve Klimalarını Kapat   :5");
            
            

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if((sender as Button).TabIndex==1)
            {
                UrünSatisDegisikligi usd = new UrünSatisDegisikligi();
                usd.Show();
                this.Hide();
            }
            else if((sender as Button).TabIndex==2)
            {
                AyakkabıSiparisiVer asv = new AyakkabıSiparisiVer();
                asv.Show();
                this.Hide();
            }
            else if((sender as Button).TabIndex==3)
            {
                ElemanEkle ee = new ElemanEkle();
                ee.Show();
                this.Hide();
            }
            else if((sender as Button).TabIndex==4)
            {
                Hesaplama h = new Hesaplama();
                h.Show();
                this.Hide();
            }
            else
            {
                IsikveKlimaKapatma kkp = new IsikveKlimaKapatma();
                kkp.Show();
                this.Hide();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
