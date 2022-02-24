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

            Pet dog = new Dog("dog");
            dog.Scared();
            dog.Run();
        }
        interface IAnimal {
            public string Name { get; set; }
            public void Scared();
            public void Shout();
        }
        abstract class Pet : IAnimal {
            public string Name { get; set; }
            public Pet(string name) {
                Name = name;
            }
            public virtual void Scared() {
                Console.WriteLine("Pet scared!");
            }

            public virtual void Shout() {
                Console.WriteLine("My name is:" + Name);
            }
            abstract public void Run();
        }

        class Dog : Pet {
            public Dog(string name):base(name) {
                Name = name;
            }
            public override void Scared() {
                Console.WriteLine($"{Name} is scared...");
            }
            public override void Shout() {
                Console.WriteLine("My name is:" + Name);
            }
           public override void Run() {
                Console.WriteLine($"{Name} is running!!!!!!!!!!!!!!!");
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
