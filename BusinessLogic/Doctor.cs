using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Secondname { get; set; }

        public string Surname { get; set; }

        public int Experience { get; set; }

        public int NumberOfCabinet { get; set; }

        public string Qualification { get; set; }

        public Schedule Schedule { get; set; }

        public string FullName { get => $"{Firstname} {Secondname} {Surname}"; }

        public Doctor(int id, string firstname, string secondname, string surname, int experience, string qualification)
        {
            Id = id;
            Firstname = firstname;
            Secondname = secondname;
            Surname = surname;
            Experience = experience;
            Qualification = qualification;
            Schedule = new Schedule();
        }
    }
}
