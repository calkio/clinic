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
        private string? _qualificationDoctor;
        private int? _dayWeek;
        private string? _person;
        private Doctor _doctor;
        private int _time;
        private SortDoctors _sortDoctors;

        public MyConsole(SortDoctors sortDoctors)
        {
            _sortDoctors = sortDoctors;
        }

        public void SelectParams()
        {
            while (true)
            {
                SelectedQualification();
                SelectedPerson();
                SetDoctor();
                SelectedDayWeek();
                SelectedTime();
                SetRecord();
            }
        }

        #region ВЫВОД СООБЩЕНИЙ

        private void PrintMessageQualification()
        {
            Console.WriteLine("К какому специалисту вы хотите записаться ?");
        }

        private void PrintMessageDayWeek()
        {
            Console.WriteLine("На какой день недели вы хотите записаться (1,2,3,4,5,6,7) ?");
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

        private void SetRecord()
        {
            var record = new Record(_doctor, _dayWeek, _time);
        }

        private void SetDoctor()
        {
            _doctor = _sortDoctors.GetDoctor(_person);
        }

        private void SetQualification()
        {
            _qualificationDoctor = Console.ReadLine();
        }

        private void SetDayWeek()
        {
            _dayWeek = int.Parse(Console.ReadLine());
        }

        private void SetPerson()
        {
            _person = Console.ReadLine();
        }

        private void SetTime()
        {
            _time = int.Parse(Console.ReadLine());
        }

        #endregion

        #region Selected

        #region Qualification

        private void SelectedQualification()
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

        private void SelectedDayWeek()
        {
            PrintMessageDayWeek();
            SetDayWeek();
        }

        #endregion

        #region Person

        private void SelectedPerson()
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

        private void SelectedTime()
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
