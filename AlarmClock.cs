using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    class AlarmClock
    {
        //Fält.
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        //Egenskaper.
        public int AlarmHour
        {
            get { return _alarmHour; }
            set { 
                    if (value > 23 || value < 0) 
                    {
                        throw new ArgumentException();
                    }
                _alarmHour = value; 
                }


        }
        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set {
                    if (value > 60 || value < 0)
                    {
                        throw new ArgumentException();
                    }
                _alarmMinute = value; 
                }
        }
        public int Hour
        {
            get { return _hour; }
            set {
                    if(value > 23 || value < 0)
                    {
                        throw new ArgumentException();
                    }
                 _hour = value; 
                }
        }
        public int Minute
        {
            get { return _minute; }
            set {
                    if(value < 0 || value > 60)
                    {
                        throw new ArgumentException();
                    }    
                _minute = value; 
                }
        }

        //Konstruktorer.
        public AlarmClock():this(0,0)
        {

        }

        public AlarmClock(int hour, int minute)
        {
        
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            alarmHour = _alarmHour;
            alarmMinute = _alarmMinute;
            hour = _hour;
            minute = _minute;
        }


        //Metoderna: TickTock och ToString.
        public bool TickTock()
        {
           
            if (_minute > 0 && _minute < 59)
            {
                _minute++;
            }
            else
            {
                _minute = 0;

                if(_hour > 1 && _hour < 23)
                {
                    _hour++;
                }
                else
                {
                    _hour = 0;
                }
            }
            if (_alarmHour == _hour && _alarmMinute == _minute)
            {
                return true;
            }
            
         return false;
        }


        public string ToString()
        {
            _hour = 8;
            _minute = 8;
            string ClockTest = String.Format("{0}:{1}", _hour,_minute);
            return ClockTest;
        }

    }    
}
