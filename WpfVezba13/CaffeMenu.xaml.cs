using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfVezba13
{
    /// <summary>
    /// Interaction logic for CaffeMenu.xaml
    /// </summary>
    public partial class CaffeMenu : Window
    {
        private int Brojac1 = 0;  
        private int Brojac2 = 0; 
        private List<int> ListaCene = new List<int>();
        List<string> items = new List<string>();

        public CaffeMenu()
        {
            InitializeComponent();
        }

        private int Cekiranje(CheckBox cb, TextBox tb, int cena)
        {
            if (cb.IsChecked == true)
            {
                int kolicina;
                if (int.TryParse(tb.Text, out kolicina))
                {
                    cena *= kolicina;
                    ListaCene.Add(cena);
                    return kolicina;
                }
                else
                {
                    Brojac1++;
                    return 0;
                }
            }
            else
            {
                Brojac2++;
                return -1;
            }

        }
        private int Racun()
        {
            int rez = 0;
            for (int i = 0; i < ListaCene.Count; i++)
            {
                rez += ListaCene[i];
                if (i == ListaCene.Count - 1)
                {
                    //ListaCene.Clear();
                }
            }
            return rez;
        }
     
        private void Resetuj()
        {
            checkBoxKafa.IsChecked = false;
            checkBoxEspresso.IsChecked = false;
            checkBoxMachiato.IsChecked = false;
            checkBoxCappuchino.IsChecked = false;
            checkBoxLav.IsChecked = false;
            checkBoxJelen.IsChecked = false;
            checkBoxBeks.IsChecked = false;
            CheckBoxHainiken.IsChecked = false;
           
            textBoxKafa.Clear();
            textBoxEspresso.Clear();
            textBoxMachiato.Clear();
            textBoxCappuchino.Clear();
            textBoxLav.Clear();
            textBoxJelen.Clear();
            textBoxBeks.Clear();
            textBoxHainiken.Clear();
            //textBoxKafa.Text = "0";
            //textBoxEspresso.Text = "0";
            //textBoxMachiato.Text= "0";
            //textBoxCappuchino.Text ="0";
            //textBoxLav.Text = "0";
            //textBoxJelen.Text = "0";
            //textBoxBeks.Text = "0";
            //textBoxHainiken.Text = "0";


        }
        private void Resetuj1()
        {
            checkBoxKafa.IsChecked = false;
            checkBoxEspresso.IsChecked = false;
            checkBoxMachiato.IsChecked = false;
            checkBoxCappuchino.IsChecked = false;
            checkBoxLav.IsChecked = false;
            checkBoxJelen.IsChecked = false;
            checkBoxBeks.IsChecked = false;
            CheckBoxHainiken.IsChecked = false;

            textBoxKafa.Clear();
            textBoxEspresso.Clear();
            textBoxMachiato.Clear();
            textBoxCappuchino.Clear();
            textBoxLav.Clear();
            textBoxJelen.Clear();
            textBoxBeks.Clear();
            textBoxHainiken.Clear();
        }

       
        private void buttonNaruci_Click(object sender, RoutedEventArgs e)
        {
           
            int cenaKafa = 120, cenaEspres = 130, cenaMach = 130, cenaCapp = 140, cenaLav = 120, cenaJel = 120, cenaBeks = 140, cenaHain = 160;
         
            int kol1 = Cekiranje(checkBoxKafa, textBoxKafa, cenaKafa);
            int kol2 = Cekiranje(checkBoxEspresso, textBoxEspresso, cenaEspres);
            int kol3 = Cekiranje(checkBoxMachiato, textBoxMachiato, cenaMach);
            int kol4 = Cekiranje(checkBoxCappuchino, textBoxCappuchino, cenaCapp);
            int kol5 = Cekiranje(checkBoxLav, textBoxLav, cenaLav);
            int kol6 = Cekiranje(checkBoxJelen, textBoxJelen, cenaJel);
            int kol7 = Cekiranje(checkBoxBeks, textBoxBeks, cenaBeks);
            int kol8 = Cekiranje(CheckBoxHainiken, textBoxHainiken, cenaHain);
        
            double racun = Racun();
            double pdv = 1.2;

            double sum = racun * pdv;          
            if (racun > 0)
            {                            
                items.Add(textBoxPrikazi.Text + racun.ToString());
                textBoxPrikazi.Text = racun.ToString("C2");

                textBoxPDV.Clear();
                textBoxPDV.AppendText($"${sum}.00");
                textBoxPDV1.Clear();
                textBoxPDV1.AppendText($"Vas racun sa Pdv iznosi: ${sum}.00 dinara.\n");
            }
            else
            {            
                if (Brojac2 > 0 && Brojac1 == 0)
                {
                    MessageBox.Show("Niste izabrali pice", "Poruka");

                }
                if (Brojac1 > 0)
                {
                    MessageBox.Show("Niste uneli kolicinu", "Poruka");

                }
            }
            Resetuj1();           
        }

        private void buttonOtkazi_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxPrikazi.Text.Contains("$") && textBoxPDV1.Text.Contains("racun"))
            {
                MessageBox.Show("Niste platili racun", "Upozorenje");
            }
            else
            {
                MainWindow m1 = new MainWindow();
                Close();
                m1.ShowDialog();
            }
                  
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxPrikazi.Text.Contains("$") && textBoxPDV1.Text.Contains("racun"))
            {
                MessageBox.Show("Niste platili racun", "Upozorenje");
            }
            else
            {
                ListaCene.Clear();
                Resetuj();
                textBoxPrikazi.Clear();
            }

        }

        private void buttonPlati_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w1 = new MainWindow();

            if (textBoxPrikazi.Text.Length > 0 && textBoxPDV1.Text.Length > 0)
            {
                MessageBox.Show(textBoxPDV1.Text, "Poruka");
                ListaCene.Clear();
                textBoxPrikazi.Clear();
                textBoxPDV.Clear();
                textBoxPDV1.Clear();
                Resetuj();
                //Racun r1 = new Racun();
                //Close();
                //r1.ShowDialog(); 
            }
            else
            {               
                MessageBox.Show("Racun je prazan", "Poruka");
                return;              
            }
            Close();
            w1.textBlock1.Text = "Placeno";
            w1.ShowDialog();          
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {            
            //textBoxKafa.Text = "0";
            //textBoxEspresso.Text = "0";
            //textBoxMachiato.Text = "0";
            //textBoxCappuchino.Text = "0";
            //textBoxLav.Text = "0";
            //textBoxJelen.Text = "0";
            //textBoxBeks.Text = "0";
            //textBoxHainiken.Text = "0";
        }
    }
}
