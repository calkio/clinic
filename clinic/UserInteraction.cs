using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace clinic
{
    internal class UserInteraction
    {
        List<Doctor> _doctors = new List<Doctor>();

        public UserInteraction(string pathFile)
        {
            GenerateDoctors(pathFile);
            SortDoctors sortDoctors = InitSortDoctors();
            while (true)
            {
                Launch(sortDoctors); 
            }
        }

        private void GenerateDoctors(string pathFile)
        {
            Generator generator = new Generator(pathFile);
            generator.GenerateDoctors();
            _doctors = generator.doctors;
        }

        private SortDoctors InitSortDoctors()
        {
            SortDoctors sortDoctors = new SortDoctors(_doctors);
            return sortDoctors;
        }

        private void Launch(SortDoctors sortDoctors)
        {
            MyConsole myConsole = new MyConsole(sortDoctors);
            myConsole.SelectParams();
        }
    }
}
