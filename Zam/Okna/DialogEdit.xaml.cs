using System;
using System.Windows;

namespace Zam.Okna
{
    /// <summary>
    /// Interakční logika pro DialogEdit.xaml
    /// </summary>
    public partial class DialogEdit : Window
    {
        public Zamestnanec Z { get; set; }
        public DialogEdit(Zamestnanec z)
        {
            Z = z;
            InitializeComponent();
            DataContext = Z;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {//Uložit

            Z.Jmeno = ProJmeno.Text;
            Z.Prijmeni = ProPrijmeni.Text;
            Z.DatumNarozeni = DateTime.Parse(ProDatum.Text);

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//Zahodit
            this.Close();
        }
    }
}
