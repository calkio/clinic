using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace clinic
{
    internal class MyConsole
    {
        private string _qualificationDoctor;
        private int _dayWeek;
        private string _person;
        private Doctor _doctor;
        private int _time;
        private SortDoctors _sortDoctors;

        public MyConsole(SortDoctors sortDoctors)
        {
            _sortDoctors = sortDoctors;
        }

        public void SelectParams()
        {
            SelectedQualification();
            SelectedPerson();
            SetDoctor();
            SelectedDayWeek();
            SelectedTime();
            SetRecord();
        }

        #region СЕТАРЫ

        private void SetRecord()
        {
            var record = new Record(_doctor, _dayWeek, _time);
        }

        private void SetDoctor()
        {
            _doctor = _sortDoctors.GetDoctor(_person);
        }

        #endregion

        #region Selected

        #region Qualification

        private void SelectedQualification()
        {
            PrintMessageQualification();
            var qualifications = PrintQualifications();
            SetQualification(qualifications);
        }

        private void PrintMessageQualification()
        {
            Console.WriteLine("К какому специалисту вы хотите записаться ?");
        }

        private List<string> PrintQualifications()
        {
            var qualifications = _sortDoctors.GetQualification();
            foreach (var qualification in qualifications)
            {
                Console.WriteLine(qualification);
            }

            return qualifications;
        }

        private void SetQualification(List<string> trueList)
        {
            string message = Console.ReadLine();

            while (!IsValidMessage(trueList, message))
            {
                PrintErrorMessage();
                message = Console.ReadLine();
            }

            _qualificationDoctor = message;
        }

        #endregion

        #region DayWeek

        private void SelectedDayWeek()
        {
            PrintMessageDayWeek();
            SetDayWeek();
        }

        private void PrintMessageDayWeek()
        {
            Console.WriteLine("На какой день недели вы хотите записаться (1,2,3,4,5,6,7) ?");
        }

        private void SetDayWeek()
        {
            var message = Console.ReadLine();

            int number;
            bool isValidInput = int.TryParse(message, out number) && Enumerable.Range(1, 7).Contains(number);

            while (!isValidInput)
            {
                PrintErrorMessage();
                message = Console.ReadLine();
                isValidInput = int.TryParse(message, out number) && Enumerable.Range(1, 7).Contains(number);
            }

            _dayWeek = number;
        }

        #endregion

        #region Person

        private void SelectedPerson()
        {
            PrintMessagePerson();
            var names = PrintNameDoctors();
            SetPerson(names);
        }

        private void PrintMessagePerson()
        {
            Console.WriteLine("К какому доктору вы хотите записаться ?");
        }

        private List<string> PrintNameDoctors()
        {
            var names = _sortDoctors.GetNameDoctorsQualification(_qualificationDoctor);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            return names;
        }

        private void SetPerson(List<string> trueList)
        {
            var message = Console.ReadLine();

            while (!IsValidMessage(trueList, message))
            {
                PrintErrorMessage();
                message = Console.ReadLine();
            }

            _person = message;
        }

        #endregion

        #region Time

        private void SelectedTime()
        {
            PrintMessageTime();
            PrintFreeTime();
            SetTime();
        }

        private void PrintMessageTime()
        {
            Console.WriteLine("На какое время вы хотите записаться?");
        }

        private void PrintFreeTime()
        {
            var freeTimes = _doctor.Schedule.GetFreeTimeForDayWeek(_dayWeek);
            foreach (var freeTime in freeTimes)
            {
                Console.WriteLine(freeTime);
            }
        }

        private void SetTime()
        {
            var message = Console.ReadLine();

            int number;
            bool isValidInput = int.TryParse(message, out number) && Enumerable.Range(8, 13).Contains(number);

            while (!isValidInput)
            {
                PrintErrorMessage();
                message = Console.ReadLine();
                isValidInput = int.TryParse(message, out number) && Enumerable.Range(8, 13).Contains(number);
            }

            _time = number;
        }

        #endregion

        #endregion

        #region ИНВАРИАНТЫ

        private bool IsValidMessage(List<string> trueList, string message)
        {
            return trueList.Any(value => value == message);
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("Вы ввели неправильное сообщение!");
            Console.WriteLine("Введите заново");
        }

        #endregion

    }
}
