using System;
using System.Drawing;

namespace RapLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Welecome to Rap Libs ----------");
            Console.WriteLine("       Ice Cube's \"it was a good day\"");

           
            string location = Question("Give me a location...");

            string famousPerson = Question("Give me the name of famous person....");
            
            string adjective = Question("Give me an adjective...");

            string sound = Question("Give me a sound...");

            string animal = Question("Give me an animal...");

            string animal2 = Question("Give me an animal...");

            string animal3 = Question("Give me an animal...");

            string verb = Question("Give me an animal...");

            string typeOfPerson = Question("Give me a type of person... ");

            string noun = Question("Give me a noun...");

            string verb2 = Question("Give me a verb...");

            string store = Question("Give me a name of store...");

            string race = Question("Give me a race of people...");

            string choice = Question("Pick One: alright/terrible...");

            string famousWoman = Question("Give me a name of famous woman...");

            string verb3 = Question("Give me a verb...");

            string group = Question("Give me a group of people...");

            string place = Question("Give me a place...");

            string game = Question("Give me a game...");

            string verb4 = Question("Give me a -ed verb...");

            string accomplishment = Question("Give me an a accomplishment......");

            string setting2 = Question("Give me a setting...");
  
            string pluralNoun = Question("Give me a plural noun...");

            string athlete = Question("Give me a name of an athlete...");

            string adjective2 = Question("Give me an adjective...");


            Console.WriteLine($"Just waking up in {location}, gotta thank {famousPerson}. I don't " +
                $"know, but today seems kinda {adjective}. No {sound} from the {animal}. No barking from the dogs, no smog And momma cooked a breakfast with no {animal2}." +
                $"I got my grub on didn't pig out, but didn't {animal3} out Finally got a call from a girl want to {verb} out. Hooked it up on later as I hit the do'" +
                $"Thinking will I live another {typeOfPerson}. I gotta go cause I got me a {noun} And if I hit the switch, I can make the ass {verb2} " +
                $"Had to stop at a {store} Looking in my mirror not a {race} in sight and everything is {choice} I got a beep from {famousWoman} and she can {verb3} all night" +
                $"Called up the {group} and I'm askin y'all Which {place}, are y'all playin {game}? Get me on the {setting2} and I'm trouble" +
                $"Last week {verb4} around and got a {accomplishment} Freaking {pluralNoun} everyway like {athlete} I can't believe, today was a {adjective2} day");        
        }

        public static string Question(string q) 
        {
            Console.WriteLine(q);

            return Console.ReadLine();
        }
    }
}
