using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class LionCat : Cat, ICat
    {
        public LionCat()
        {
            IsAsleep = false;
            AverageHeight = 1100;
            Setting = "wild";
        }

        public string Eat()
        {
            return "Roar!!!!";
        }

        public void GoToSleep()
        {
            IsAsleep = true;
        }
    }
}
