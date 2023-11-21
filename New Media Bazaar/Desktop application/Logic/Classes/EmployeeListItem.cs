using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class EmployeeListItem
    {
        public int Id { get; set; }
        public string DisplayText { get; set; }

        public EmployeeListItem(int id, string displayText)
        {
            Id = id;
            DisplayText = displayText;
        }

        public override string ToString()
        {
            return DisplayText;
        }
    }
}
