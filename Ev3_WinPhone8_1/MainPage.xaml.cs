using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Ev3_WinPhone8_1.Resources;
using Lego.Ev3.Core;
using Lego.Ev3.Phone;

namespace Ev3_WinPhone8_1
{
    public partial class MainPage : PhoneApplicationPage
    {
        Brick brick = new Brick(new BluetoothCommunication());
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            brick.Ports[InputPort.Four].SetMode(InfraredMode.Proximity);
            brick.Ports[InputPort.Four].PercentValue = 50;
            if (true)
            {
                brick.BatchCommand.TurnMotorAtSpeed(OutputPort.B, 0);
                brick.BatchCommand.TurnMotorAtSpeed(OutputPort.C, 0);
                brick.BatchCommand.SendCommandAsync();
            } 
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        

        

        private async void button_go_Click(object sender, RoutedEventArgs e)
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, 35, 500, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, 35, 500, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        private async void button_left_Click(object sender, RoutedEventArgs e)
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, -35, 300, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, 35, 300, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        private async void button_right_Click(object sender, RoutedEventArgs e)
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, 35, 300, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, -35, 300, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        private async void button_back_Click(object sender, RoutedEventArgs e)
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, -35, 500, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, -35, 500, false);
            await brick.BatchCommand.SendCommandAsync();
        }





        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}