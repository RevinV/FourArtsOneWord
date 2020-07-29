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

namespace FourArtsOneWord
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow startWindow;
        public MainWindow()
        {
            startWindow = this;
            InitializeComponent();
            

            

        }

        private void Lvl1_Click(object sender, RoutedEventArgs e)
        {
            LevelOne lvl1 = new LevelOne();
            this.Close();
            LevelOne.lvl1.Show();
        }
    }
}
