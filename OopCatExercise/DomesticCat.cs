using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OopCatExercise
{
    public class DomesticCat : Cat, ICat
    {
        public DomesticCat()
        {
            IsAsleep = false;
            AverageHeight = 23;
            Setting = "domestic";
        }
        public string Eat()
        {
            var random = new Random();
            return random.Next(0,2) != 1 ? "Purrrrrrr" : "Purrrrrrr...It will do I suppose";
        }

        public void GoToSleep()
        {
            this.IsAsleep = true;
        }

        public void WakeUp()
        {
            this.IsAsleep = false;
        }
    }
}
