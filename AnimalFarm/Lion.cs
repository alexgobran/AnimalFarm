using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm {
    class Lion : ISpeak {
        ISpeak speak;

        public void Speak() {

            Console.WriteLine("The Lion says");
            speak.Speak();
        }

        public Lion(ISpeak speak) {
            this.speak = speak;
        }

    }
}