using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INF04WPFPRACOWNIK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        String wynik = "";
        private void Generuj_Click(object sender, RoutedEventArgs e)
        {
            String wynik = "";
            String znakiRandom = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String znakiRandomMale = "abcdefghijklmnopqrstuvwxyz";
            String znakiRandomCyfry = "0123456789";
            String znakiRandomSpecjalne = "!@#$%^&*()_+-=[]{}|;':\",./<>?";

            String znakiDoWylosowania = "";
            Random random = new Random();
            if (int.TryParse(IloscZnakow.Text, out int IloscZnakowGit))
            {
                if (MaleiWielkie.IsChecked == true)
                {
                    znakiDoWylosowania += znakiRandom + znakiRandomMale;
                }
                if (Cyfry.IsChecked == true)
                {
                    znakiDoWylosowania += znakiRandomCyfry;
                }
                if (Specjalne.IsChecked == true)
                {
                    znakiDoWylosowania += znakiRandomSpecjalne;
                }
                for (int i = 0; i < IloscZnakowGit; i++)
                {
                    wynik += (char)znakiDoWylosowania[random.Next(znakiDoWylosowania.Length)];
                }
            MessageBox.Show(wynik);
            }
        }

        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Dane pracownika:" + Imie.Text + " " + Nazwisko.Text + " " + Stanowisko.Text + " Hasło: " + wynik
            );

        }
    }
}