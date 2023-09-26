using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Entities
{
    internal class Record
    {
        public Record(Doctor doctor, string? selectDay, bool checkSchedule, int time)
        {
            _selectDay = selectDay;
            _checkSchedule = checkSchedule;
            _time = time;

            _doctor = doctor;
            _schedule = _doctor.Schedule;
            if (_checkSchedule) _schedule.ShowEntry(this);
            _schedule.UpdateSchedule(this);
        }

        public Record()
        {

        }


        private string? _selectDay;
        public string? SelectDay { get => _selectDay; set => _selectDay = value; }

        private int _time;
        public int Time { get => _time; set => _time = value; }


        bool _checkSchedule;

        Doctor _doctor;
        Patient _patient;
        Cabinet _cabinet;
        Schedule _schedule;
    }
}
