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

        public AlarmClock(int hour, int minute):this(hour,minute,0,0)
        {
        
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
            Hour = hour;
            Minute = minute;
        }


        //Metoderna: TickTock och ToString.
        public bool TickTock()
        {
            
            if (_minute < 59)
            {
                _minute++;   
            }
               
            else
            {
                _minute = 0;

                if(_hour < 23)
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
          
            string ClockTest = String.Format("{0, 4}:{1:D2} <{2}:{3:D2}>", _hour,_minute, _alarmHour, _alarmMinute);

            return ClockTest;
        }

    }    
}
