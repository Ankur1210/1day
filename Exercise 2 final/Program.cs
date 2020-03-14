using System;
using ProgrammingAssignment2;

namespace Exercise_2_final
{
    #region
    public class Person1
    {
        public string rank;
        public string suit;
        public string Rank
        {
            
            get{ return rank; }
            set { rank = value; }
        }
        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }
    }
    #endregion

    #region
    public class Person2
    {
        public string rank;
        public string suit;
        public string Rank
        {

            get { return rank; }
            set { rank = value; }
        }
        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }
    }
    #endregion
    #region
    public class Person3
    {
        public string rank;
        public string suit;
        public string Rank
        {

            get { return rank; }
            set { rank = value; }
        }
        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck.Shuffle();

            Card card1 = deck.TakeTopCard();
            Card card2 = deck.TakeTopCard();
            Card card3 = deck.TakeTopCard();

            Person1 select11 = new Person1();
            Person2 select21 = new Person2();
            Person3 select31 = new Person3();

            //Assigning values to choice of Players in 1 go of ditribution
            select11.rank = card1.Rank;
            select11.suit = card1.Suit;

            select21.rank = card2.Rank;
            select21.suit = card2.Suit;

            select31.rank = card3.Rank;
            select31.suit = card3.Suit;
            
            Card card4 = deck.TakeTopCard();
            Card card5 = deck.TakeTopCard();
            Card card6 = deck.TakeTopCard();


            Person1 select12 = new Person1();
            Person2 select22 = new Person2();
            Person3 select32 = new Person3();
            
            //Assigning values in 2 go of distribution
            select12.rank = card4.Rank;
            select12.suit = card4.Suit;

            select22.rank = card5.Rank;
            select22.suit = card5.Suit;

            select32.rank = card6.Rank;
            select32.suit = card6.Suit;

            //Flip Over the cards
            card1.FlipOver();
            card2.FlipOver(); 
            card3.FlipOver();
            card4.FlipOver();
            card5.FlipOver();
            card6.FlipOver();


            //Printing cards for player 1
            Console.WriteLine("PLayer 1 card:");
            Console.WriteLine(select11.rank + " OF " + select11.suit);
            Console.WriteLine(select12.rank + " OF " + select12.suit);


            //Printing cards for player 2
            Console.WriteLine();
            Console.WriteLine("PLayer 2 Cards:");
            Console.WriteLine(select21.rank + " OF " + select21.suit);
            Console.WriteLine(select22.rank + " OF " + select22.suit);


            //Printing cards for player 1
            Console.WriteLine();
            Console.WriteLine("PLayer 3 Cards:");
            Console.WriteLine(select31.rank + " OF " + select31.suit);
            Console.WriteLine(select32.rank + " OF " + select32.suit);


            Console.WriteLine();
        }
    }
}
