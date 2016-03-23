using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaviSoft.Wpf.ErrorDemo.Model
{
    public class Counter : ModelBase
    {
        private int _alarmCount;
        public int AlarmCount
        {
            get { return _alarmCount; }
            set
            {
                if(_alarmCount != value)
                {
                    _alarmCount = value;
                    OnPropertyChanged("AlarmCount");
                    OnPropertyChanged("TotalCount");
                }
            }
        }

        private int _messageCount;
        public int MessageCount
        {
            get { return _messageCount; }
            set
            {
                if(_messageCount != value)
                {
                    _messageCount = value;
                    OnPropertyChanged("MessageCount");
                    OnPropertyChanged("TotalCount");
                }
            }
        }

        public int TotalCount
        {
            get { return AlarmCount + MessageCount; }
        }

       
    }
}
