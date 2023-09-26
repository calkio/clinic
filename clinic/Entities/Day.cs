using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Entities
{
    internal class Day
    {
        private Dictionary<int, bool> _timeReceipt = new Dictionary<int, bool>()
        {
            { 8, false},
            { 9, false},
            { 10, false},
            { 11, false},
            { 12, false},
            { 13, false},
            { 14, false},
            { 15, false},
            { 16, false},
            { 17, false},
            { 18, false},
            { 19, false},
            { 20, false},
        };

        public Dictionary<int, bool> TimeReceipt { get => _timeReceipt; set => _timeReceipt = value; }

    }
}
