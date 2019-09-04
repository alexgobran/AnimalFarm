using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Sounds {
    class Roar :ISpeak {
        public void Speak() {
            Console.WriteLine("Roar!");
        }
    }
}
