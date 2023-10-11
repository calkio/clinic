using clinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    internal class SortDoctors
    {
        List<Doctor> doctors;

        public SortDoctors(List<Doctor> doctors)
        {
            this.doctors = doctors;
        }

        public List<string> GetNameDoctorsQualification(string qualification) 
        {
            return doctors
                   .Where(d => d.Qualification == qualification)
                   .Select(d => d.FullName)
                   .ToList();
        }

        public List<string> GetQualification()
        {
            return doctors.Select(d => d.Qualification).Distinct().ToList();
        }

        public Doctor GetDoctor(string fullName) 
        {
            return doctors.First(d => d.FullName == fullName);
        }
    }
}
