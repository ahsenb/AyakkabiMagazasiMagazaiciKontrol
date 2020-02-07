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
    public partial class ElemanEkle : Form
    {
        public ElemanEkle()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Button btn;
        private void ElemanEkle_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 2; i++)
            {
                //buton ekleme yapıldı
                btn = new Button();
                btn.Name = i.ToString();
                btn.Text = i.ToString();
                btn.Width = 50;
                btn.Height = 50;
                btn.Click += new EventHandler(btn_Click);
                btn.TabIndex = i;
                flowLayoutPanel1.Controls.Add(btn);

            }
            //liste içine yazıldı
            listBox1.Items.Add("Çalışanı Ekle:1");
            listBox1.Items.Add("Çalışanı Çıkar:2");
        }

        private void btn_Click(object sender, EventArgs e)
        {

            if ((sender as Button).TabIndex == 1)
            {
                //composite pattern
                Employee yonetici = new Employee();
                yonetici.Name = textBox1.Text;
                Employee calisan = new Employee();
                calisan.Name = textBox2.Text;
                yonetici.AddSubordinate(calisan);
                MessageBox.Show(textBox2 + " eklendi.");
                

            }
            else
            {
                //composite pattern
                Employee yonetici = new Employee();
                yonetici.Name = textBox1.Text;
                Employee calisan = new Employee();
                yonetici.Name = textBox2.Text;
                MessageBox.Show(textBox2 + " çıkarıldı.");
              

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Bitis b = new Bitis();
            b.Show();
            this.Hide();
        }
    }
}
