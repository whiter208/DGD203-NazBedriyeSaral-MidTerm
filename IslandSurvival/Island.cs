using System;

namespace IslandSurvival
{
    internal class Island
    {
        public void IslandPart(string isim)
        {
            PrintWithPause($"Narrator: {isim} stepped out of the cave and, after exploring the surroundings, realized they were on an island.");
            PrintWithPause($"Narrator: {isim} was terrified and started running along the shoreline.");
            PrintWithPause($"Narrator: While running, {isim} suddenly saw a ship and ran towards it with joy.");
            PrintWithPause($"Narrator: {isim} noticed a few people around the ship.");
            PrintWithPause("Captain: Hey, stop right there! Who are you?");
            PrintWithPause($"{isim}: My name is {isim}. I don’t know how I got here, but I want to leave. Please help me.");
            PrintWithPause("Captain: You're not the first person I’ve encountered on this island, but it’s still a rare event.");
            PrintWithPause("Captain: I can’t risk my crew and my ship.");
            PrintWithPause($"{isim}: Please, I’m an archaeologist, but I don’t know how I ended up here. I beg you, help me get out of here!");
            PrintWithPause("Captain: We’re searching for a scorpion on this island. No one knows what it looks like, but whoever encounters it dies. We are prepared, though!");
            PrintWithPause("Captain: All I know is that it brought a curse to my people, and I must kill it!");
            PrintWithPause("Captain: If you’ve seen a scorpion—not the normal ones—let me know, and if it’s true, I’ll take you on my ship.");

            string choice = null;
            bool validChoice = false;

            while (!validChoice)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1. Yes, I’ve seen the scorpion. I can show you.");
                Console.WriteLine("2. No, I haven’t seen any scorpion. But I can help you.");
                Console.Write("Make your choice (1 or 2): ");
                choice = Console.ReadLine();

                if (choice == "1" || choice == "2")
                {
                    validChoice = true;
                }
                else
                {
                    PrintWithPause("Narrator: You made an invalid choice. Please select 1 or 2.");
                }
            }

            if (choice == "1")
            {
                PrintWithPause("Captain: Good. Show us the way. If this is true, we will take you on our ship.");
                PrintWithPause("Narrator: The captain and crew took you with them to find the scorpion. You showed them the entrance to the cave.");
                PrintWithPause("Narrator: The captain and crew killed the scorpion and returned. They took you with them and left the island on their ship.");
                PrintWithPause("The game is over.");
            }
            else if (choice == "2")
            {
                PrintWithPause("Captain: Then you’re of no use to me. Take care of yourself, kid!");
                PrintWithPause($"Narrator: {isim} walked away from the ship and headed into the island.");
                IslandSurvival.Survival Survival = new IslandSurvival.Survival();
                Survival.SurvivalPart(isim);
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
