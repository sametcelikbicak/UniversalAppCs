using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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
            
           var res= await message.ShowAsync();


            if ((int)res.Id == 0)
            {
                MessageDialog msg = new MessageDialog("Thank you very much :) ");
                msg.Title = "Thanks";
                msg.Commands.Add(new UICommand { Label = "Ok", Id = 0 });
                await msg.ShowAsync();
            }

        }
    }
}
