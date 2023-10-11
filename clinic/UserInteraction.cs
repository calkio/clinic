using clinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    internal class UserInteraction
    {
        MyConsole console;
        List<Doctor> _doctors = new List<Doctor>();

        public UserInteraction()
        {
            GenerateDoctors();
            InitExemplar();
            while (true)
            {
                Launch(); 
            }
        }

        private void InitExemplar()
        {
            SortDoctors sortDoctors = new SortDoctors(_doctors);
            console = new MyConsole(sortDoctors);
        }

        private void GenerateDoctors() 
        {
            Generator generator = new Generator();
            generator.GenerateDoctors();
            _doctors = generator.doctors;
        }

        private void Launch()
        {
            console.SelectedQualification();
            console.SelectedPerson();
            console.SetDoctor();
            console.SelectedDayWeek();
            console.SelectedTime();
            console.SetRecord();
        }
    }
}
