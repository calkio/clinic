using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Entities
{
    internal class Schedule
    {
        // Хотели сделать реализацию: 
        // Перенести все листы в класс Day, чтобы вызывать экземпляр дня, но хз как проверять dict
        List<Day> _day = new List<Day>(7);
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

        public void ShowEntry(Record record)
        {
            InciliationDayList();

            foreach (var time in _day[PickIndexDay(record)].TimeReceipt)
            {
                if (!time.Value) Console.WriteLine(time.Key + "\t" + "Это время свободно");
            }
        }

        #region ОБЩИЕ МЕТОДЫ

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


        private int PickIndexDay(Record record)
        {
            switch (record.SelectDay)
            {
                case "Понедельник":
                    return 0;
                case "Вторник":
                    return 1;
                case "Среда":
                    return 2;
                case "Четверг":
                    return 3;
                case "Пятница":
                    return 4;
                case "Суббота":
                    return 5;
                case "Воскресенье":
                    return 6;
                default:
                    throw new NotImplementedException();
            }
        }

        private void InciliationDayList()
        {
            if (_day.Count == 0)
            {
                for (int i = 0; i < 7; i++) _day.Add(new Day());
            }
        }

        #endregion

        #region ДОБАВЛЕНИЕ ЗАПИСИ

        private void AddRecord(Record record)
        {
            PickDay(record).Add(record);
            UpdateDay(PickIndexDay(record), record.Time);
        }


        private void UpdateDay(int indexDay, int time)
        {
            InciliationDayList();

            _day[indexDay].TimeReceipt[time] = true;
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

    }
}
