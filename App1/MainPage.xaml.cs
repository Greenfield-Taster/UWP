using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace App1
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //var BI = new BitmapImage(new Uri("ms-appx:///earth.gif"));

            //LIB14393.AnimatedGif.SetAutoPalyOff(BI);

            //var Image = new Image();
            //Image.Source = BI;
            //this.Content = Image;

            /*********************************************************/

            var G = new Grid()
            {
                Background = new SolidColorBrush(Windows.UI.Colors.Blue),
            };
            var TB = new TextBlock()
            {
                FontSize = 50,
            };
            var R = Windows.UI.Xaml.Documents.Run()
                {
                    Text = "Hello, World!"
                };
           
            TB.Inlines.Add(R);
            G.Children.Add(TB);
            this.Content = G;
        }
    }
}
