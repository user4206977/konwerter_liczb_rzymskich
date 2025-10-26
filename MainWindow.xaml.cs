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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace liczby_rzymskie
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Wypisz.Content = "";
            Wpisz.Text = "";
            RzymToArab.IsChecked = true;
        }

        private void Convert(object sender, RoutedEventArgs e)
        {

            if(RzymToArab.IsChecked == true)
            {
                Dictionary<string, int> romArabMap = new Dictionary<string, int>();
                romArabMap.Add("I", 1);
                romArabMap.Add("V", 5);
                romArabMap.Add("X", 10);
                romArabMap.Add("L", 50);
                romArabMap.Add("C", 100);
                romArabMap.Add("D", 500);
                romArabMap.Add("M", 1000);


                string rom = string.Concat(Wpisz.Text.ToUpper().Select(c => "IVXLCDM".Contains(c) ? c : ' ')).Replace(" ", "");
                Wpisz.Text = rom;

                int i = rom.Length - 1;
                int result = 0;
                int last = 0;
                int x = 0;

                while (i >= 0)
                {
                    x = romArabMap[rom[i].ToString()];
                    if (x >= last)
                    {
                        last = x;
                        result += x;
                    }
                    else
                    {
                        result -= x;
                    }
                    i--;
                }

                Wypisz.Content = result;
            } else
            {
                Dictionary<int, string> arabRomMap = new Dictionary<int, string>();
                arabRomMap.Add(1000, "M");
                arabRomMap.Add(900, "CM");
                arabRomMap.Add(500, "D");
                arabRomMap.Add(400, "CD");
                arabRomMap.Add(100, "C");
                arabRomMap.Add(90, "XC");
                arabRomMap.Add(50, "L");
                arabRomMap.Add(40, "XL");
                arabRomMap.Add(10, "X");
                arabRomMap.Add(9, "IX");
                arabRomMap.Add(5, "V");
                arabRomMap.Add(4, "IV");
                arabRomMap.Add(1, "I");


                string testString = Wpisz.Text;
                if (int.TryParse(testString, out int arab))
                {
                    string rom = "";

                    while (arab > 0 && arab < 3001)
                    {
                        foreach (var number in arabRomMap)
                        {
                            if (arab >= number.Key)
                            {
                                rom += number.Value;
                                arab -= number.Key;
                                break;
                            }
                        }
                    }

                    Wypisz.Content = rom;
                }
                else
                {
                    MessageBox.Show("Podaj tylko cyfry aby konwertowac na rzymskie!", "Ostrzerzenie", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            Wypisz.Content = "";
            Wpisz.Text = "";
        }

        private void RzymToArab_Checked(object sender, RoutedEventArgs e)
        {
            pole_wpisania.Header = "Podaj liczbę rzymską:";
            wynik_liczby.Header = "Liczba arabska:";
            Wypisz.Content = "";
            Wpisz.Text = "";
        }

        private void ArabToRzym_Checked(object sender, RoutedEventArgs e)
        {
            pole_wpisania.Header = "Podaj liczbę arabską:";
            wynik_liczby.Header = "Liczba rzymska:";
            Wypisz.Content = "";
            Wpisz.Text = "";
        }

        // projekt wykonał: MACIEJ STRZELEC
    }
}
