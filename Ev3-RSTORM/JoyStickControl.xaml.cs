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
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;

namespace Ev3_RSTORM
{
    /// <summary>
    /// Interaction logic for JoyStickControl.xaml
    /// </summary>
    public partial class JoyStickControl : Window
    {
        
        public JoyStickControl()
        {
            InitializeComponent();
        }

        

        

        private void button_backwards_Click(object sender, RoutedEventArgs e)
        {
            BatchCommand4();
        }

        

        private void button_right_Click(object sender, RoutedEventArgs e)
        {
            BatchCommand2();
        }

        

       

        

        private async void BatchCommand2()
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, 50, 1000, false);
            //            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, 50, 1000, false);
            //            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, 0, 1000, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, 0, 1000, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        

        private async void BatchCommand4()
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, -50, 1000, false);
            //            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, -50, 1000, false);
            //            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, -50, 1000, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, -50, 1000, false);
            await brick.BatchCommand.SendCommandAsync();
        }

    }
}
