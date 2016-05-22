using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAnimalswMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            int userChoice = 0;
            string animalName = "";
            int animalAge = 0;
            int animalApetite = 0;
            
                Console.WriteLine("What is the name of your Animal");
                animalName = (Console.ReadLine());
                Console.WriteLine("What is the age of your Animal");
                animalAge = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the current apetite of your Animal");
                animalApetite = int.Parse(Console.ReadLine());
                Animal dumbo = new Animal(animalName, animalAge, animalApetite);
                Console.WriteLine(animalName + " age = " + animalAge);
                Console.WriteLine(animalName + " apetite = " + animalApetite);

            do
            {

                Console.WriteLine();
                Console.WriteLine("1 - Feed Animal\n2 - Exercise Animal");
                Console.WriteLine();
                int.TryParse(Console.ReadLine(), out userChoice);

                switch (userChoice)
                {
                    case 1:

                        dumbo.FeedAnimal();
                        Console.WriteLine(animalName + " apetite = " + dumbo.Apetite);
                        break;

                    case 2:

                        dumbo.ExerciseAnimal();
                        Console.WriteLine(animalName + " apetite = " + dumbo.Apetite);
                        break;
                       
                    default:
                        break;

                }

            }

            while (userChoice == 1 || userChoice == 2);
        }
    }

        class Animal
        {
        //fields v
            private string name = "";
            private int apetite = 0;
            private int age = 0;



        //PROPERTIES v
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public int Age
            {
                get { return this.age; }
                set { this.age = value; }
            }

            public int Apetite
            {
                get { return this.apetite; }
                set { this.apetite = value; }
            }



            //methods v

            public void FeedAnimal()
            {
                this.Apetite += 100;
                //return this.Apetite;
            }

            public void ExerciseAnimal()
            {
                this.Apetite -= 100;
                //return this.Apetite;
            }



            //constructors v

            public Animal(string constName, int constAge, int constApetite)
            {
                this.Name = constName;
                this.Age = constAge;
                this.Apetite = constApetite;
            }

    }
}
