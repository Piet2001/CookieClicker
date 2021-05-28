using System;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            UpdateAlles();
        }

        KoekjesController controller = new KoekjesController();
        Upgrade bakker = new Upgrade("Bakker", 10, 100, 150);
        Upgrade oven = new Upgrade("Oven", 50, 2000, 450);
        Upgrade deegroller = new Upgrade("Deegroller", 0, 3500, 700);

        private void Koekje_MouseDown(object sender, MouseEventArgs e)
        {
            controller.Koekjes += controller.KoekjesPerKlik;
            UpdateAlles();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controller.Koekjes += controller.Kps;
            UpdateAlles();
            
        }
        private void UpdateVelden()
        {
            KoekjesValue.Text = Convert.ToString(controller.Koekjes);
            KpsValue.Text = Convert.ToString(controller.Kps);

            BT_Bakker.Text = bakker.Naam + " (" + bakker.Prijs + ") : " + bakker.Aantal;
            BT_Oven.Text = oven.Naam + " (" + oven.Prijs + ") : " + oven.Aantal;
            BT_deegroller.Text = deegroller.Naam + " (" + deegroller.Prijs + ") : " + deegroller.Aantal;
        }

        private void UpdateAlles()
        {
            UpdateVelden();
            ControleerUpgrades();
        }

        private void ControleerUpgrades()
        {
            if (controller.Koekjes >= bakker.Prijs)
            {
                BT_Bakker.Enabled = true;
            }
            else { BT_Bakker.Enabled = false; }

            if(controller.Koekjes >= oven.Prijs)
            {
                BT_Oven.Enabled = true;
            }
            else { BT_Oven.Enabled = false; }

            if(controller.Koekjes >= deegroller.Prijs)
            {
                BT_deegroller.Enabled = true;
            }
            else { BT_deegroller.Enabled = false; }
        }

        private void BT_bakker_Click(object sender, EventArgs e)
        {
            controller.Kps += bakker.Kps;
            controller.Koekjes -= bakker.Prijs;
            bakker.Prijs += bakker.PrijsInterval;
            bakker.Aantal += 1;
            UpdateAlles();
        }

        private void BT_Oven_Click(object sender, EventArgs e)
        {
            controller.Kps += oven.Kps;
            controller.Koekjes -= oven.Prijs;
            oven.Prijs += oven.PrijsInterval;
            oven.Aantal += 1;                  
            UpdateAlles();
        }

        private void BT_deegroller_Click(object sender, EventArgs e)
        {
            controller.KoekjesPerKlik += 10;
            controller.Koekjes -= deegroller.Prijs;
            deegroller.Prijs += deegroller.PrijsInterval;
            deegroller.Aantal += 1;
            UpdateAlles();
        }
    }
}
