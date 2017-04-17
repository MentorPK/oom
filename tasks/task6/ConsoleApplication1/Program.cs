using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;
using System.Reactive.Linq;
using System.Threading;

namespace Task6
{
    class AllCards
    {
        static void Task61a (List<Card> CardGameX)
        {          
                var subject = new Subject<Card>();

                subject
                    .Take(CardGameX.Count)
                    .Sum(card => card.mana)
                    .Subscribe(mana =>
                    {
                        Console.WriteLine("Mana: " + mana);
                    });

                foreach (Card c in CardGameX)
                {
                    //Console.WriteLine("Adding element to Observable " + c.Name);
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    subject.OnNext(c);
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + ": Added element to Observable " + c.name);
                }           
        }

        static void Task61b (Player player)
        {
            var observable = player.Hand.ToObservable();
            observable
                .MinBy(card => card.mana)
                .Subscribe(cards =>
                {
                    foreach (Card c in cards)
                    {
                        Console.WriteLine("Card with lowest mana: " + c.name);
                    }
                });
        }

        static void Task62(List<Card> allCards)
        {
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < 4; i++)
            {
                Task result = Task.Run(() =>
                {
                    Task61a(allCards);
                });
                result.ContinueWith((t) => Console.WriteLine("Task finished!"));
                tasks.Add(result);
            }

            foreach (Task t in tasks)
            {
                t.Wait();
            }
        }
        /* //Async Beispiel#
       
        async static Task<double> ComputePi()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(15));
                return 3.14;
            });
        }

        void Task62_async()
        {
            Task<double> piTask = ComputePi();
            piTask.ContinueWith((t) => Console.WriteLine("Pi = " + t.Result));
            piTask.Wait();
        }
        */
        static void Main(string[] args)
        {
            var CardgameX = new List<Card>()
                {
                    new Creature("Gandros",2, 5, 1,"Orc"),
                    new Creature("Aiunas", 4, 3, 5, "Elf"),
                    new Creature("Tandros",5, 5, 5,"Human"),
                    new Creature("Salasaur",8, 6, 9,"Dragon"),
                    new Spell("Frostbolt",2, 3,"Freeze"),
                    new Spell("Firebolt",4, 6,"Burning"),
                    new Spell("Shadowbolt",3, 2,"Weakness"),
                };

            foreach (var xy in CardgameX)
            {
                Console.WriteLine("Name:{0}, Mana:{1}, Power:{2}, ", xy.name, xy.mana, xy.powerlvl);
                xy.text();
            }

            GameState state = new GameState(new Player(), new Player(), CardgameX);

            state.player1.PullCards(state, 4);
            state.player2.PullCards(state, 4);

            Console.ReadKey();
            Console.Clear();

            foreach (Card card in state.player1.Hand)
            {
                Console.WriteLine(card.name);
            }

            Console.ReadKey();
            Console.Clear();

            foreach (Card card in state.player2.Hand)
            {
                Console.WriteLine(card.name);
            }

            Console.ReadKey();
            Console.Clear();

            Task61b(state.player1);

            Console.ReadKey();
            Console.Clear();

            Task62(CardgameX);
            



        }
    }
}
