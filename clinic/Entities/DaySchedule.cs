using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Entities
{
    internal class DaySchedule
    {
        public int DayNumber { get; }

        private Dictionary<int, Record> timeReceipt = new Dictionary<int, Record>()
        {
            { 8, null},
            { 9, null},
            { 10, null},
            { 11, null},
            { 12, null},
            { 13, null},
            { 14, null},
            { 15, null},
            { 16, null},
            { 17, null},
            { 18, null},
            { 19, null},
            { 20, null},
        };

        public DaySchedule(int dayNumber)
        {
            DayNumber = dayNumber;
        }



        public void AddRecord(int time, Record record)
        {
            timeReceipt[time] = record;
        }

        public bool IsFreeTime(int time)
        {
            if (timeReceipt[time] == null) return true;
            return false;
        }


        public List<string> GetFreeTime()
        {
            return timeReceipt.
                   Where(x => x.Value == null).
                   Select(x => x.Key.ToString()).
                   ToList();
        }

    }
}
