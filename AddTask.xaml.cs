using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace examWPF
{
    /// <summary>
    /// Логика взаимодействия для AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        Task task =new Task();
        public AddTask()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            task.name = Name_.Text;
            task.FullTimeForTask = Convert.ToInt32(Time_.Text);
            this.Close();
        }
    }
}
