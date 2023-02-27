using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEHA_Q1
{
    class StudentDOClass
    {

        private StudentPatternClass DO = new StudentPatternClass();

        public StudentPatternClass getPatternClass() 
        {
            return DO;
        }

        public void setPatternClass(StudentPatternClass St) 
        {
            this.DO = St;

        }


        public String toString() 
        {
            string XD = "";

             XD = XD+DO.getStArray();
            
          

            return XD;
        }


    }
}
