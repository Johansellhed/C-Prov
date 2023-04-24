using System;

namespace CsharpProv
{
    class Program
    {
        static void Main(string[] args)
        {




            // A NIVÅ

            //1. skriv ut udda siffror från 1 till 99 mha for loop.

            for(int i = 0; i < 100; i++ )
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }


            //2. a) skapa en Klass och döp den till Car
            // b) Skapa tre variablar som heter :model.color,year i klass Car
            // c) skriv en constractur för class Car med 3 parametrar(argument)
            // d) Skapa 2 objekter av klass Car i main method och skriv ut deras model,color och year

            Car car1 = new Car();
            car1.model = "Volvo";
            car1.color = "blå";
            car1.year = 2018;

            Car car2 = new Car();
            car2.model = "Audi";
            car2.color = "vit";
            car2.year = 2015;

            Console.WriteLine("car1 är en " + car1.model + ", den är " + car1.color + " och skapades " + car1.year);
            Console.WriteLine("car2 är en " + car2.model + ", den är " + car2.color + " och skapades " + car2.year);



            //3. skapa ett program som innehåller en array som ska innehålla namnen på tre svenska städer. Skriv in två av namnen i programmets kod men låt användaren få skriva in namnet på den tredje staden. Skriv avslutningsvis ut alla stadsnamnen på samma rad.

            string[] städer = { "Göteborg", "Stockholm", };

            Console.WriteLine("Skriv ut den tredje staden");
            string stad3 = Console.ReadLine();

            //städer[2] = stad3;




            //4. skapa ett program som innehåller en array med minst 8 heltal. Gå igenom arrayen med hjälp av en loop och hitta det största talet i arrayen.

            int[] störsttal = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(störsttal.());


            // C NIVÅ

            //1. skriv ett C# program som tar fyra siffror som indata för att beräkna och skriva ut medelvärdet

            double nummer1 = 6;
            double nummer2 = 8;
            double nummer3 = 5;
            double nummer4 = 12;

            double tot = (nummer1 + nummer2 + nummer3 + nummer4);

            double answer = tot / 4;

            Console.WriteLine(answer);


            //2. skriv ett C# Program för att konvertera celcius till farenheit

            Console.WriteLine("skriv in ett tal som du vill konvertera från celcius till farenheit");
            double cel = Convert.ToInt32(Console.ReadLine());

            double far = (cel * 1.8) + 32;

            Console.WriteLine(far);



            //3. skriv en metod för att visa de första 10 naturliga talen med hjälp av for loop

            static void forloop()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            }

            forloop();


            //4. skapa en array {"Maryam", "Pontus" , "Hilda"} och skriv ett program för att få längden på arrayen. Ändra arrayens första namn till "dittnamn" och skriv ut array element

            string[] namearray = { "Maryam", "Pontus", "Hilda" };

            Console.WriteLine("längden på arrayen är " + namearray.Length);

            namearray[0] = "Johan";

            foreach(string element in namearray)
            {
                Console.WriteLine("Namnen i Array");
                Console.WriteLine(element);
            }
            

            
            
            
            
            
            
            // E NIVÅ

            //1. Skriv ut resultatet av att addera två nummer i c#

            int num1 = 2;
            int num2 = 3;
            Console.WriteLine("Svaret av num1 + num2 blir " + num1 + num2);

            //2. skriv ett program som acceptera två heltal från användaren och kontrollera om de är lika eller inte. Är dem lika får användaren ett meddelande i konsolen

            Console.WriteLine("Skriv in 2 nummer för att se om de är lika eller inte lika");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            if (num3 == num4)
            {
                Console.WriteLine("dina nummer är lika");
            }

            else if(num3 != num4)
            {
                Console.WriteLine("dina nummer är inte lika");
            }


            //3. skriv ett program för att beräkna arean av en kvadrat

            int num5 = 6;

            Console.WriteLine(num5 * num5);


            //4. skriv in namnen på 5 elever i en array, döpa den till stdName och skriv ut den(använd loop).

            string[] stdName = { "Vilgot", "Rasmus", "Johan", "Oskar", "Malte" };

            foreach (string element in stdName)
            {
                Console.WriteLine(element);
            }

        }
    }
}
