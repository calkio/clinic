using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Schedule
    {
        private List<DaySchedule> weekSchedule = new List<DaySchedule>
        {
            new DaySchedule(1),
            new DaySchedule(2),   
            new DaySchedule(3),   
            new DaySchedule(4),   
            new DaySchedule(5),   
            new DaySchedule(6),
            new DaySchedule(7)
        };

        public List<string> GetFreeTimeForDayWeek(int selectedDayWeek)
        {
            DaySchedule dayWeek = DefineDayInWeek(selectedDayWeek);
            return dayWeek.GetFreeTime();
        }

        public void AddRecordInDay(Record record)
        {
            DaySchedule dayWeek = DefineDayInWeek(record);

            if (dayWeek.IsFreeTime(record.Time))
            {
                dayWeek.AddRecord(record.Time, record);
            }
        }

        private DaySchedule DefineDayInWeek(Record record)
        {
            return weekSchedule.First(x => x.DayNumber == record.MyDay);
        }

        private DaySchedule DefineDayInWeek(int selectedDayWeek)
        {
            return weekSchedule.First(x => x.DayNumber == selectedDayWeek);
        }
    }
}
