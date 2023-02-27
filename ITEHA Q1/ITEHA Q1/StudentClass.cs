using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEHA_Q1
{
    class StudentClass
    {

        private String StudentNumber = "Unknown";
        private String StudentName = "Unknown";
        private String Degree = "Unknown";


        public String getStudentNumber() 
        {
            return StudentNumber;
        }

        public void setStudentNumber(String StNum) 
        {
            this.StudentNumber = StNum;

        }

        public String getStudentName()
        {
            return StudentName;
        }

        public void setStudentName(String StName)
        {
            this.StudentName = StName;

        }

        public String getDegree()
        {
            return Degree;
        }

        public void setDegree(String Deg)
        {
            this.Degree = Deg;

        }





    }
}
