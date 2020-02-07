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
    public partial class AyakkabıSiparisiVer : Form
    {
        public AyakkabıSiparisiVer()
        {
            InitializeComponent();
        }

        private void AyakkabıSiparisiVer_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Aras Kargo");
            checkedListBox1.Items.Add("MNG Kargo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = checkedListBox1.Items.Count;
            for (int i = 0; i < toplam; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AyakkabıSiparisiVer_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        ErrorProvider provider = new ErrorProvider();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                provider.SetError(textBox1, "BU ALAN BOŞ GEÇİLEMEZ!!");
            }
            else
            {
                //facade pattern cagırma 
                string UrunAdi1 = label1.Text;
                string UrunAdi2 = label2.Text;
                int Adet1 = Convert.ToInt16(textBox1.Text);
                int Adet2 = Convert.ToInt16(textBox1.Text);
                SiparisFacade siparisFacade = new SiparisFacade();
                List<SepettekiUrun> urunler = new List<SepettekiUrun>
                {
                    new SepettekiUrun{Id=1, UrunAdi=UrunAdi1, Adet=Adet1},
                    new SepettekiUrun{Id=2, UrunAdi=UrunAdi2, Adet=Adet2},
                };
                siparisFacade.SiparisVer(UrunAdi1, UrunAdi2, urunler);
                Bitis b = new Bitis();
                b.Show();
                this.Hide();
            }

        }
        
        
    }
}

