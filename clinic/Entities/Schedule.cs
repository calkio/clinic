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


        public void AddRecordInDay(Record record)
        {
            var day = DefineDayInWeek(record);
            if (day.IsRecordNull(record.Time))
            {
                day.AddRecord(record.Time, record);
            }
        }

        private DaySchedule DefineDayInWeek(Record record)
        {
            return weekSchedule.First(x => x.DayName == record.MyDay);
        }
    }
}
