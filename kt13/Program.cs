using System;
using System.Text;

namespace kt13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Card[] cards =
            {
                new Card(Suit.Hearts, Rank.Ace),
                new Card(Suit.Diamonds, Rank.King),
                new Card(Suit.Clubs, Rank.Queen),
                new Card(Suit.Spades, Rank.Jack)
            };

            Console.WriteLine("До изменения копии");

            Card copy = cards[0];
            copy.Rank = Rank.Two;

            Console.WriteLine($"Копия после изменения: {copy}");
            Console.WriteLine($"Исходная карта после изменения копии: {cards[0]}");

            Console.WriteLine();

            bool result1 = Enum.TryParse<Rank>("King", out var r1);

            Console.WriteLine($"TryParse(\"King\"): {r1}");
            Console.WriteLine($"result1: {r1}");
            Console.WriteLine($"result1 == Rank.King: {r1 == Rank.King}");

            Console.WriteLine();

            bool result2 = Enum.TryParse<Rank>("Joker", out var r2);

            Console.WriteLine($"TryParse(\"Joker\"): {result2}");
            Console.WriteLine($"result2: {r2}");
        }
    }
}