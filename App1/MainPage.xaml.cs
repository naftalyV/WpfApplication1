using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void CamBtn_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI cam = new CameraCaptureUI();

            cam.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Png;
            cam.PhotoSettings.MaxResolution = CameraCaptureUIMaxPhotoResolution.HighestAvailable;
            // cam.PhotoSettings.CroppedAspectRatio = new Size(400, 400);
            //cam.PhotoSettings.
            cam.PhotoSettings.CroppedSizeInPixels = new Size(400, 400);
            StorageFile file = await cam.CaptureFileAsync(CameraCaptureUIMode.Photo);

            ImagePath.Text = file.Path;


            MainImg.Source = new BitmapImage(new Uri(file.Path));
        }
    }
}
