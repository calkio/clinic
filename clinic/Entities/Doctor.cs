﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Entities
{
    internal class Doctor
    {
        public Doctor(int id, string firstname, string secondname, string surname, int experience, string qualification)
        {
            _id = id;
            _firstname = firstname;
            _secondname = secondname;
            _surname = surname;
            _experience = experience;
            _qualification = qualification;
        }

        private string _qualification;
        public string Qualification { get => _qualification; set => _qualification = value; }

        private Schedule _schedule;
        public Schedule Schedule { get => _schedule; set => _schedule = value; }

        int _id;
        string _firstname;
        string _secondname;
        string _surname;
        int _experience;
        int _numberOfCabinet;
    }
}
