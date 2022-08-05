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
using cs_Motor_RS485.Views;
using cs_Motor_RS485;

namespace cs_Motor_RS485
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeSubComponent();
        }

        

        private void InitializeSubComponent()
        {
            Views.Motor_connection motor_Connection = new Views.Motor_connection();
            Views.Button brake = new Views.Button();
            Motor_Connection_GroupBox.Content = motor_Connection;
            Brake_GroupBox.Content = brake;
        }
    }
}
