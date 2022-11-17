using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOStudent

{
    [Serializable]
    public class Student
    {
        public int StudentRollNo { get; set; }
        public string StudentName { get; set; }

        public double Percentage { get; set; }
    }
}
