using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_4
{
    public class Subjects
    {
      
        public string SubName { get; set; }
        public int SubCode { get; set; }
        public string Teacher { get; set; }
        public Subjects(string name, int code, string teacher)
        {
            SubName = name;
            SubCode = code;
            Teacher = teacher;
        }
    }
}
