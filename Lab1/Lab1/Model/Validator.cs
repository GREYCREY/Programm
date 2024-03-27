using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Validator
    {
        public static int AssertOnPositiveValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{value} is not correct");
            }
            else
            {
                return value;
            }
                
        }
    }
