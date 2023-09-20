using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Entities
{
    internal class Schedule
    {
        Day _day;
        List<Record> _monday = new List<Record>(13);
        List<Record> _tuesday = new List<Record>(13);
        List<Record> _wednesday = new List<Record>(13);
        List<Record> _thursday = new List<Record>(13);
        List<Record> _friday = new List<Record>(13);
        List<Record> _saturday = new List<Record>(13);
        List<Record> _sunday = new List<Record>(13);
        Doctor _doctor;
        bool _checkRecord;


        public void UpdateSchedule(Record record)
        {
            _checkRecord = IsFreeRecord(record);
        }

        #region ПРОВЕРКА НА СВОБОДНУЮ ЗАПИСЬ

        private bool IsFreeRecord(Record record)
        {
            switch (record.SelectDay)
            {
                case "Понедельник":
                    return IsFreeTime(_monday, record.Time);
                case "Вторник":
                    return IsFreeTime(_tuesday, record.Time);
                case "Среда":
                    return IsFreeTime(_wednesday, record.Time);
                case "Четверг":
                    return IsFreeTime(_thursday, record.Time);
                case "Пятница":
                    return IsFreeTime(_friday, record.Time);
                case "Суббота":
                    return IsFreeTime(_saturday, record.Time);
                case "Воскресенье":
                    return IsFreeTime(_sunday, record.Time);
                default:
                    return false;
            }
        }

        private bool IsFreeTime(List<Record> list, int? selectedTime)
        {
            if (list.Count == 0)
            {
                for (int i = 0; i < 13; i++)
                {
                    list.Add(new Record());
                }
            }

            foreach (var item in list)
            {
                if (item.Time == selectedTime) return false;
            }
            return true;
        } 

        #endregion

        public void ChangeEntry()
        {

        }

        public void ShowEntry()
        {

        }
    }
}
