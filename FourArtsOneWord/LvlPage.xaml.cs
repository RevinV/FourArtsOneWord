using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FourArtsOneWord
{
    /// <summary>
    /// Логика взаимодействия для LevelOne.xaml
    /// </summary>
    public partial class LevelPage : Window
    {
        //public static LevelPage lvl1;
        public string keyWord;
        public LevelPage()
        {
            //string keyWord="конь";
            //lvl1 = this;
            InitializeComponent();
            //Random random = new Random();
            //List<char> words = new List<char>();
            //for (int i = 0; i < 5; i++)
            //{
            //    words.Add((char)random.Next('а', 'я' + 1));
            //}
            //for (int i = 0; i < keyWord.Length; i++)
            //{
            //    words.Add(keyWord[i]);
            //}
            //List<char> randWords = new List<char>();
            //while (words.Count != 0)
            //{
            //    int rand = random.Next(0, words.Count);
            //    randWords.Add(words[rand]);
            //    words.RemoveAt(rand);
            //}
            ////List<char> chosenWords = new List<char>();
            //foreach (char word in randWords)
            //{
            //    Button button = new Button();
            //    button.Content = word;
            //    button.Height = 30;
            //    button.Width = 30;
            //    button.Click += (object sender, RoutedEventArgs e) => Answer.Text += word; //PrintWord(word);
            //    WordsPlace.Children.Add(button);
            //}


        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            if (keyWord == Answer.Text)
            {
                MessageBox.Show("Вин кондишн из май традишн, йоу!!!");
            }
            else
            {
                MessageBox.Show("try again!");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Answer.Text = "";
        }
    }
}
