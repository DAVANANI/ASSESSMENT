using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerChallengeRef;

namespace PokerChallengeDemo
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("------------------------------------------");
        //    Console.WriteLine("Hand 1");
        //    Console.WriteLine("------------------------------------------");
        //    //Create object for the first game
        //    PlayPokerGame PokerFirstGame = new PlayPokerGame();

        //    //Create object players
        //    PokerPlayer Joe = new PokerPlayer("Joe");
        //    PokerPlayer Sally = new PokerPlayer("Sally");
        //    PokerPlayer Bob = new PokerPlayer("Bob");
        //    PokerPlayer Jen = new PokerPlayer("Jen");

        //    //Added players to the first poker game object
        //    PokerFirstGame.AddPlayer(Joe);
        //    PokerFirstGame.AddPlayer(Sally);
        //    PokerFirstGame.AddPlayer(Bob);

        //    //Assign cards to the players using poker game object
        //    PokerFirstGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.S });
        //    PokerFirstGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.D });
        //    PokerFirstGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.D });
        //    PokerFirstGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.D });
        //    PokerFirstGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Jack, Suit = SuitType.H });

        //    Console.WriteLine(Joe.Name + ":" + RankType.Eight + SuitType.S + "," + RankType.Eight + SuitType.D + "," + RankType.Ace + SuitType.D + "," + RankType.Queen + SuitType.D + "," + RankType.Jack + SuitType.H);

        //    PokerFirstGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Four, Suit = SuitType.S });
        //    PokerFirstGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Four, Suit = SuitType.H });
        //    PokerFirstGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Three, Suit = SuitType.H });
        //    PokerFirstGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.C });
        //    PokerFirstGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.C });

        //    Console.WriteLine(Sally.Name + ":" + RankType.Four + SuitType.S + "," + RankType.Four + SuitType.H + "," + RankType.Three + SuitType.H + "," + RankType.Queen + SuitType.C + "," + RankType.Eight + SuitType.C);

        //    PokerFirstGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.S });
        //    PokerFirstGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.S });
        //    PokerFirstGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.S });
        //    PokerFirstGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Six, Suit = SuitType.S });
        //    PokerFirstGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Four, Suit = SuitType.S });

        //    Console.WriteLine(Bob.Name + ":" + RankType.Ace + SuitType.S + "," + RankType.Queen + SuitType.S + "," + RankType.Eight + SuitType.S + "," + RankType.Six + SuitType.S + "," + RankType.Four + SuitType.S);
        //    //Evaluate and get the first winner
        //    PokerHand firstWinner = PokerFirstGame.GetWinner();

        //    Console.WriteLine(firstWinner.Name + " wins!");

        //    Console.WriteLine("------------------------------------------");
        //    Console.WriteLine("Hand 2");
        //    Console.WriteLine("------------------------------------------");


        //    //Create object for the Second game            
        //    PlayPokerGame PokerSecondGame = new PlayPokerGame();

        //    //Used the same object for the player and cleared the cards for the new round
        //    Joe.ClearCards();
        //    Bob.ClearCards();
        //    Sally.ClearCards();

        //    //Added players to the second poker game object
        //    PokerSecondGame.AddPlayer(Joe);
        //    PokerSecondGame.AddPlayer(Sally);
        //    PokerSecondGame.AddPlayer(Bob);

        //    //Assign cards to the players using poker game object
        //    PokerSecondGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.D });
        //    PokerSecondGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.D });
        //    PokerSecondGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.King, Suit = SuitType.D });
        //    PokerSecondGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Seven, Suit = SuitType.D });
        //    PokerSecondGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Three, Suit = SuitType.D });

        //    Console.WriteLine(Joe.Name + ":" + RankType.Queen + SuitType.D + "," + RankType.Eight + SuitType.D + "," + RankType.King + SuitType.D + "," + RankType.Seven + SuitType.D + "," + RankType.Three + SuitType.D);

        //    PokerSecondGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Four, Suit = SuitType.S });
        //    PokerSecondGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Four, Suit = SuitType.H });
        //    PokerSecondGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Three, Suit = SuitType.H });
        //    PokerSecondGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.C });
        //    PokerSecondGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.C });

        //    Console.WriteLine(Sally.Name + ":" + RankType.Four + SuitType.S + "," + RankType.Four + SuitType.H + "," + RankType.Three + SuitType.H + "," + RankType.Queen + SuitType.C + "," + RankType.Eight + SuitType.C);

        //    PokerSecondGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.S });
        //    PokerSecondGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.S });
        //    PokerSecondGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.S });
        //    PokerSecondGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Six, Suit = SuitType.S });
        //    PokerSecondGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Four, Suit = SuitType.S });

        //    Console.WriteLine(Bob.Name + ":" + RankType.Ace + SuitType.S + "," + RankType.Queen + SuitType.S + "," + RankType.Eight + SuitType.S + "," + RankType.Six + SuitType.S + "," + RankType.Four + SuitType.S);

        //    //Evaluate and get the second winner
        //    PokerHand secondWinner = PokerSecondGame.GetWinner();

        //    Console.WriteLine(secondWinner.Name + " wins!");

        //    Console.WriteLine("------------------------------------------");
        //    Console.WriteLine("Hand 3");
        //    Console.WriteLine("------------------------------------------");


        //    //Create object for the Third game            
        //    PlayPokerGame PokerThirdGame = new PlayPokerGame();

        //    //Used the same object for the player and cleared the cards for the new round
        //    Joe.ClearCards();
        //    Bob.ClearCards();
        //    Sally.ClearCards();
        //    Jen.ClearCards();

        //    //Added players to the Third poker game object
        //    PokerThirdGame.AddPlayer(Joe);
        //    PokerThirdGame.AddPlayer(Jen);
        //    PokerThirdGame.AddPlayer(Bob);

        //    //Assign cards to the players using poker game object
        //    PokerThirdGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Three, Suit = SuitType.H });
        //    PokerThirdGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Five, Suit = SuitType.D });
        //    PokerThirdGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Nine, Suit = SuitType.C });
        //    PokerThirdGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Nine, Suit = SuitType.D });
        //    PokerThirdGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.H });

        //    Console.WriteLine(Joe.Name + ":" + RankType.Three + SuitType.H + "," + RankType.Five + SuitType.D + "," + RankType.Nine + SuitType.C + "," + RankType.Nine + SuitType.D + "," + RankType.Queen + SuitType.H);

        //    PokerThirdGame.GivePlayingCards(Jen, new PlayingCard { Rank = RankType.Five, Suit = SuitType.C });
        //    PokerThirdGame.GivePlayingCards(Jen, new PlayingCard { Rank = RankType.Seven, Suit = SuitType.D });
        //    PokerThirdGame.GivePlayingCards(Jen, new PlayingCard { Rank = RankType.Nine, Suit = SuitType.H });
        //    PokerThirdGame.GivePlayingCards(Jen, new PlayingCard { Rank = RankType.Nine, Suit = SuitType.S });
        //    PokerThirdGame.GivePlayingCards(Jen, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.S });

        //    Console.WriteLine(Jen.Name + ":" + RankType.Five + SuitType.C + "," + RankType.Seven + SuitType.D + "," + RankType.Nine + SuitType.H + "," + RankType.Nine + SuitType.S + "," + RankType.Queen + SuitType.S);

        //    PokerThirdGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Two, Suit = SuitType.H });
        //    PokerThirdGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Two, Suit = SuitType.C });
        //    PokerThirdGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Five, Suit = SuitType.S });
        //    PokerThirdGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Ten, Suit = SuitType.C });
        //    PokerThirdGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.H });

        //    Console.WriteLine(Bob.Name + ":" + RankType.Two + SuitType.H + "," + RankType.Two + SuitType.C + "," + RankType.Five + SuitType.S + "," + RankType.Ten + SuitType.C + "," + RankType.Ace + SuitType.H);

        //    //Evaluate and get the Third winner
        //    PokerHand thirdWinner = PokerThirdGame.GetWinner();

        //    Console.WriteLine(thirdWinner.Name + " wins!");

        //    Console.WriteLine("------------------------------------------");
        //    Console.WriteLine("Hand 4");
        //    Console.WriteLine("------------------------------------------");

        //    //Create object for the Fourth game            
        //    PlayPokerGame PokerFourthGame = new PlayPokerGame();

        //    //Used the same object for the player and cleared the cards for the new round
        //    Joe.ClearCards();
        //    Bob.ClearCards();
        //    Sally.ClearCards();
        //    Jen.ClearCards();

        //    //Added players to the Fourth poker game object
        //    PokerFourthGame.AddPlayer(Joe);
        //    PokerFourthGame.AddPlayer(Jen);
        //    PokerFourthGame.AddPlayer(Bob);

        //    //Assign cards to the players using poker game object
        //    PokerFourthGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Two, Suit = SuitType.H });
        //    PokerFourthGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Three, Suit = SuitType.D });
        //    PokerFourthGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Four, Suit = SuitType.C });
        //    PokerFourthGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Five, Suit = SuitType.D });
        //    PokerFourthGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Ten, Suit = SuitType.H });

        //    Console.WriteLine(Joe.Name + ":" + RankType.Two + SuitType.H + "," + RankType.Three + SuitType.D + "," + RankType.Four + SuitType.C + "," + RankType.Five + SuitType.D + "," + RankType.Ten + SuitType.H);

        //    PokerFourthGame.GivePlayingCards(Jen, new PlayingCard { Rank = RankType.Five, Suit = SuitType.C });
        //    PokerFourthGame.GivePlayingCards(Jen, new PlayingCard { Rank = RankType.Seven, Suit = SuitType.D });
        //    PokerFourthGame.GivePlayingCards(Jen, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.H });
        //    PokerFourthGame.GivePlayingCards(Jen, new PlayingCard { Rank = RankType.Nine, Suit = SuitType.S });
        //    PokerFourthGame.GivePlayingCards(Jen, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.D });

        //    Console.WriteLine(Jen.Name + ":" + RankType.Five + SuitType.C + "," + RankType.Seven + SuitType.D + "," + RankType.Eight + SuitType.H + "," + RankType.Nine + SuitType.S + "," + RankType.Queen + SuitType.D);

        //    PokerFourthGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Two, Suit = SuitType.C });
        //    PokerFourthGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Four, Suit = SuitType.D });
        //    PokerFourthGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Five, Suit = SuitType.S });
        //    PokerFourthGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Ten, Suit = SuitType.C });
        //    PokerFourthGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Jack, Suit = SuitType.H });

        //    Console.WriteLine(Bob.Name + ":" + RankType.Two + SuitType.C + "," + RankType.Four + SuitType.D + "," + RankType.Five + SuitType.S + "," + RankType.Ten + SuitType.C + "," + RankType.Jack + SuitType.H);

        //    //Evaluate and get the Fourth winner
        //    PokerHand fourthWinner = PokerThirdGame.GetWinner();

        //    Console.WriteLine(fourthWinner.Name + " wins!");
        //    Console.ReadKey();

        //}

        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Hand 1");
            Console.WriteLine("------------------------------------------");
            //Create object for the first game
            PlayPokerGame PokerFirstGame = new PlayPokerGame();

            //Create object players
            PokerPlayer Joe = new PokerPlayer("Joe");
            PokerPlayer Sally = new PokerPlayer("Sally");
            PokerPlayer Bob = new PokerPlayer("Bob");
            PokerPlayer Jen = new PokerPlayer("Jen");

            //Added players to the first poker game object
            PokerFirstGame.AddPlayer(Joe);
            PokerFirstGame.AddPlayer(Sally);
            PokerFirstGame.AddPlayer(Bob);

            //Assign cards to the players using poker game object
            PokerFirstGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.King, Suit = SuitType.D });
            PokerFirstGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.S });
            PokerFirstGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.C });
            PokerFirstGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Seven, Suit = SuitType.D });
            PokerFirstGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Jack, Suit = SuitType.H });

            Console.WriteLine(Joe.Name + ":" + RankType.King + SuitType.D + "," + RankType.Ace + SuitType.S + "," + RankType.Queen + SuitType.C + "," + RankType.Seven + SuitType.D + "," + RankType.Jack + SuitType.H);

            PokerFirstGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.King, Suit = SuitType.S });
            PokerFirstGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.S });
            PokerFirstGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.S });
            PokerFirstGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Nine, Suit = SuitType.S });
            PokerFirstGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.S });

            Console.WriteLine(Sally.Name + ":" + RankType.King + SuitType.S + "," + RankType.Ace + SuitType.S + "," + RankType.Queen + SuitType.S + "," + RankType.Nine + SuitType.S + "," + RankType.Eight + SuitType.S);

            PokerFirstGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.King, Suit = SuitType.C });
            PokerFirstGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Four, Suit = SuitType.S });
            PokerFirstGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Six, Suit = SuitType.S });
            PokerFirstGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Two, Suit = SuitType.H });
            PokerFirstGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.S });

            Console.WriteLine(Bob.Name + ":" + RankType.King + SuitType.C + "," + RankType.Four + SuitType.S + "," + RankType.Six + SuitType.S + "," + RankType.Two + SuitType.H + "," + RankType.Queen + SuitType.S);
            //Evaluate and get the first winner
            PokerHand firstWinner = PokerFirstGame.GetWinner();

            Console.WriteLine(firstWinner.Name + " wins with " + firstWinner.Category.ToString());

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Hand 2");
            Console.WriteLine("------------------------------------------");


            //Create object for the Second game            
            PlayPokerGame PokerSecondGame = new PlayPokerGame();

            //Used the same object for the player and cleared the cards for the new round
            Joe.ClearCards();
            Bob.ClearCards();
            Sally.ClearCards();

            //Added players to the second poker game object
            PokerSecondGame.AddPlayer(Joe);
            PokerSecondGame.AddPlayer(Sally);
            PokerSecondGame.AddPlayer(Bob);

            //Assign cards to the players using poker game object
            PokerSecondGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.C });
            PokerSecondGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.D });
            PokerSecondGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.King, Suit = SuitType.H });
            PokerSecondGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Seven, Suit = SuitType.S });
            PokerSecondGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Three, Suit = SuitType.D });

            Console.WriteLine(Joe.Name + ":" + RankType.Queen + SuitType.C + "," + RankType.Eight + SuitType.D + "," + RankType.King + SuitType.H + "," + RankType.Seven + SuitType.S + "," + RankType.Three + SuitType.D);

            PokerSecondGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Two, Suit = SuitType.D });
            PokerSecondGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Four, Suit = SuitType.H });
            PokerSecondGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.King, Suit = SuitType.S });
            PokerSecondGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.S });
            PokerSecondGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Jack, Suit = SuitType.C });

            Console.WriteLine(Sally.Name + ":" + RankType.Two + SuitType.D + "," + RankType.Four + SuitType.H + "," + RankType.King + SuitType.S + "," + RankType.Queen + SuitType.S + "," + RankType.Jack + SuitType.C);

            PokerSecondGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.C });
            PokerSecondGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Nine, Suit = SuitType.S });
            PokerSecondGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.S });
            PokerSecondGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.S });
            PokerSecondGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.D });

            Console.WriteLine(Bob.Name + ":" + RankType.Ace + SuitType.C + "," + RankType.Nine + SuitType.S + "," + RankType.Eight + SuitType.S + "," + RankType.Ace + SuitType.S + "," + RankType.Queen + SuitType.D);

            //Evaluate and get the second winner
            PokerHand secondWinner = PokerSecondGame.GetWinner();

            Console.WriteLine(secondWinner.Name + " wins with " + secondWinner.Category.ToString());


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Hand 3");
            Console.WriteLine("------------------------------------------");


            //Create object for the third game            
            PlayPokerGame PokerThirdGame = new PlayPokerGame();

            //Used the same object for the player and cleared the cards for the new round
            Joe.ClearCards();
            Bob.ClearCards();
            Sally.ClearCards();

            //Added players to the third poker game object
            PokerThirdGame.AddPlayer(Joe);
            PokerThirdGame.AddPlayer(Sally);
            PokerThirdGame.AddPlayer(Bob);

            //Assign cards to the players using poker game object
            PokerThirdGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.S });
            PokerThirdGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.C });
            PokerThirdGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.D });
            PokerThirdGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Jack, Suit = SuitType.H });
            PokerThirdGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Four, Suit = SuitType.S });

            Console.WriteLine(Joe.Name + ":" + RankType.Ace + SuitType.S + "," + RankType.Ace + SuitType.C + "," + RankType.Ace + SuitType.D + "," + RankType.Jack + SuitType.H + "," + RankType.Four + SuitType.S);

            PokerThirdGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.H });
            PokerThirdGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.D });
            PokerThirdGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.S });
            PokerThirdGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.D });
            PokerThirdGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Eight, Suit = SuitType.D });

            Console.WriteLine(Sally.Name + ":" + RankType.Queen + SuitType.H + "," + RankType.Queen + SuitType.D + "," + RankType.Queen + SuitType.S + "," + RankType.Ace + SuitType.D + "," + RankType.Eight + SuitType.D);

            PokerThirdGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Two, Suit = SuitType.D });
            PokerThirdGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Two, Suit = SuitType.C });
            PokerThirdGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Two, Suit = SuitType.S });
            PokerThirdGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Jack, Suit = SuitType.H });
            PokerThirdGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Ten, Suit = SuitType.H });

            Console.WriteLine(Bob.Name + ":" + RankType.Two + SuitType.D + "," + RankType.Two + SuitType.C + "," + RankType.Two + SuitType.S + "," + RankType.Jack + SuitType.H + "," + RankType.Ten + SuitType.H);

            //Evaluate and get the third winner
            PokerHand thirdWinner = PokerThirdGame.GetWinner();

            Console.WriteLine(thirdWinner.Name + " wins with " + thirdWinner.Category.ToString());


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Hand 4");
            Console.WriteLine("------------------------------------------");


            //Create object for the four game            
            PlayPokerGame PokerfourGame = new PlayPokerGame();

            //Used the same object for the player and cleared the cards for the new round
            Joe.ClearCards();
            Bob.ClearCards();
            Sally.ClearCards();

            //Added players to the four poker game object
            PokerfourGame.AddPlayer(Joe);
            PokerfourGame.AddPlayer(Sally);
            PokerfourGame.AddPlayer(Bob);

            //Assign cards to the players using poker game object
            PokerfourGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.H });
            PokerfourGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.King, Suit = SuitType.D });
            PokerfourGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.C });
            PokerfourGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Jack, Suit = SuitType.S });
            PokerfourGame.GivePlayingCards(Joe, new PlayingCard { Rank = RankType.Six, Suit = SuitType.H });

            Console.WriteLine(Joe.Name + ":" + RankType.Ace + SuitType.H + "," + RankType.King + SuitType.D + "," + RankType.Queen + SuitType.C + "," + RankType.Jack + SuitType.S + "," + RankType.Six + SuitType.H);

            PokerfourGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.King, Suit = SuitType.H });
            PokerfourGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.D });
            PokerfourGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Jack, Suit = SuitType.C });
            PokerfourGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Seven, Suit = SuitType.S });
            PokerfourGame.GivePlayingCards(Sally, new PlayingCard { Rank = RankType.Six, Suit = SuitType.D });

            Console.WriteLine(Sally.Name + ":" + RankType.King + SuitType.H + "," + RankType.Queen + SuitType.D + "," + RankType.Jack + SuitType.C + "," + RankType.Seven + SuitType.S + "," + RankType.Six + SuitType.D);

            PokerfourGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Ace, Suit = SuitType.S });
            PokerfourGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.King, Suit = SuitType.S });
            PokerfourGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Queen, Suit = SuitType.H });
            PokerfourGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Ten, Suit = SuitType.C });
            PokerfourGame.GivePlayingCards(Bob, new PlayingCard { Rank = RankType.Four, Suit = SuitType.S });

            Console.WriteLine(Bob.Name + ":" + RankType.Ace + SuitType.S + "," + RankType.King + SuitType.S + "," + RankType.Queen + SuitType.H + "," + RankType.Ten + SuitType.C + "," + RankType.Four + SuitType.S);

            //Evaluate and get the four winner
            PokerHand fourWinner = PokerfourGame.GetWinner();

            Console.WriteLine(fourWinner.Name + " wins with " + fourWinner.Category.ToString());


            Console.ReadKey();

        }


    }

}
