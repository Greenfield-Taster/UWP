using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Imaging;

namespace LIB14393
{
    public class AnimatedGif
    {
        public static void SetAutoPalyOff(BitmapImage BI)
        {
            if (ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 3)) 
            {
                BI.AutoPlay = false;    
            }
        }
    }
}
