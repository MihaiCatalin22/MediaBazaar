using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Shift
    {
        public int Id { get; private set; }
        public Employee Employee { get; set; }
        public DateTime Date { get; private set; }
        public int Type { get; private set; }

        public Shift() { }
        public string GetType()
        {
            return Enum.GetName((ShiftType)Type);
        }
    }
}
