using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Digital_Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockDisplay clock = new ClockDisplay();
            Console.WriteLine(clock.displayString);

            while(true)
            {
                clock.Timetick();
                Console.WriteLine(clock.displayString);
                Thread.Sleep(1000);
            }

            Console.ReadLine();
        }
    }

    class NumberDisplay
    {
        private int limit;
        private int value;

        public NumberDisplay(int rolloverlimit)
        {
            limit = rolloverlimit;
            value = 0;
        }

        public void Increment()
        {
            value++;
            value = value % limit;
        }

        public string GetDisplayValue()
        {
            if (value < 10)
                return "0" + value;
            else
                return value.ToString();
        }

        public void SetValue(int replacementValue)
        {
            if (replacementValue >= 0 && replacementValue < limit)
                value = replacementValue;
        }

        public int GetValue()
        {
            return value;
        }
    }

    class ClockDisplay
    {
        NumberDisplay hours;
        NumberDisplay minutes;
        NumberDisplay seconds;
        public string displayString;

        public ClockDisplay()
        {
            hours = new NumberDisplay(24);
            minutes = new NumberDisplay(60);
            seconds = new NumberDisplay(60);
            updateDisplay();
        }

        public ClockDisplay(int hour, int minute, int second)
        {
            hours = new NumberDisplay(hour);
            minutes = new NumberDisplay(minute);
            seconds = new NumberDisplay(second);
            SetTime(hour, minute, second);
        }

        void SetTime(int hour, int minute, int second)
        {
            hours.SetValue(hour);
            minutes.SetValue(minute);
            seconds.SetValue(second);
        }

        void updateDisplay()
        {
            displayString = hours.GetDisplayValue() + ":" + minutes.GetDisplayValue() + ":" + seconds.GetDisplayValue();
        }

        public void Timetick()
        {
            seconds.Increment();
            if (seconds.GetValue() == 0)
            {
                minutes.Increment();
                if (minutes.GetValue() == 0)
                    hours.Increment();
            }

            updateDisplay();

            // Thread.Sleep(1000); // wait for 1 second
        }
    }
}
