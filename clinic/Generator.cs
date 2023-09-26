using clinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    internal class Generator
    {
        private string _pathFile;
        private List<Doctor> _doctors = new List<Doctor>();

        public Generator(string pathFile)
        {
            _pathFile = pathFile;
        }

        public void GenerateDoctors()
        {
            StreamReader sr = new StreamReader(_pathFile);

            List<string> options = new List<string>();
            string[] line = sr.ReadLine().Split(' ');
            while (line != null)
            {
                foreach (string word in line) options.Add(word);
                _doctors.Add(CreateDoctor(options));
            }
        }

        private Doctor CreateDoctor(List<string> options)
        {
            int id = int.Parse(options[0]);
            string _firstname = options[1];
            string _secondname = options[2];
            string _surname = options[3];
            string qualification = options[4];
            int _experience = int.Parse(options[5]);

            return new Doctor(id, _firstname, _secondname, _surname, _experience, qualification);
        }

        public void ShowDoctors()
        {
            foreach (var doctor in _doctors)
            {
                Console.WriteLine(doctor.Qualification);
            }
        }
    }
}
