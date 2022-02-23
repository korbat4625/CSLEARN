using System;

namespace Basic {
    internal class Program {
        static void Main(string[] args) {
            Vehicle v1 = new(
                new BasicEngine()
            );
            v1._engine.SpeedUp(500);
            v1._engine.ShowSpeed();

            Console.WriteLine("=================");

            Animal animal = new Pet("Black");
            animal.Shout();
            Animal dog = new Dog("Doggy");
            dog.Shout();
        }
        abstract class Animal {
            abstract protected string Name { get; set; }
            abstract public void Scared();
            abstract public void Shout();
        }
        class Pet : Animal {
            protected override string Name { get; set; }
            public Pet(string name) {
                Name = name;
            }
            public override void Scared() {
                Console.WriteLine("Pet scared!");
            }

            public override void Shout() {
                Console.WriteLine("My name is:" + Name);
            }
        }

        class Dog : Pet, Animal {
            public Dog(string name):base(name) {
                Name = name;
            }
            public override void Shout() {
                Console.WriteLine("My name is:" + Name);
            }
        }


        class BasicEngine : IEngine {
            public int power = 0;

            public void SpeedDown(int num) {
                power -= num;
            }

            public virtual void SpeedUp(int num) {
                power += num;
            }
            public void ShowSpeed() {
                Console.WriteLine(power);
            }
        }

        class SuperEngine : BasicEngine {
            public override void SpeedUp(int num) {
                this.power = (num + 200);
            }
        }
    }
}
