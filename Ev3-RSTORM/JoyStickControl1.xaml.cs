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
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;


namespace Ev3_RSTORM
{
    /// <summary>
    /// Interaction logic for JoyStickControl1.xaml
    /// </summary>
    public partial class JoyStickControl1 : UserControl
    {
        Brick brick = new Brick(new BluetoothCommunication("COM46"));
        public JoyStickControl1()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, RoutedEventArgs e)
        {
            async1();
        }

        private void async1()
        {
            brick.ConnectAsync();
        }

        private void btn_forwards_Click(object sender, RoutedEventArgs e)
        {
            BatchCommand0();
        }

        private async void BatchCommand0()
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, 50, 5000, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, 50, 5000, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        private void btn_left_Click(object sender, RoutedEventArgs e)
        {
            BatchCommand3();
        }

        private async void BatchCommand3()
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, 0, 1800, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, 50, 1800, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        private void btn_right_Click(object sender, RoutedEventArgs e)
        {
            BatchCommand2();
        }

        private async void BatchCommand2()
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, 50, 1800, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, 0, 1800, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        private void btn_backwards_Click(object sender, RoutedEventArgs e)
        {
            BatchCommand4();
        }

        private async void BatchCommand4()
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, -50, 5000, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, -50, 5000, false);
            await brick.BatchCommand.SendCommandAsync();
        }
    }
}
