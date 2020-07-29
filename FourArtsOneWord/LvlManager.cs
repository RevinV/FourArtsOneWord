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
    static class LvlManager
    {
        
        public static List<Level> GetLevels()
        {
            List<Level> levels = new List<Level>();
            levels.Add(new Level {keyWord="конь", art1= @"C:\Users\acer\Desktop\Картинки\лвл1\1.jpg", art2 = @"C:\Users\acer\Desktop\Картинки\лвл1\2.jpg", art3 = @"C:\Users\acer\Desktop\Картинки\лвл1\3.jpg", art4 = @"C:\Users\acer\Desktop\Картинки\лвл1\4.jpg" });
            levels.Add(new Level {keyWord="конь", art1= @"C:\Users\acer\Desktop\Картинки\лвл1\1.jpg", art2 = @"C:\Users\acer\Desktop\Картинки\лвл1\2.jpg", art3 = @"C:\Users\acer\Desktop\Картинки\лвл1\3.jpg", art4 = @"C:\Users\acer\Desktop\Картинки\лвл1\4.jpg" });
            levels.Add(new Level {keyWord="конь", art1= @"C:\Users\acer\Desktop\Картинки\лвл1\1.jpg", art2 = @"C:\Users\acer\Desktop\Картинки\лвл1\2.jpg", art3 = @"C:\Users\acer\Desktop\Картинки\лвл1\3.jpg", art4 = @"C:\Users\acer\Desktop\Картинки\лвл1\4.jpg" });
            levels.Add(new Level {keyWord="конь", art1= @"C:\Users\acer\Desktop\Картинки\лвл1\1.jpg", art2 = @"C:\Users\acer\Desktop\Картинки\лвл1\2.jpg", art3 = @"C:\Users\acer\Desktop\Картинки\лвл1\3.jpg", art4 = @"C:\Users\acer\Desktop\Картинки\лвл1\4.jpg" });
            levels.Add(new Level {keyWord="конь", art1= @"C:\Users\acer\Desktop\Картинки\лвл1\1.jpg", art2 = @"C:\Users\acer\Desktop\Картинки\лвл1\2.jpg", art3 = @"C:\Users\acer\Desktop\Картинки\лвл1\3.jpg", art4 = @"C:\Users\acer\Desktop\Картинки\лвл1\4.jpg" });
            return levels;
        }
        public static int CountLevels()
        {
            return GetLevels().Count;
        }
        public static LevelPage createLvlPage(Level level)
        {
            
            LevelPage newLevelPage = new LevelPage();
            newLevelPage.keyWord = level.keyWord;
            Random random = new Random();
            List<char> words = new List<char>();
            for (int i = 0; i < 5; i++)
            {
                words.Add((char)random.Next('а', 'я' + 1));
            }
            for (int i = 0; i < level.keyWord.Length; i++)
            {
                words.Add(level.keyWord[i]);
            }
            List<char> randWords = new List<char>();
            while (words.Count != 0)
            {
                int rand = random.Next(0, words.Count);
                randWords.Add(words[rand]);
                words.RemoveAt(rand);
            }
            //List<char> chosenWords = new List<char>();
            foreach (char word in randWords)
            {
                Button button = new Button();
                button.Content = word;
                button.Height = 30;
                button.Width = 30;
                button.Click += (object sender, RoutedEventArgs e) => newLevelPage.Answer.Text += word;
                newLevelPage.WordsPlace.Children.Add(button);
            }
            newLevelPage.Art1.Source = BitmapFrame.Create(new Uri(level.art1));
            newLevelPage.Art2.Source = BitmapFrame.Create(new Uri(level.art2));
            newLevelPage.Art3.Source = BitmapFrame.Create(new Uri(level.art3));
            newLevelPage.Art4.Source = BitmapFrame.Create(new Uri(level.art4));
            return newLevelPage;
        }
    }
}
