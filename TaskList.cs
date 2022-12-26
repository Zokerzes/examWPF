using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace examWPF
{
    internal class TaskList
    {
        List<Task> Tasks = null;

        public TaskList()
        {
            Tasks = new List<Task>();
        }

        public void AddTask()
        {
            Tasks.Add(new Task( ) );
        }

        Timer timer = new Timer();

      
    }
}
