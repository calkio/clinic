using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Entities
{
    internal class Schedule
    {
        private List<DaySchedule> weekSchedule = new List<DaySchedule>
        {
            new DaySchedule("Понедельник"),
            new DaySchedule("Вторник"),   
            new DaySchedule("Среда"),   
            new DaySchedule("Четверг"),   
            new DaySchedule("Пятница"),   
            new DaySchedule("Суббота"),
            new DaySchedule("Воскресенье")
        };

        public List<string> GetFreeTimeForDayWeek(string selectedDayWeek)
        {
            DaySchedule dayWeek = DefineDayInWeek(selectedDayWeek);
            return dayWeek.GetFreeTime();
        }

        public void AddRecordInDay(Record record)
        {
            DaySchedule dayWeek = DefineDayInWeek(record);

            if (dayWeek.IsRecordNull(record.Time))
            {
                dayWeek.AddRecord(record.Time, record);
            }
        }

        private DaySchedule DefineDayInWeek(Record record)
        {
            return weekSchedule.First(x => x.DayName == record.MyDay);
        }

        private DaySchedule DefineDayInWeek(string selectedDayWeek)
        {
            return weekSchedule.First(x => x.DayName == selectedDayWeek);
        }
    }
}
