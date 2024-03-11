using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        private double suma = 0;
        enum Podstawa
        {
            Margarita = 20,
            Bianka = 20
        }
        enum Dodatki
        {
            PodwójnySer = 2,
            Szynka = 3,
            PaprykaSłodka = 2,
            PaprykaChilli = 3,
            Pieczarki = 2,
            KiełbasaSalami = 3,
            Ananas = 3,
            Cebula = 2,
            SalsaPomidorowa = 4,
            SosCzosnkowy = 3,
            PodwójneCiasto = 2
        }
        enum OpcjeDodatkowe
        {
            Opakowanie = 2,
            Sztućce = 1,
            CocaCola = 5,
            Woda = 3,
            Kawa = 6,
            Herbata = 6
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void obliczbtn_Click(object sender, EventArgs e)
        {
            logoImg.Image = new Bitmap("..\\images\\pizzeria-bye1.png");
            logoImg.Width = 192;
            logoImg.Height = 192;
            pods1.Text = "";
            dodatIndeks.Text = "";
            pods2.Text = "";
            pods3.Text = "";
            pods1.Text = "Podstawa: ";
            if (margarita.Checked == true)
            {
                suma += (int)Podstawa.Margarita;
                pods1.Text += Convert.ToString(margarita.Text);

            }else if(bianka.Checked == true)
            {
                suma += (int)Podstawa.Bianka;
                pods1.Text += Convert.ToString(bianka.Text);
            }
            dodatIndeks.Text = "Dodatki: ";
            if (pSer.Checked == true)
            {
                suma += (int)Dodatki.PodwójnySer;
                pods2.Text += Convert.ToString(pSer.Text + "\n");
            }
            if (szynka.Checked == true)
            {
                suma += (int)Dodatki.Szynka;
                pods2.Text += Convert.ToString(szynka.Text + "\n");
            }
            if (pSlodka.Checked == true)
            {
                suma += (int)Dodatki.PaprykaSłodka;
                pods2.Text += Convert.ToString(pSlodka.Text + "\n");
            }
            if (pChilli.Checked == true)
            {
                suma += (int)Dodatki.PaprykaChilli;
                pods2.Text += Convert.ToString(pChilli.Text + "\n");
            }
            if (pPieczarki.Checked == true)
            {
                suma += (int)Dodatki.Pieczarki;
                pods2.Text += Convert.ToString(pPieczarki.Text + "\n");
            }
            if (kSalami.Checked == true)
            {
                suma += (int)Dodatki.KiełbasaSalami;
                pods2.Text += Convert.ToString(kSalami.Text + "\n");
            }
            if (ananas.Checked == true)
            {
                suma += (int)Dodatki.Ananas;
                pods2.Text += Convert.ToString(ananas.Text + "\n");
            }
            if (cebula.Checked == true)
            {
                suma += (int)Dodatki.Cebula;
                pods2.Text += Convert.ToString(cebula.Text + "\n");
            }
            if (sPomidor.Checked == true)
            {
                suma += (int)Dodatki.SalsaPomidorowa;
                pods2.Text += Convert.ToString(sPomidor.Text + "\n");
            }
            if (sCzosnek.Checked == true)
            {
                suma += (int)Dodatki.SosCzosnkowy;
                pods2.Text += Convert.ToString(sCzosnek.Text + "\n");
            }
            if (pCiasto.Checked == true)
            {
                suma += (int)Dodatki.PodwójneCiasto;
                pods2.Text += Convert.ToString(pCiasto.Text + "\n");
            }

            opcjeIndeks.Text = "Opcje dodatkowe: ";
            if (opakowanie.Checked == true)
            {
                suma += (int)OpcjeDodatkowe.Opakowanie;
                pods3.Text += Convert.ToString(opakowanie.Text + "\n");
            }
            if (sztucce.Checked == true)
            {
                suma += (int)OpcjeDodatkowe.Sztućce;
                pods3.Text += Convert.ToString(sztucce.Text + "\n");
            }
            if (cola.Checked == true)
            {
                suma += (int)OpcjeDodatkowe.CocaCola;
                pods3.Text += Convert.ToString(cola.Text + "\n");
            }
            if (woda.Checked == true)
            {
                suma += (int)OpcjeDodatkowe.Woda;
                pods3.Text += Convert.ToString(woda.Text + "\n");
            }
            if (kawa.Checked == true)
            {
                suma += (int)OpcjeDodatkowe.Kawa;
                pods3.Text += Convert.ToString(kawa.Text + "\n");
            }
            if (herbata.Checked == true)
            {
                suma += (int)OpcjeDodatkowe.Herbata;
                pods3.Text += Convert.ToString(herbata.Text + "\n");
            }
            if (rabat5.Checked == true)
            {
                rabatlbl.Text = "Rabat: 5%";
                suma *= 0.95;
            }else if (rabat10.Checked == true)
            {
                rabatlbl.Text = "Rabat: 10%";
                suma *= 0.90;
            }
            else if (rabat20.Checked == true)
            {
                rabatlbl.Text = "Rabat: 20%";
                suma *= 0.80;
            }
            else if (rabat30.Checked == true)
            {
                rabatlbl.Text = "Rabat: 30%";
                suma *= 0.70;
            }
            else if (rabat40.Checked == true)
            {
                rabatlbl.Text = "Rabat: 40%";
                suma *= 0.60;
            }
            doZaplatylbl.Text = Convert.ToString(suma) + " zł";
            suma = 0;
        }

        private void margarita_CheckedChanged(object sender, EventArgs e)
        {
            bianka.Checked = false;
        }

        private void bianka_CheckedChanged(object sender, EventArgs e)
        {
            margarita.Checked = false;
        }
    }
}
