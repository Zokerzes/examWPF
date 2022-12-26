using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace examWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string name_;
        string timerelise_;
        //Task Task = new Task();
        //TaskList taskList = new TaskList();
        
        public MainWindow()
        {
            InitializeComponent();
            TaskList taskList = new TaskList();
        }
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            
            AddTask addTask = new AddTask();
            addTask.ShowDialog();
            name_ = addTask.Name_.Text;
            timerelise_ = addTask.Time_.Text;
            taskList.AddTask();
        }

    }
}
