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

            int i = 1;
            foreach(Level level in LvlManager.GetLevels())
            {
                Button button = new Button();
                button.Content = "Уровень " + (i++);
                button.Height = 30;
                button.Click += (object sender, RoutedEventArgs e) => { LvlManager.createLvlPage(level).Show(); this.Close(); };
                LevelsPlace.Children.Add(button);
            }
        }

        
    }
}
