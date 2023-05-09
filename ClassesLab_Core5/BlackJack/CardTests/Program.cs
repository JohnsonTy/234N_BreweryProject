using System;
using CardClasses;

namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {

            // TestCardConstructors();
            // TestCardToString();
            // TestCardPropertyGetters();
            // TestCardPropertySetters();
            // TestCardPropertySettersWithExceptions();
            
            Card c2 = new Card(1, 4);
            TestHasMatchingSuit(c2);
            TestHasMatchingValue(c2);
            
            // TestIsAce();
            // TestIsFaceCard();
            // TestIsRed();
            // TestIsBlack();
            // TestIsClub();
            // TestIsDiamond();
            // TestIsHeart();
            // TestIsSpade();
        }

        // test methods
        static void TestCardConstructors()
        {
            Card c1 = new Card();
            Card c2 = new Card(12, 3);

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("(Default constructor) Expect: default values (0, 0): " + c1.ToString());
            Console.WriteLine("(Overloaded constructor) Expect: Queen of Hearts: " + c2.ToString());
            Console.WriteLine();
        }

        static void TestCardToString()
        {
            Card d1 = new Card(12, 3);

            Console.WriteLine("Testing ToString");
            Console.WriteLine("(Expect: Queen of Hearts): " + d1.ToString());
            Console.WriteLine("(Expect: Queen of Hearts): " + d1);
            Console.WriteLine();
        }

        static void TestCardPropertyGetters()
        {
            Card c1 = new Card(1, 2);

            Console.WriteLine("Testing getters");
            Console.WriteLine("Expect 1. " + c1.Value);
            Console.WriteLine("Expect 2. " + c1.Suit);
            Console.WriteLine();
        }

        static void TestCardPropertySetters()
        {
            Card c1 = new Card(1, 4);

            Console.WriteLine("Testing setters");
            c1.Value = 1;
            c1.Suit = 4;
            Console.WriteLine("(Expect Ace of Spades): " + c1);
            Console.WriteLine();
        }

        static void TestCardPropertySettersWithExceptions()
        {
            Card c1 = new Card(5, 4);

            Console.WriteLine("Testing invalid setter values");
            try
            {
                c1.Value = -1;
            }
            catch
            {
                Console.WriteLine("Threw an exception when negative");
                Console.WriteLine("(c1.Value should still be 5): " + c1.Value);
            }

            try
            {
                c1.Suit = 13;
            }
            catch
            {
                Console.WriteLine("Threw an exception when greater than 4");
                Console.WriteLine("(c1.Suit should still be 4): " + c1.Suit);
            }
        }

        static void TestHasMatchingSuit(Card other)
        {
            Card c1 = new Card(1, 4);

            Console.WriteLine("Testing HasMatchingSuit");
            Console.WriteLine("(Expect Matching Suit): ");
            Console.WriteLine(c1.HasMatchingSuit(other) ? "Matching suit" : "Not matching suit");
        }

        static void TestHasMatchingValue(Card other)
        {
            Card c1 = new Card(1, 4);

            Console.WriteLine("Testing HasMatchingValue");
            Console.WriteLine("(Expect Matching Value): ");
            Console.WriteLine(c1.HasMatchingSuit(other) ? "Matching Value" : "Not matching Value");
        }

        static void TestIsAce()
        {
            Card c1 = new Card(1, 4);

            Console.WriteLine("Testing IsAce");
            Console.WriteLine("(Expect Ace): ");
            Console.WriteLine(c1.IsAce() ? "Ace" : "Not Ace");
        }

        static void TestIsFaceCard()
        {
            Card c1 = new Card(11, 4);

            Console.WriteLine("Testing IsFaceCard");
            Console.WriteLine("(Expect Face Card): ");
            Console.WriteLine(c1.IsFaceCard() ? "Face Card" : "Not Face Card");
        }

        static void TestIsRed()
        {
            Card c1 = new Card(1, 3);

            Console.WriteLine("Testing IsRed");
            Console.WriteLine("(Expect Red): ");
            Console.WriteLine(c1.IsRed() ? "Red" : "Not Red");
        }

        static void TestIsBlack()
        {
            Card c1 = new Card(1, 4);

            Console.WriteLine("Testing IsBlack");
            Console.WriteLine("(Expect Black): ");
            Console.WriteLine(c1.IsBlack() ? "Black" : "Not Black");
        }

        static void TestIsClub()
        {
            Card c1 = new Card(1, 1);

            Console.WriteLine("Testing IsClub");
            Console.WriteLine("(Expect Club): ");
            Console.WriteLine(c1.IsClub() ? "Club" : "Not Club");
        }

        static void TestIsDiamond()
        {
            Card c1 = new Card(1, 2);

            Console.WriteLine("Testing IsDiamond");
            Console.WriteLine("(Expect Diamond): ");
            Console.WriteLine(c1.IsDiamond() ? "Diamond" : "Not Diamond");
        }

        static void TestIsHeart()
        {
            Card c1 = new Card(1, 3);

            Console.WriteLine("Testing IsHeart");
            Console.WriteLine("(Expect Heart): ");
            Console.WriteLine(c1.IsHeart() ? "Heart" : "Not Heart");
        }

        static void TestIsSpade()
        {
            Card c1 = new Card(1, 4);

            Console.WriteLine("Testing IsSpade");
            Console.WriteLine("(Expect Spade): ");
            Console.WriteLine(c1.IsSpade() ? "Spade" : "Not Spade");
        }
    }
}
