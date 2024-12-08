using System;

namespace AdventureGame
{
    public class Cave
    {
        public void CavePart()
        {
            Console.Write("Enter your name: ");
            string isim = Console.ReadLine();


            // PrintWithPause fonksiyonunu CHATGPT'den aldım. Kodun en aşağı kısmında belirttim. Diğer sayfalarda da bu fonksiyonu kullandım çünkü çok işlevli.
            PrintWithPause($"Narrator: {isim} woke up in a dark and desolate cave. They didn’t know how they got there. They didn’t know what time it was. They were trying to pull themselves together.");
            PrintWithPause("Narrator: They started exploring the cave and drank some water. It made them feel a bit better.");
            PrintWithPause($"Narrator: {isim} was searching for a way out of the cave.");

            int adimSayisi = 0;
            while (adimSayisi < 5)
            {
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("1 - Go right");
                Console.WriteLine("2 - Go left");
                Console.Write("Your choice: ");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.WriteLine("You went right, walked a lot, and now you need to make another choice.");
                }
                else if (secim == "2")
                {
                    Console.WriteLine("You went left, got a bit tired, and encountered two more paths.");
                }
                else
                {
                    Console.WriteLine("Invalid choice, please pick 1 or 2.");
                    continue;
                }

                adimSayisi++;
            }

            PrintWithPause($"Narrator: {isim} walked a bit further and encountered a scorpion the size of a human.");
            PrintWithPause("Scorpion: What are you doing here, little one? Lost your way?");
            PrintWithPause($"{isim}: How can you talk? Please, have mercy on me.");
            PrintWithPause("Scorpion: I’m not talking; I’m projecting my thoughts into your mind.");
            PrintWithPause($"{isim}: What do you want from me?");
            PrintWithPause("Scorpion: Relax, I’m only here to help you.");
            PrintWithPause($"{isim}: How?");
            PrintWithPause("Scorpion: I know the way out of this cave. I’m a sapiosexual. If you answer my questions correctly, I’ll guide you to the exit. Otherwise, you’ll be my dinner. And if you try to run, I won’t even wait until dinnertime.");
            PrintWithPause($"{isim}: You’re very strange. Alright, ask your questions.");

            int yanlis = 0;
            int hak = 2;

            // Doğru soru-cevap seçeneklerinde CHATGPT'den yardım aldım.
            // Bu method biraz kafamı karıştırdı anladım ama projenin devamında bir daha kullanmadım.

            string[,] svc = new string[4, 2]
            {
                {"Scorpion: Okay. Here's the first question: It always moves upward but never goes back. What is it?" , "age" },
                {"Scorpion: The second question: A part of it is always lost, but it’s impossible to get it back. What is it?" , "time" },
                {"Scorpion: The third question: What is the fastest thing known in the universe?" , "light" },
                {"Scorpion: What is half of 208?", "104" }
            };

            string[] dc =
            {
                "Scorpion: You got it right! Let me see the map. Hmm, you need to go right and thennn...",
                "Scorpion: Well done! I didn’t think you were this smart. That way!",
                "Scorpion: That was easy anyway. I would’ve laughed so much if you didn’t know it. You’ll go up from there.",
                "Scorpion: CORRECTTT! Go under the bridge."
            };

            string[] yc =
            {
                "Scorpion: WRONNGGGG! How could you not know that? I’m not going to tell you the answer, live with this mystery.",
                "Scorpion: You're dumber than you look. Wrong answer.",
                "Scorpion: HaHahahHAHaHAHahHA Are you stupid? This was the easiest question!",
                "Scorpion: Are you serious? You’d have to be a baby not to know this."
            };

            Random rnd = new Random();

            for (int i = 0; i < svc.GetLength(0); i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}: {svc[i, 0]}");

                Console.Write("What's your answer? ");
                string cevap = Console.ReadLine().Trim().ToLower();

                if (cevap == svc[i, 1])
                {
                    int dcIndex = rnd.Next(dc.Length);
                    Console.WriteLine(dc[dcIndex]);
                }
                else
                {
                    int ycIndex = rnd.Next(yc.Length);
                    Console.WriteLine(yc[ycIndex]);
                    yanlis++;
                }

                if (yanlis >= hak)
                {
                    Console.WriteLine("Scorpion: Get ready to be my dinner!");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("Scorpion: You’re smarter than you look. I’ll show you the way out.");

            IslandSurvival.Island Island = new IslandSurvival.Island();
            Island.IslandPart(isim);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        // Alttaki fonksiyonu CHATGPT yardımıyla buldum.
        private void PrintWithPause(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
