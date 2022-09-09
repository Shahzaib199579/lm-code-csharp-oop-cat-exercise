using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class CheetahCat : Cat, ICat
    {
        public CheetahCat()
        {
            IsAsleep = false;
            AverageHeight = 800;
            Setting = "wild";
        }
        public string Eat()
        {
            return "Zzzzzzz";
        }

        public void GoToSleep()
        {
            IsAsleep = true;
        }
    }
}
