using Microsoft.Win32;
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

namespace Maps_Ready
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ellipse ellipse;
        Point point;
        bool IsDrawing = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadImge_Click(object sender, RoutedEventArgs e)                              //Подгружаем картинку
        {
            string s = "";
            var dialog = new OpenFileDialog();
            dialog.Filter = "Картинки(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF" + "|Все файлы (*.*)|*.* ";
            if(dialog.ShowDialog() == true)
            {
                s = dialog.FileName;
            }
            textBox.Text = @s; //временная проверка
            image.Source = new BitmapImage(new Uri(@s));
        }
        

        private void Target_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            point = e.GetPosition(Target);
            
            ellipse = new Ellipse();
            ellipse.Stroke = System.Windows.Media.Brushes.Red;
            ellipse.HorizontalAlignment = HorizontalAlignment.Left;
            ellipse.VerticalAlignment = VerticalAlignment.Center;
            ellipse.Width = 50;
            ellipse.Height = 75;
            
            Target.Children.Add(ellipse);
            
        }
    }
}
