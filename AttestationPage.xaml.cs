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

namespace Attestation
{
    /// <summary>
    /// Логика взаимодействия для AttestationPage.xaml
    /// </summary>
    public partial class AttestationPage : Page
    {
        public AttestationPage()
        {
            InitializeComponent();
        }

        private void DataGridMain_Loaded(object sender, RoutedEventArgs e)
        {
            List<RowTab> result = new List<RowTab>();
            for(int i=0; i < 25; i++) {
                bool c = false;
                if (i % 2 == 0) c = true;
                result.Add(new RowTab(i+1, c, (88345634+i).ToString() ,(float)(i+0.5), (float)(i + 1.5), (float)(i + 2.5)));
            }
            DataGridMain.ItemsSource = result;

            
        }
    }
}
