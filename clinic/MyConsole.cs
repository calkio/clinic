using clinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    internal class MyConsole
    {
        public string? _qualificationDoctor;
        public string? _dayWeek;
        public string? _person;
        public Doctor _doctor;
        public int _time;
        public Record _record;
        private SortDoctors _sortDoctors;

        public MyConsole(SortDoctors sortDoctors)
        {
            _sortDoctors = sortDoctors;
        }

        #region ВЫВОД СООБЩЕНИЙ

        private void PrintMessageQualification()
        {
            Console.WriteLine("К какому специалисту вы хотите записаться ?");
        }

        private void PrintMessageDayWeek()
        {
            Console.WriteLine("На какой день недели вы хотите записаться ?");
        }

        private void PrintMessagePerson()
        {
            Console.WriteLine("К какому доктору вы хотите записаться ?");
        }

        private void PrintMessageTime()
        {
            Console.WriteLine("На какое время вы хотите записаться?");
        }

        private void PrintMessageRecordingСompleted()
        {
            Console.WriteLine("Запись совершена");
        }

        #endregion

        #region СЕТАРЫ

        public void SetRecord()
        {
            _record = new Record(_doctor, _dayWeek, _time);
        }

        public void SetDoctor()
        {
            _doctor = _sortDoctors.GetDoctor(_person);
        }

        public void SetQualification()
        {
            _qualificationDoctor = Console.ReadLine();
        }

        public void SetDayWeek()
        {
            _dayWeek = Console.ReadLine();
        }

        public void SetPerson()
        {
            _person = Console.ReadLine();
        }

        public void SetTime()
        {
            _time = int.Parse(Console.ReadLine());

        }

        #endregion

        #region Selected

        #region Qualification

        public void SelectedQualification()
        {
            PrintMessageQualification();
            PrintQualifications();
            SetQualification();
        }

        private void PrintQualifications()
        {
            var qualifications = _sortDoctors.GetQualification();
            foreach (var qualification in qualifications)
            {
                Console.WriteLine(qualification);
            }
        }

        #endregion

        #region DayWeek

        public void SelectedDayWeek()
        {
            PrintMessageDayWeek();
            SetDayWeek();
        }

        #endregion

        #region Person

        public void SelectedPerson()
        {
            PrintMessagePerson();
            PrintNameDoctors();
            SetPerson();
        }

        private void PrintNameDoctors()
        {
            var names = _sortDoctors.GetNameDoctorsQualification(_qualificationDoctor);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        #endregion

        #region Time

        public void SelectedTime()
        {
            PrintMessageTime();
            PrintFreeTime();
            SetTime();
        }

        private void PrintFreeTime()
        {
            var freeTimes = _doctor.Schedule.GetFreeTimeForDayWeek(_dayWeek);
            foreach (var freeTime in freeTimes)
            {
                Console.WriteLine(freeTime);
            }
        }

        #endregion 

        #endregion
    }
}
