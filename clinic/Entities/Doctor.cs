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
        int _qualification;
        Schedule _schedule;
        int _numberOfCabinet;
    }
}
