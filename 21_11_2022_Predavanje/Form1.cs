using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_11_2022_Predavanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] nizBrojeva = { 10, 22, 3, 4, 53, 16, };
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0; i <= 10; i++)
                {
                    label1.Text += nizBrojeva[i] + "\n";
                }
            }
            catch(IndexOutOfRangeException)
            {
                label1.Text += "Otišao si predaleko...";
            }    
        }
//ZADATAK ZAPOSLENIK

        Zaposlenik[] zaposlenici = new Zaposlenik[5];
        int counter = 0;

        private void btn2SaveInput_Click(object sender, EventArgs e)
        {  
            try
            {
                zaposlenici[counter] = new Zaposlenik(int.Parse(txtNumber.Text), double.Parse(txtSallary.Text)); 

            }
            catch (FormatException)
            {
                lblShowReturn2.Text = "Krivi unos!";
                zaposlenici[counter] = new Zaposlenik(999, 17);
            }
            catch(NedozvoljenUnos nu)
            {
                lblShowReturn2.Text = nu.Message;
                zaposlenici[counter] = new Zaposlenik(int.Parse(txtNumber.Text), 17);
            } 
            counter++;
            txtNumber.Clear();
            txtNumber.Focus();
            txtSallary.Clear();
            
            if(counter == zaposlenici.Length)
            {
                txtNumber.Enabled = false;
                txtSallary.Enabled = false;
                lblShowReturn2.Text = "";
                Ispis(zaposlenici);
            }
        }
        void Ispis(params Zaposlenik[] zaposlenici)
        {
            for (int i = 0; i < zaposlenici.Length; i++)
                lblShowReturn2.Text += $"Broj zaposlenika: {zaposlenici[i].BrojZaposlenika} - plaća po satu: {zaposlenici[i].PlacaZaposlenika:C} \n";
        }
    }
}
