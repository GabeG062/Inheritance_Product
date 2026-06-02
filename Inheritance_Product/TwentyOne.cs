using System;
using CardClasses;

namespace CardClasses
{
    public class TwentyOne
    {
        public void Play()
        {
            Deck deck = new Deck();
            deck.Shuffle();

            BJHand playerHand = new BJHand(deck, 2);
            BJHand dealerHand = new BJHand(deck, 2);

            Console.WriteLine("Welcome to 21!");
            Console.WriteLine();

            bool playerTurn = true;

            while (playerTurn && !playerHand.isBusted)
            {
                Console.WriteLine("Your hand:");
                Console.WriteLine(playerHand);
                Console.WriteLine("Your score: " + playerHand.Score);
                Console.WriteLine();

                Console.WriteLine("Dealer is showing:");
                Console.WriteLine(dealerHand.GetCard(0));
                Console.WriteLine();

                Console.Write("Would you like to HIT or STAND? ");
                string choice = Console.ReadLine();

                if (choice != null)
                {
                    choice = choice.ToUpper();
                }

                if (choice == "HIT")
                {
                    Card newCard = deck.Deal();
                    playerHand.AddCard(newCard);

                    Console.WriteLine();
                    Console.WriteLine("You drew: " + newCard);
                    Console.WriteLine();
                }
                else if (choice == "STAND")
                {
                    playerTurn = false;
                }
                else
                {
                    Console.WriteLine("Please type HIT or STAND.");
                    Console.WriteLine();
                }
            }

            if (playerHand.isBusted)
            {
                Console.WriteLine("Your hand:");
                Console.WriteLine(playerHand);
                Console.WriteLine("Your score: " + playerHand.Score);
                Console.WriteLine("You busted! Dealer wins.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Dealer's turn.");
            Console.WriteLine();

            while (dealerHand.Score <= 16)
            {
                Card newCard = deck.Deal();
                dealerHand.AddCard(newCard);

                Console.WriteLine("Dealer hits and draws: " + newCard);
            }

            Console.WriteLine();
            Console.WriteLine("Final hands:");
            Console.WriteLine();

            Console.WriteLine("Your hand:");
            Console.WriteLine(playerHand);
            Console.WriteLine("Your score: " + playerHand.Score);
            Console.WriteLine();

            Console.WriteLine("Dealer's hand:");
            Console.WriteLine(dealerHand);
            Console.WriteLine("Dealer score: " + dealerHand.Score);
            Console.WriteLine();

            if (dealerHand.isBusted)
            {
                Console.WriteLine("Dealer busted! You win!");
            }
            else if (playerHand.Score > dealerHand.Score)
            {
                Console.WriteLine("You win!");
            }
            else if (playerHand.Score < dealerHand.Score)
            {
                Console.WriteLine("Dealer wins!");
            }
            else
            {
                Console.WriteLine("Push! It is a tie.");
            }
        }
    }
}