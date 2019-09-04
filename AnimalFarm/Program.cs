using System;
using System.Collections.Generic;
using AnimalFarm.Sounds;
namespace AnimalFarm {
    class Program {
        static void Main(string[] args) {



            var cow = new Cow(new Moo());
            

            var cat = new Cat(new Meow());
            

            var lion = new Lion(new Roar());
            

            var animals = new List<ISpeak>();
            animals.Add(cat);
            animals.Add(cow);
            animals.Add(lion);

            foreach(var animal in animals) {

                animal.Speak();
                    
                    }
        }
    }
}
