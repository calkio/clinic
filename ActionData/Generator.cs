﻿using BusinessLogic;

namespace clinic
{
    public class Generator
    {
        //private string _pathFile = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data\\Doctors.txt");
        private string _pathFile;
        public List<Doctor> doctors = new List<Doctor>();

        public Generator(string pathFile)
        {
            _pathFile = pathFile;
        }

        public void GenerateDoctors()
        {
            using (StreamReader reader = new StreamReader(_pathFile))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> options = new List<string>();
                    string[] str = line.Split(' ');
                    foreach (string word in str) options.Add(word);

                    doctors.Add(CreateDoctor(options));
                    options.Clear();
                }
            }
        }

        private Doctor CreateDoctor(List<string> options)
        {
            int id = int.Parse(options[0]);
            string _firstname = options[2];
            string _secondname = options[1];
            string _surname = options[3];
            string qualification = options[4];
            int _experience = int.Parse(options[5]);

            return new Doctor(id, _firstname, _secondname, _surname, _experience, qualification);
        }
    }
}
