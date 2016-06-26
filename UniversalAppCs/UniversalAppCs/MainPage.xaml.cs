using System;
using System.Collections.Generic;
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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UniversalAppCs
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

        private async void btnHelloWorld_Click(object sender, RoutedEventArgs e)
        {
            txtHelloWorld.Text = "Windows Universal App, Hello World.";

            MessageDialog message = new MessageDialog("Windows Universal App with C#, Like it ? ");
            message.Title = "Hello World";
            message.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            message.Commands.Add(new UICommand { Label = "No", Id = 1 });

            await message.ShowAsync();
        }
    }
}
