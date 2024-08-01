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

namespace Адовые_рисунки__23
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Добавляем нужные нам элементы 
        Polygon polygon_b1 = new Polygon();
        Rectangle rectal = new Rectangle();
        Polygon polygon_b2 = new Polygon();
        Ellipse ellipse_o1 = new Ellipse();
        Ellipse ellipse_o2 = new Ellipse();
        Polygon polygon_t1 = new Polygon();
        Polygon polygon_g1 = new Polygon();
        Ellipse ellipse_o3 = new Ellipse();
        Ellipse ellipse_o4 = new Ellipse();
        Polygon polygon_h1 = new Polygon();
        Polygon polygon_a1 = new Polygon();
        Polygon polygon_a2 = new Polygon();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void IZO_Click(object sender, RoutedEventArgs e) //Рисуем
        {
            IZO.IsEnabled = false;
            //Создаём рамку
            rectal.Height = 600; rectal.Width = 900; //Задаём размер рамки
            rectal.Stroke = Brushes.DarkOrchid; //Задаём окрашивание границ
            rectal.Fill = Brushes.DarkSlateBlue; //Задаём цвет заливки
            canvas.Children.Add(rectal);
            Canvas.SetLeft(rectal, 4); //Отступ слева
            Canvas.SetTop(rectal, -120); //Отступ справа

            //Буква "Б"
            //Рисуем очертания "Б"
            polygon_b1.Stroke = Brushes.Aquamarine; //Задаём окрашивание границ
            polygon_b1.Fill = Brushes.MidnightBlue; //Задаём цвет заливки
            polygon_b1.StrokeThickness = 5; //Задаём размер границ
            polygon_b1.Points.Add(new Point(100, 100));
            polygon_b1.Points.Add(new Point(350, 100));
            polygon_b1.Points.Add(new Point(350, 150));
            polygon_b1.Points.Add(new Point(200, 150));
            polygon_b1.Points.Add(new Point(200, 200));
            polygon_b1.Points.Add(new Point(350, 200));
            polygon_b1.Points.Add(new Point(350, 350));
            polygon_b1.Points.Add(new Point(100, 350));
            canvas.Children.Add(polygon_b1);

            //Выбиваю с правого хука пузо у буквы "Б"
            polygon_b2.Stroke = Brushes.Aquamarine; //Задаём окрашивание границ
            polygon_b2.Fill = Brushes.DarkSlateBlue; //Задаём цвет заливки
            polygon_b2.StrokeThickness = 5; //Задаём размер границ
            polygon_b2.Points.Add(new Point(200, 250));
            polygon_b2.Points.Add(new Point(300, 250));
            polygon_b2.Points.Add(new Point(300, 300));
            polygon_b2.Points.Add(new Point(200, 300));
            canvas.Children.Add(polygon_b2);

            //Буква "О"
            //Рисуем первый эллипс, внешнюю часть
            ellipse_o1.Height = 200; //Высота
            ellipse_o1.Width = 200; //Ширина
            ellipse_o1.Fill = Brushes.MidnightBlue; //Задаём цвет заливки
            ellipse_o1.Stroke = Brushes.Aquamarine; //Задаём окрашивание границ
            ellipse_o1.StrokeThickness = 5; //Задаём размер границ
            canvas.Children.Add(ellipse_o1);
            Canvas.SetLeft(ellipse_o1, 400); //Отступ слева
            Canvas.SetTop(ellipse_o1, 200); //Отступ сверху

            //Рисуем второй эллипс, внутреннюю часть
            ellipse_o2.Height = 100; //Высота
            ellipse_o2.Width = 100; //Ширина
            ellipse_o2.Fill = Brushes.DarkSlateBlue; //Задаём цвет заливки
            ellipse_o2.Stroke = Brushes.Aquamarine; //Задаём окрашивание границ
            ellipse_o2.StrokeThickness = 5; //Задаём размер границ
            canvas.Children.Add(ellipse_o2);
            Canvas.SetLeft(ellipse_o2, 450); //Отступ слева
            Canvas.SetTop(ellipse_o2, 250); //Отступ справа

            //Буква "Т"
            polygon_t1.Stroke = Brushes.Aquamarine; //Задаём окрашивание границ
            polygon_t1.Fill = Brushes.MidnightBlue; //Задаём цвет заливки
            polygon_t1.StrokeThickness = 5; //Задаём размер границ
            canvas.Children.Add(polygon_t1);
            polygon_t1.Points.Add(new Point(600, 100));
            polygon_t1.Points.Add(new Point(850, 100));
            polygon_t1.Points.Add(new Point(850, 150));
            polygon_t1.Points.Add(new Point(750, 150));
            polygon_t1.Points.Add(new Point(750, 350));
            polygon_t1.Points.Add(new Point(700, 350));
            polygon_t1.Points.Add(new Point(700, 150));
            polygon_t1.Points.Add(new Point(600, 150));
        }

        private void Rospis_Click(object sender, RoutedEventArgs e) //Автограф
        {
            Rospis.IsEnabled = false;
            //Буква "Г"
            polygon_g1.Stroke = Brushes.Aquamarine; //Задаём окрашивание границ
            polygon_g1.Fill = Brushes.MidnightBlue; //Задаём цвет заливки
            polygon_g1.StrokeThickness = 5; //Задаём размер границ
            canvas.Children.Add(polygon_g1);
            polygon_g1.Points.Add(new Point(0, 100));
            polygon_g1.Points.Add(new Point(150, 100));
            polygon_g1.Points.Add(new Point(150, 150));
            polygon_g1.Points.Add(new Point(50, 150));
            polygon_g1.Points.Add(new Point(50, 400));
            polygon_g1.Points.Add(new Point(0, 400));
            
            //Буква "О" внешняя сторона
            ellipse_o3.Height = 200; //Высота
            ellipse_o3.Width = 200; //Ширина
            ellipse_o3.Fill = Brushes.Transparent; //Задаём цвет заливки
            ellipse_o3.Stroke = Brushes.Aquamarine; //Задаём окрашивание границ
            ellipse_o3.StrokeThickness = 5; //Задаём размер границ
            canvas.Children.Add(ellipse_o3);
            Canvas.SetLeft(ellipse_o3, 100); //Отступ слева
            Canvas.SetTop(ellipse_o3, 200); //Отступ справа

            //Буква "О" внутренняя сторона
            ellipse_o4.Height = 100; //Высота 
            ellipse_o4.Width = 100; //Ширина
            ellipse_o4.Fill = Brushes.Transparent; //Задаём цвет заливки
            ellipse_o4.Stroke = Brushes.Aquamarine; //Задаём окрашивание границ
            ellipse_o4.StrokeThickness = 5; //Задаём размер границ
            canvas.Children.Add(ellipse_o4);
            Canvas.SetLeft(ellipse_o4, 150); //Отступ слева
            Canvas.SetTop(ellipse_o4, 250); //Отступ справа

            //Буква "Ш"
            polygon_h1.Stroke = Brushes.Aquamarine; //Задаём окрашивание границ
            polygon_h1.Fill = Brushes.MidnightBlue; //Задаём цвет заливки
            polygon_h1.StrokeThickness = 5; //Задаём размер границ
            canvas.Children.Add(polygon_h1); 
            polygon_h1.Points.Add(new Point(350, 100));
            polygon_h1.Points.Add(new Point(400, 100));
            polygon_h1.Points.Add(new Point(400, 400));
            polygon_h1.Points.Add(new Point(450, 400));
            polygon_h1.Points.Add(new Point(450, 100));
            polygon_h1.Points.Add(new Point(500, 100));
            polygon_h1.Points.Add(new Point(500, 400));
            polygon_h1.Points.Add(new Point(550, 400));
            polygon_h1.Points.Add(new Point(550, 100));
            polygon_h1.Points.Add(new Point(600, 100));
            polygon_h1.Points.Add(new Point(600, 450));
            polygon_h1.Points.Add(new Point(350, 450));

            //Буква "А" внешняя сторона
            polygon_a1.Stroke = Brushes.Aquamarine; //Задаём окрашивание границ
            polygon_a1.Fill = Brushes.Transparent; //Задаём цвет заливки
            polygon_a1.StrokeThickness = 5; //Задаём размер границ
            canvas.Children.Add(polygon_a1);
            polygon_a1.Points.Add(new Point(750, 100));
            polygon_a1.Points.Add(new Point(575, 400));
            polygon_a1.Points.Add(new Point(650, 400));
            polygon_a1.Points.Add(new Point(700, 300));
            polygon_a1.Points.Add(new Point(800, 300));
            polygon_a1.Points.Add(new Point(850, 400));
            polygon_a1.Points.Add(new Point(925, 400));

            //Буква "А" внутренняя сторона
            polygon_a2.Stroke = Brushes.Aquamarine; //Задаём окрашивание границ
            polygon_a2.Fill = Brushes.Transparent; //Задаём цвет заливки
            polygon_a2.StrokeThickness = 5; //Задаём размер границ
            canvas.Children.Add(polygon_a2);
            polygon_a2.Points.Add(new Point(750, 200));
            polygon_a2.Points.Add(new Point(800, 250));
            polygon_a2.Points.Add(new Point(700, 250));
         


        }

        private void About_Click(object sender, RoutedEventArgs e) //Рассказываем чо там да как там
        {
            MessageBox.Show("Горе-художник Бирюков Георгий из ИСП-23. На данном уроке по рисованию мы с вами напишем слово *Бот* и ещё своё имя! А пока анекдот: Штирлиц гладил кота. Кот умер. -Странно- подумал Штирлиц и убрал утюг");
        }

        private void Clear_Click(object sender, RoutedEventArgs e) //Стираем произведение искусства
        {
            canvas.Children.Clear();
            IZO.IsEnabled = true;
            Rospis.IsEnabled = true;
        }

        private void Exit_Click(object sender, RoutedEventArgs e) //Выход с урока рисования
        {
            this.Close();
        }

        //Накидаем стиля
        private void DarkMagenta_Click(object sender, RoutedEventArgs e)
        {
            
            polygon_b1.Fill = Brushes.DarkMagenta;       
            polygon_b2.Fill = Brushes.DarkSlateBlue;
            ellipse_o1.Fill = Brushes.DarkMagenta;         
            ellipse_o2.Fill = Brushes.DarkSlateBlue;                  
            polygon_t1.Fill = Brushes.DarkMagenta;            
            polygon_g1.Fill = Brushes.DarkMagenta;
            ellipse_o3.Fill = Brushes.DarkMagenta;           
            ellipse_o4.Fill = Brushes.DarkMagenta;                       
            polygon_h1.Fill = Brushes.DarkMagenta;
            polygon_a1.Fill = Brushes.DarkMagenta;
            polygon_a2.Fill = Brushes.DarkMagenta;
        }
        private void Navy_Click(object sender, RoutedEventArgs e)
        {
            polygon_b1.Fill = Brushes.Navy;
            polygon_b2.Fill = Brushes.DarkSlateBlue;
            ellipse_o1.Fill = Brushes.Navy;
            ellipse_o2.Fill = Brushes.DarkSlateBlue;         
            polygon_t1.Fill = Brushes.Navy;
            polygon_g1.Fill = Brushes.Navy;
            ellipse_o3.Fill = Brushes.Navy;
            ellipse_o4.Fill = Brushes.Navy;
            polygon_h1.Fill = Brushes.Navy;
            polygon_a1.Fill = Brushes.Navy;
            polygon_a2.Fill = Brushes.Navy;
        }
        private void LightSeaGreen_Click(object sender, RoutedEventArgs e)
        {
            polygon_b1.Fill = Brushes.LightSeaGreen;
            polygon_b2.Fill = Brushes.DarkSlateBlue;
            ellipse_o1.Fill = Brushes.LightSeaGreen;
            ellipse_o2.Fill = Brushes.DarkSlateBlue;
            polygon_t1.Fill = Brushes.LightSeaGreen;
            polygon_g1.Fill = Brushes.LightSeaGreen;
            ellipse_o3.Fill = Brushes.LightSeaGreen;
            ellipse_o4.Fill = Brushes.LightSeaGreen;
            polygon_h1.Fill = Brushes.LightSeaGreen;
            polygon_a1.Fill = Brushes.LightSeaGreen;
            polygon_a2.Fill = Brushes.LightSeaGreen;

        }
        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            polygon_b1.Fill = Brushes.Yellow;
            polygon_b2.Fill = Brushes.DarkSlateBlue;
            ellipse_o1.Fill = Brushes.Yellow;
            ellipse_o2.Fill = Brushes.DarkSlateBlue;
            polygon_t1.Fill = Brushes.Yellow;
            polygon_g1.Fill = Brushes.Yellow;
            ellipse_o3.Fill = Brushes.Yellow;
            ellipse_o4.Fill = Brushes.Yellow;
            polygon_h1.Fill = Brushes.Yellow;
            polygon_a1.Fill = Brushes.Yellow;
            polygon_a2.Fill = Brushes.Yellow;
        }
        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            polygon_b1.Fill = Brushes.Blue;
            polygon_b2.Fill = Brushes.DarkSlateBlue;
            ellipse_o1.Fill = Brushes.Blue;
            ellipse_o2.Fill = Brushes.DarkSlateBlue;
            polygon_t1.Fill = Brushes.Blue;
            polygon_g1.Fill = Brushes.Blue;
            ellipse_o3.Fill = Brushes.Blue;
            ellipse_o4.Fill = Brushes.Blue;
            polygon_h1.Fill = Brushes.Blue;
            polygon_a1.Fill = Brushes.Blue;
            polygon_a2.Fill = Brushes.Blue;
        }
    }
}
