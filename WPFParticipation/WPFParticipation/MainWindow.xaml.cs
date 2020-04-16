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

namespace WPFParticipation
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

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            string Name, FavColor;
            Name = TxtName.Text;
            FavColor = TxtColor.Text;

            if (FavColor == "emerald green")
            {
                MessageBox.Show($"Guess what! We have the same very specific favorite color!");
            }
            else
            {
                MessageBox.Show($"{Name} that is really cool, I never would have expected your favorite color to be {FavColor}");
            }
        }
    }
   
}
