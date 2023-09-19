using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Entities
{
    internal class Doctor
    {
        public Doctor(int id, string firstname, string secondname, string surname, int experience, int qualification, Schedule schedule, int numberOfCabinet)
        {
            _id = id;
            _firstname = firstname;
            _secondname = secondname;
            _surname = surname;
            _experience = experience;
            _qualification = qualification;
        }

        int _id;
        string _firstname;
        string _secondname;
        string _surname;
        int _experience;
        int _qualification;
        Schedule _schedule;
        int _numberOfCabinet;
    }
}
