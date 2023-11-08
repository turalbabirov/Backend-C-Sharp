using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstWithC_
{
    internal class Student
    {
        private int[] _grades;
        public int[] Grades { 
            get {
                return _grades;
            } 
            set {
                int saygac = 0;

                foreach (int element in value)
                {
                    if( element%2==0 )
                    {
                        saygac++;
                    }
                }

                _grades = new int[saygac];

                for(int i=0, j=0; i<value.Length; i++)
                {
                    if (value[i] % 2 == 0)
                    {
                        _grades[j++] = value[i];
                    }

                }

                _grades = _grades;
            } 
        }
        public void GradeShow() {
            foreach (int elements in _grades)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
