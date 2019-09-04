using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm {
    class Cat : ISpeak {
        ISpeak speak;

        public void Speak() {

            Console.WriteLine("The Cat says");
            speak.Speak();
        }

        public Cat(ISpeak speak) {
            this.speak = speak;
        }
    }
}
