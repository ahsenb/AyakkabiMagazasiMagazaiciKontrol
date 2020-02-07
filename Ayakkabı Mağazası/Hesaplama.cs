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
    public partial class Hesaplama : Form
    {
        public Hesaplama()
        {
            InitializeComponent();
        }

        private void GünSonuHesaplama_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Mağaza Adı: ", 100);
            listView1.Columns.Add("Sayı: ", 100);
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { textBox1.Text, textBox2.Text };
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox3.Text);
            sayi2 = Convert.ToInt32(textBox4.Text);
            Operasyon operasyon;
            if (radioButton1.Checked==true)
            {
                //template pattern cagırma
                operasyon = new Toplama();
                sonuc = operasyon.OpHazirla(sayi1, sayi2);
                MessageBox.Show(sonuc.ToString(), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bitis b = new Bitis();
                b.Show();
                this.Hide();
            }
            else if(radioButton2.Checked==true)
            {
                //tepmlate pattern cagırma
                operasyon = new Bolme();
                sonuc = operasyon.OpHazirla(sayi1, sayi2);
                MessageBox.Show(sonuc.ToString(),"Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bitis b = new Bitis();
                b.Show();
                this.Hide();

            }
            else if (radioButton3.Checked == true)
            {
                //tepmlate pattern cagırma
                operasyon = new Cikarma();
                sonuc = operasyon.OpHazirla(sayi1, sayi2);
                MessageBox.Show(sonuc.ToString(), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bitis b = new Bitis();
                b.Show();
                this.Hide();
            }
            else if (radioButton4.Checked == true)
            {
                //tepmlate pattern cagırma
                operasyon = new Carpma();
                sonuc = operasyon.OpHazirla(sayi1, sayi2);
                MessageBox.Show(sonuc.ToString(), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bitis b = new Bitis();
                b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları doldurunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Bitis b = new Bitis();
            b.Show();
            this.Hide();
        }
    }
}
