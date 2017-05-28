using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataTemplates_Bindings
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public PErson P { get; set; } = new PErson();
        public ObservableCollection<PErson> Persons { get; set; } = new ObservableCollection<PErson>();
        public string X { get; set; } = "23";
        public string X2 { get; set; } = "232";
        public MainPage()

        {
           
            for (int i = 0; i < 5; i++)
            {
                Persons.Add(new PErson() { Name = "MOdeka" + i });
            }
            this.InitializeComponent();
            DataContext = Persons;
        }


    }

    public class PErson
    {
        public string Name { get; set; }
        public int[] Numbers { get; set; } = { 1, 2, 3 };
    }
}
