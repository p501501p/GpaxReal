using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpax
{
    internal class Gpaxcalculator
    {
        private double gpa_sum;
        private int n;
        private double max;
        private double min;
        public void setGPA(double gpa)
        {
            this.gpa_sum += gpa;
            this.n++;

            if (gpa <= min)
            {
                min = gpa;
            }

            else if (gpa >= max)
            {
                max = gpa;
                if (min == 0)
                {
                    min = gpa;
                }
            }
        }
        public double getGPAX()
        {
            return Math.Round(this.gpa_sum / this.n, 2);
        }
        public double getmax()
        {
            return Math.Round(this.max, 2);
        }
        public double getmin()
        {
            return Math.Round(this.min, 2);
        }
    }
}

