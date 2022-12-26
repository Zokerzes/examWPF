using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace examWPF
{
    public class Task
    {
        string _name;
        public string name
        {
            get { return _name; }
            set { if (_name == null) _name = value; }
        }

        int _fullTimeForTask;

        public int FullTimeForTask {get{ return _fullTimeForTask; } set{ _fullTimeForTask = value; } }

        DateTime _timeStart;
        public DateTime TimeStart {
            get 
            { 
                return _timeStart = DateTime.Now; 
            }
            set
            {
                _timeStart = value;
            }
        }

        DateTime _timeEnd;
        public DateTime TimeEnd {
            get
            {
                if (_status == true)
                {
                    return _timeEnd = _timeStart.AddMinutes(FullTimeForTask);
                }
                return _timeStart;
            }
        }

        DateTime _timeTaskPlan;
        public DateTime TimeTaskPlan
        {
            get
            {
               return _timeTaskPlan ;
            }
            set
            {
                _timeTaskPlan = value;
            }
        }

        TimeSpan _timeTask;
        public TimeSpan TimeTask
        {
            get
            {
                _timeTask = DateTime.Now - _timeStart;
                return _timeTask;
            }
            set
            {
                _timeTask = value;
            }
        }

        bool _status;
        public bool status { get { return _status; } set { _status = value; } }

        public Task()
        {
            this._name = name;
            this._timeTaskPlan = TimeTaskPlan;
            this.TimeStart = DateTime.Now;
            this._status = false;
        }

        public void nowTimeTask()
        {
            TimeTask = DateTime.Now - _timeStart;
        }
    }
}
