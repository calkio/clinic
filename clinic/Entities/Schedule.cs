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
            if (_checkRecord) AddRecord(record);
            else Console.WriteLine("Это время занято");
        }

        private List<Record> PickDay(Record record)
        {
            switch (record.SelectDay)
            {
                case "Понедельник":
                    return _monday;
                case "Вторник":
                    return _tuesday;
                case "Среда":
                    return _wednesday;
                case "Четверг":
                    return _thursday;
                case "Пятница":
                    return _friday;
                case "Суббота":
                    return _saturday;
                case "Воскресенье":
                    return _sunday;
                default:
                    throw new NotImplementedException();
            }
        }

        #region ДОБАВЛЕНИЕ ЗАПИСИ

        private void AddRecord(Record record)
        {
            PickDay(record).Add(record);
        } 

        #endregion

        #region ПРОВЕРКА НА СВОБОДНУЮ ЗАПИСЬ

        private bool IsFreeRecord(Record record)
        {
            foreach (var item in PickDay(record))
            {
                if (item.Time == record.Time) return false;
            }
            return true;
        } 

        #endregion

        public void ShowEntry()
        {

        }
    }
}
