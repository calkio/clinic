using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Entities
{
    internal class Doctor
    {
        int _id;
        string _firstname;
        string _secondname;
        string _surname;
        int _experience;

        private int _qualification;
        public int Qualification {get => _qualification; set => _qualification = value; }

        Schedule _schedule;
        int _numberOfCabinet;

    }
}
