using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examWPF
{
    internal class TaskList
    {
        ObservableCollection<Task> Tasks = null;

        public TaskList()
        {
            Tasks = new ObservableCollection<Task>();
        }

        public void AddTask()
        {
            Tasks.Add(new Task( ) );
        } 

    }
}
