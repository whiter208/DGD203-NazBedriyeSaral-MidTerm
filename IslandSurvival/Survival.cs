using System;

namespace IslandSurvival
{
    internal class Survival
    {
        public void SurvivalPart(string isim)
        {
            PrintWithPause($"Narrator: {isim} somehow managed to survive on the island for a few days, but they ran out of food.");
            PrintWithPause($"Narrator: {isim} came up with a few ideas to find food.");

            string firstChoice = "";
            while (firstChoice != "1" && firstChoice != "2")
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1- Eat wild berries.");
                Console.WriteLine("2- Hunt animals.");
                Console.Write("Make your choice: ");
                firstChoice = Console.ReadLine();

                if (firstChoice != "1" && firstChoice != "2")
                {
                    PrintWithPause("Narrator: You made an invalid choice. Please try again.");
                }
            }

            if (firstChoice == "1")
            {
                PrintWithPause($"Narrator: {isim} decided to eat the wild berries.");
                PrintWithPause($"Narrator: The berries turned out to be poisonous and {isim} was poisoned.");
                PrintWithPause($"Narrator: Despite trying to fight it, {isim} couldn’t survive.");
                PrintWithPause("The game is over.");
            }
            else if (firstChoice == "2")
            {
                PrintWithPause($"Narrator: {isim} decided to hunt animals. Which animal will they hunt?");

                string secondChoice = "";
                while (secondChoice != "1" && secondChoice != "2" && secondChoice != "3")
                {
                    Console.WriteLine("Options:");
                    Console.WriteLine("1- Set a trap for rabbits.");
                    Console.WriteLine("2- Catch fish.");
                    Console.WriteLine("3- Hunt a boar.");
                    Console.Write("Make your choice: ");
                    secondChoice = Console.ReadLine();

                    if (secondChoice != "1" && secondChoice != "2" && secondChoice != "3")
                    {
                        PrintWithPause("Narrator: You made an invalid choice. Please try again.");
                    }
                }

                if (secondChoice == "1")
                {
                    PrintWithPause($"Narrator: {isim} was setting a trap for rabbits when suddenly a wild boar charged at them.");
                    PrintWithPause($"Narrator: {isim} fought the boar as best as they could, but they couldn’t win. Due to severe injuries and blood loss, {isim} died.");
                    PrintWithPause("The game is over.");
                }
                else if (secondChoice == "2")
                {
                    PrintWithPause($"Narrator: {isim} crafted a spear and found a waterfall in the center of the island.");
                    PrintWithPause($"Narrator: They caught fish by the waterfall and ate it raw.");
                    PrintWithPause($"Narrator: After walking for a while, {isim} found a village and started heading toward it.");
                    PrintWithPause($"Narrator: Some villagers shouted, 'There’s a stranger here!'");
                    PrintWithPause($"Narrator: {isim} panicked but kept walking into the village.");
                    PrintWithPause($"Narrator: An old man in strange clothing started speaking.");
                    PrintWithPause("Village Elder: Hello stranger. What is your name? What wind brought you here?");
                    PrintWithPause($"{isim}: My name is {isim}. I don’t know how I got here, but I’ve been trying to survive for a few days.");
                    PrintWithPause($"Village Elder: You’re not the first person I’ve heard say that, {isim}. This island has a curse, but not everyone can grasp it.");
                    PrintWithPause($"Village Elder: I understand your mind is very confused. Let me tell you the story of this island and this village. Follow me.");
                    PrintWithPause($"Narrator: {isim} listened carefully to the Village Elder and understood the mysterious story of the island and the village. {isim} continued living in the village and became one of its respected leaders.");
                    PrintWithPause("The game is over.");
                }
                else if (secondChoice == "3")
                {
                    PrintWithPause($"Narrator: {isim} decided to hunt a boar.");

                    string thirdChoice = "";
                    while (thirdChoice != "1" && thirdChoice != "2")
                    {
                        Console.WriteLine("Options:");
                        Console.WriteLine("1- You see the boar and attack immediately to prevent it from escaping.");
                        Console.WriteLine("2- Wait for the right moment.");
                        Console.Write("Make your choice: ");
                        thirdChoice = Console.ReadLine();

                        if (thirdChoice != "1" && thirdChoice != "2")
                        {
                            PrintWithPause("Narrator: You made an invalid choice. Please try again.");
                        }
                    }

                    if (thirdChoice == "1")
                    {
                        PrintWithPause($"Narrator: {isim} rushed to attack. However, the boar fought back and {isim} succumbed to severe injuries.");
                        PrintWithPause("The game is over.");
                    }
                    else if (thirdChoice == "2")
                    {
                        PrintWithPause($"Narrator: {isim} was waiting for the right moment when five strangely dressed people approached them.");
                        PrintWithPause($"Narrator: The people threatened {isim} aggressively. Confused, {isim} was tied up and taken to their village.");
                        PrintWithPause($"Narrator: Inside a house, {isim} sat tied to a chair.");
                        PrintWithPause($"Narrator: An old man in strange clothing came in and started speaking.");
                        PrintWithPause("Village Elder: Hello stranger. What is your name? What wind brought you here?");
                        PrintWithPause($"{isim}: My name is {isim}. I don’t know how I got here, but I’ve been trying to survive for a few days.");
                        PrintWithPause($"Village Elder: You’re not the first person I’ve heard say that, {isim}. This island has a curse, but not everyone can grasp it.");
                        PrintWithPause($"Village Elder: I understand your mind is very confused. Let me tell you the story of this island and this village. Follow me.");
                        PrintWithPause($"Narrator: {isim} listened carefully to the Village Elder and understood the mysterious story of the island and the village. {isim} continued living in the village and became one of its respected leaders.");
                        PrintWithPause("The game is over.");
                    }
                }
            }
        }

        private void PrintWithPause(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
