using System;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;
using Image = Windows.UI.Xaml.Controls.Image;

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

            /*Browser********************************************************/

            //Browser.Navigate(new Uri("http://www.pearson.com"));
            //Browser.NavigateToString("<center>My HTML</center>");
            //var Point = new Geopoint(new BasicGeoposition()
            //{
            //    Latitude = 45.4215,
            //    Longitude = -75.6972
            //});

            //Map.Center = Point;

            //MapControl.SetLocation(TickMark, Point);

            //MapControl.SetNormalizedAnchorPoint(TickMark, new Windows.Foundation.Point(0.5, 0.5));

            /**Image or gif*******************************************************/

            //var BI = new BitmapImage(new Uri("ms-appx:///earth.gif"));

            //LIB14393.AnimatedGif.SetAutoPalyOff(BI);

            //var Image = new Image();
            //Image.Source = BI;
            //this.Content = Image;

            /****Work with textblock*****************************************************/

            //var G = new Grid()
            //{
            //    Background = new SolidColorBrush(Windows.UI.Colors.Blue),
            //};
            //var TB = new TextBlock()
            //{
            //    FontSize = 50,
            //};
            //var R = Windows.UI.Xaml.Documents.Run()
            //    {
            //        Text = "Hello, World!"
            //    };
           
            //TB.Inlines.Add(R);
            //G.Children.Add(TB);
            //this.Content = G;
        }
       /*Button click********************************************************/


        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            //---------------- Клик на кнопку и показывает текст с файла Help---------------
            //var Folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            //var File = await Folder.GetFileAsync("Help.txt");
            //Task.Delay(3000).Wait(); // Задержка показывания текста 
            //var Text = await FileIO.ReadTextAsync(File);
            //Result.Text = Text;

            //-------Click to button are pick image--------
            //var picker = new FileOpenPicker();
            //picker.ViewMode = PickerViewMode.Thumbnail;
            //picker.SuggestedStartLocation = PickerLocationId.Downloads;
            //picker.FileTypeFilter.Add(".jpg");
            //picker.FileTypeFilter.Add(".jpeg");
            //picker.FileTypeFilter.Add(".png");

            //var file = await picker.PickSingleFileAsync();

            //var stream = await file.OpenReadAsync();
            //var image = new BitmapImage();
            //image.SetSource(stream);
            //Pic.Source = image;

            //-------Click to the folder and all pictures is added to the control-----
            var picker = new FolderPicker();
            picker.SuggestedStartLocation = PickerLocationId.Downloads;
            picker.FileTypeFilter.Add("*");

            var folder = await picker.PickSingleFolderAsync();

            var files = await folder.GetFilesAsync();

            foreach ( var file in files) 
            {
                await Task.Delay(2000);
                using (var stream = await file.OpenReadAsync())
                {
                    var bi = new BitmapImage();
                    bi.SetSource(stream);

                    var image = new Image()
                    {
                        Width = 200,
                        Height = 200,
                    };
                    image.Source = bi;

                    ControlPanel.Children.Add(image);
                }
            }
        }
    }
}
