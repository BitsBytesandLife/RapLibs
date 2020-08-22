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

            AskQuestion("Give me a location...");
            string location = AnswerQuestion("Give me a location...");

            AskQuestion("Give me the name of famous person....");
            string famousPerson = AnswerQuestion("Give me the name of famous person....");
            
            AskQuestion("Give me an adjective..");
            string adjective = AnswerQuestion("Give me an adjective...");

            AskQuestion("Give me an sound...");
            string sound = AnswerQuestion("Give me a sound...");

            AskQuestion("Give me an animal...");
            string animal = AnswerQuestion("Give me an animal...");

            AskQuestion("Give me an animal...");
            string animal2 = AnswerQuestion("Give me an animal...");

            AskQuestion("Give me an animal...");
            string animal3 = AnswerQuestion("Give me an animal...");

            AskQuestion("Give me a verb...");
            string verb = AnswerQuestion("Give me an animal...");

            AskQuestion("Give me a type of person...");
            string typeOfPerson = AnswerQuestion("Give me a type of person... ");

            AskQuestion("Give me a noun...");
            string noun = AnswerQuestion("Give me a noun...");

            AskQuestion("Give me a verb...");
            string verb2 = AnswerQuestion("Give me a verb...");

            AskQuestion("Give me a name of Store...");
            string store = AnswerQuestion("Give me a name of store...");

            AskQuestion("Give me a race of people...");
            string race = AnswerQuestion("Give me a race of people...");

            AskQuestion("Pick One: alright/terrible...");
            string choice = AnswerQuestion("Pick One: alright/terrible...");

            AskQuestion("Give me a name of famous woman...");
            string famousWoman = AnswerQuestion("Give me a name of famous woman...");

            AskQuestion("Give me a verb...");
            string verb3 = AnswerQuestion("Give me a verb...");

            AskQuestion("Give me a group of people...");
            string group = AnswerQuestion("Give me a group of people...");

            AskQuestion("Give me a place...");
            string place = AnswerQuestion("Give me a place...");

            AskQuestion("Give me a game...");
            string game = AnswerQuestion("Give me a game...");

            AskQuestion("Give me a setting...");
            string setting = AnswerQuestion("Give me a setting...");

            AskQuestion("Give me a -ed verb...");
            string verb4 = AnswerQuestion("Give me a -ed verb...");

            AskQuestion("Give me an a accomplishment...");
            string accomplishment = AnswerQuestion("Give me an a accomplishment......");

            AskQuestion("Give me a setting...");
            string setting2 = AnswerQuestion("Give me a setting...");

            AskQuestion("Give me a plural noun...");
            string pluralNoun = AnswerQuestion("Give me a plural noun...");

            AskQuestion("Give me a name of an athlete...");
            string athlete = AnswerQuestion("Give me a name of an athlete...");

            AskQuestion("Give me an adjective..");
            string adjective2 = AnswerQuestion("Give me an adjective...");


            Console.WriteLine($"Just waking up in {location}, gotta thank {famousPerson}. I don't " +
                $"know, but today seems kinda {adjective}. No {sound} from the {animal}. No barking from the dogs, no smog And momma cooked a breakfast with no {animal2}." +
                $"I got my grub on, but didn't {animal3} out Finally got a call from a girl want to {verb} out. Hooked it up on later as I hit the do'" +
                $"Thinking will I live another {typeOfPerson}. I gotta go cause I got me a {noun}  And if I hit the switch, I can make the ass {verb2} " +
                $"Had to stop at a {store} Looking in my mirror not a {race} in sight and everything is {choice} I got a beep from {famousWoman} and she can {verb3} all night" +
                $"Called up the {group} and I'm askin y'all Which {place}, are y'all playin {game}? Get me on the {setting2} and I'm trouble" +
                $"Last week {verb4} around and got a {accomplishment} Freaking {pluralNoun} everyway like {athlete } I can't believe, today was a {adjective2} day"); 


            static void AskQuestion(string question)
            {
                Console.WriteLine(question);     
            }

            static string AnswerQuestion(string question)
            {
                string answer = Console.ReadLine();
                return answer;
            }
        }
    }
}
