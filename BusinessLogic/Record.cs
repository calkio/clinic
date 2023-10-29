using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Record
    {
        public int MyDay { get; set; }
        public int Time { get; set; }
        public Doctor MyDoctor { get; set; }


        public Record(Doctor doctor, int selectDay, int time)
        {
            MyDay = selectDay;
            Time = time;

            MyDoctor = doctor;
            MyDoctor.Schedule.AddRecordInDay(this);
        }
    }
}
