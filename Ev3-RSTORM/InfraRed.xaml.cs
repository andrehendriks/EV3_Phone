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
    /// Interaction logic for InfraRed.xaml
    /// </summary>
    public partial class InfraRed : UserControl
    {
        Brick brick = new Brick(new BluetoothCommunication("COM46")); 
        public InfraRed()
        {
            
            Infrared0();
            InitializeComponent();
        }

        

        private async void Infrared0()
        {
            brick.Ports[InputPort.Four].SetMode(InfraredMode.Proximity);


            brick.Ports[InputPort.Four].PercentValue = 35;
            if (true)
            {
                brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, 0, 5000, false);
                brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, 0, 5000, false);
                await brick.BatchCommand.SendCommandAsync();
            }
            
        }
    }
}
