using System;
using System.Collections.Generic;
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
            return "Purrrrrrr";
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
