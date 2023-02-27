using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ClassesPractice
{
    class Student
    {

        private String StName = "Unknown";
        private String StSurname = "Unknown";
        private int StGrade =8;
        
        public String getName() {
          
            return this.StName;
        }

        public String setName(String StName) {

            if (this.StName != "" && this.StName != null)
            {
                this.StName = StName;
                return StName;
            }
            else {
                return StName;
            }
        
        }

        public int getGrade() {
            return this.StGrade;
        }

        public int setGrade( int StGrade) {
            this.StGrade = StGrade ;
            return 1;
        }

        public String getsurname()
        {

            return this.StSurname;
        }

        public String setSurname(String StSurname)
        {

            if (this.StSurname != "" && this.StSurname != null)
            {
                this.StSurname = StSurname;
                return StSurname;
            }
            else
            {
                return StSurname;
            }
        }


        public override String ToString() {
            String XD = StName+" "+StSurname+"      Grade: "+StGrade;
            //Console.WriteLine(XD);
            return XD ;
        }







    }
}
