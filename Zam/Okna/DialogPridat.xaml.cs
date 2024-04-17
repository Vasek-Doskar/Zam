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

namespace Zam.Okna
{
    /// <summary>
    /// Interakční logika pro DialogPridat.xaml
    /// </summary>
    public partial class DialogPridat : Window
    {
        List<Zamestnanec> _zamestnanci;
        public DialogPridat(List<Zamestnanec> zamestnanci)
        {
            _zamestnanci = zamestnanci;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private int VytvorId() => _zamestnanci.Count + 1;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string jmeno = ProJmeno.Text;
            string prijmeni = ProJPrijemni.Text;
            DateTime narozeni = DateTime.Parse(ProDatum.Text);

            Zamestnanec Novy = new Zamestnanec(VytvorId(), jmeno, prijmeni, narozeni);
            _zamestnanci.Add(Novy);

            this.Close();
        }
    }
}
