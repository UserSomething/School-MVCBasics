using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_MVCBasics.Models
{
    public class FeverCheckerProgram
    {
        public FeverCheckerProgram(double celcius)
        {
            Celcius = celcius;
            Fahrenheit = Celcius * 1.8 + 32;
        }

        public double Celcius { get; set; }
        public double Fahrenheit { get; set; }

        private const double CelciusFeverThreshold = 37.8;
        private const double FahrenheitFeverThreshold = 100;

        public string ReportResults()
        {
            const string NoFeverText = "You don't have a fever.";
            const string GotFeverText = "You have a fever.";

            if ((Celcius < CelciusFeverThreshold) || (Fahrenheit < FahrenheitFeverThreshold))
            {
                return NoFeverText;
            }
            else
            {
                return GotFeverText;
            }
        }
    }
}
