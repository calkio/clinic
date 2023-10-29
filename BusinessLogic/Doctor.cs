using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class Doctor
    {
        private string _qualification;
        public string Qualification { get => _qualification; set => _qualification = value; }

        private Schedule _schedule;
        public Schedule Schedule { get => _schedule; set => _schedule = value; }

        public string FullName { get => $"{_firstname} {_secondname} {_surname}"; }

        int _id;
        string _firstname;
        string _secondname;
        string _surname;
        int _experience;
        int _numberOfCabinet;

        public Doctor(int id, string firstname, string secondname, string surname, int experience, string qualification)
        {
            _id = id;
            _firstname = firstname;
            _secondname = secondname;
            _surname = surname;
            _experience = experience;
            _qualification = qualification;
            Schedule = new Schedule();
        }
    }
}
