using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Entities
{
    internal class Record
    {
        private int? _day;
        public int? MyDay { get => _day; set => _day = value; }

        private int _time;
        public int Time { get => _time; set => _time = value; }

        private Doctor _doctor;
        public Doctor MyDoctor { get => _doctor; set => _doctor = value; }


        public Record(Doctor doctor, int? selectDay, int time)
        {
            _day = selectDay;
            _time = time;

            _doctor = doctor;
            _doctor.Schedule.AddRecordInDay(this);
        }

        public Record()
        {

        }
    }
}
