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
        List<Doctor> _doctors = new List<Doctor>();
        string? _qualificationDoctor;
        string? _dayWeek;
        string? _person;
        Doctor _doctor;
        int _time;

        public UserInteraction()
        {
            GenerateDoctors();
            SortDoctors sortDoctors = new SortDoctors(_doctors);
            while (true)
            {
                SelectedQualification(sortDoctors);
                SelectedPerson(sortDoctors);
                _doctor = sortDoctors.GetDoctor(_person);
                SelectedDayWeek();
                SelectedTime();
                Record _record = new Record(_doctors[0], _dayWeek, _time);
            }
        }

        private void GenerateDoctors() 
        {
            Generator generator = new Generator();
            generator.GenerateDoctors();
            _doctors = generator.doctors;
        }


        private void SelectedQualification(SortDoctors sortDoctors)
        {
            Console.WriteLine("К какому специалисту вы хотите записаться ?");
            var qualifications = sortDoctors.GetQualification();
            foreach (var qualification in qualifications)
            {
                Console.WriteLine(qualification);
            }

            _qualificationDoctor = Console.ReadLine();
        }

        private void SelectedDayWeek()
        {
            Console.WriteLine("На какой день недели вы хотите записаться ?");
            _dayWeek = Console.ReadLine();
        }

        private void SelectedPerson(SortDoctors sortDoctors)
        {
            Console.WriteLine("К какому доктору вы хотите записаться ?");
            var names = sortDoctors.GetNameDoctorsQualification(_qualificationDoctor);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            _person = Console.ReadLine();
        }


        private void SelectedTime()
        {
            Console.WriteLine("На какое время вы хотите записаться?");
            _time = int.Parse(Console.ReadLine());
        }

        public void RecordingСompleted()
        {
            Console.WriteLine("Запись совершена");
        }

    }
}
