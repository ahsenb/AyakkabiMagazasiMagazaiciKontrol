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
    public partial class IsikveKlimaKapatma : Form
    {
        public IsikveKlimaKapatma()
        {
            InitializeComponent();
        }
        Button btn;
        private void IsikveKlimaKapatma_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 3; i++)
            {
                btn = new Button();
                btn.Name = i.ToString();
                btn.Text = i.ToString();
                btn.Width = 35;
                btn.Height = 35;
                btn.Click += new EventHandler(btn_Click);
                btn.TabIndex = i;
                flowLayoutPanel1.Controls.Add(btn);

            }
            for (int i = 1; i < 3; i++)
            {
                btn = new Button();
                btn.Name = i.ToString();
                btn.Text = i.ToString();
                btn.Width = 35;
                btn.Height = 35;
                btn.Click += new EventHandler(btn_Click2);
                btn.TabIndex = i;
                flowLayoutPanel2.Controls.Add(btn);

            }
            listBox1.Items.Add("Açma:1");
            listBox1.Items.Add("Kapama:2");

        }

        private void btn_Click2(object sender, EventArgs e)
        {
            //Ccommand pattern cagırma
            if ((sender as Button).TabIndex == 1)
            {
                Isik isik = new Isik();
                ICommand switchUp = new FlipUpCommand(isik);
                Switch s = new Switch();
                s.StoreAndExecute(switchUp);
            }
            else if ((sender as Button).TabIndex == 2)
            {
                Isik isik = new Isik();
                ICommand switchDown = new FlipDownCommand(isik);
                Switch s = new Switch();
                s.StoreAndExecute(switchDown);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //command pattern cagırma
            if ((sender as Button).TabIndex == 1)
            {
                Klima klima = new Klima();
                ICommand2 switchUp2 = new FlipUpCommand2(klima);
                ICommand2 switchDown= new FlipUpCommand2(klima);
                Switch2 s2 = new Switch2();
                s2.StoreAndExecute(switchUp2);

            }
            else if ((sender as Button).TabIndex == 2)
            {
                Klima klima = new Klima();
                ICommand2 switchDown2 = new FlipDownCommand2(klima);
                Switch2 s2 = new Switch2();
                s2.StoreAndExecute(switchDown2);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Bitis b = new Bitis();
            b.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
