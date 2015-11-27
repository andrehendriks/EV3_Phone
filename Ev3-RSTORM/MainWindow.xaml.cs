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
using System.Windows.Shapes;
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;

namespace Ev3_RSTORM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brick brick = new Brick(new BluetoothCommunication("COM46"));
        public MainWindow()
        {
            brick.BrickChanged += Brick_BrickChanged;
            JoyStickControl1 joystick = new JoyStickControl1();
            InitializeComponent();
        }

        private void Brick_BrickChanged(object sender, BrickChangedEventArgs e)
        {
            brick.Ports[InputPort.Four].SetMode(InfraredMode.Proximity);
            Console.WriteLine(brick.Ports[InputPort.Four].SIValue);
            brick.DirectCommand.PlayToneAsync(20, 442, 1000);
        }
    }
}
