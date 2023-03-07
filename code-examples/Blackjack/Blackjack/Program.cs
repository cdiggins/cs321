using System.Diagnostics;

namespace Blackjack
{
    // https://en.wikipedia.org/wiki/Blackjack
    public static class Program
    {
        public static int QueryBet(Player player)
        {
            Console.WriteLine($"You have {player.Money}. How much do you want to bet?");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                return 10;
            }
            return int.Parse(input);
        }

        public static void OutputHand(Hand hand)
        {
            Console.WriteLine(hand);
            var hardOrSoft = hand.IsSoft ? "soft" : "hard";
            Console.WriteLine($"The value is a {hardOrSoft} {hand.Value}");
            if (hand.IsBlackjack)
            {
                Console.WriteLine("This hand is a blackjack!");
            }
            if (hand.IsBust)
            {
                Console.WriteLine("This hand is bust!");
            }
        }

        public static void OutputDeck(Deck deck)
        {
            Console.WriteLine($"The deck has {deck.Cards.Count} cards left:");
            foreach (var card in deck.Cards)
            {
                Console.WriteLine($"  {card}");
            }
        }

        public static void OutputGame(Game game)
        {
            Console.WriteLine($"The deck has {game.Deck.Cards.Count} cards left");
            Console.WriteLine($"Your current bet is {game.Player.Bet} of {game.Player.Money}");
            Console.WriteLine("Your hand is:");
            OutputHand(game.Player.Hand);

            Console.WriteLine("The dealer hand is:");
            OutputHand(game.Dealer.Hand);
        }

        public static void Main()
        {
            var game = new Game();            
            
            while (true)
            {
                var amount = QueryBet(game.Player);
                game.Player.Money -= amount;
                game.Player.Bet = amount;

                game.DealPlayerCard();
                game.DealPlayerCard();
                game.DealDealerCard();

                OutputGame(game);

                while (true)
                {
                    Console.WriteLine("Do you want to (h)it, (s)tand, (d)ouble, s(u)rrender, (q)uit, or see dec(k)?");
                    var c = Console.ReadKey(true);
                    if (c.KeyChar == 'h')
                    {
                        game.DealPlayerCard();
                    }
                    else if (c.KeyChar == 's')
                    {
                        break;
                    }
                    else if (c.KeyChar == 'd')
                    {
                        game.Player.Double();
                        game.DealPlayerCard();
                        break;
                    }
                    else if (c.KeyChar == 'u')
                    {
                        game.Player.Surrender();
                        break;
                    }
                    else if (c.KeyChar == 'k')
                    {
                        OutputDeck(game.Deck);
                    }
                    else if (c.KeyChar == 'q')
                    {
                        return;
                    }
                }

                Debug.Assert(game.Player.Hand.Cards.Count >= 2);
                Debug.Assert(game.Dealer.Hand.Cards.Count == 1);

                // Don't continue if the user bet nothing (e.g., surrendered)
                if (game.Player.Bet > 0 && !game.Player.Hand.IsBust)
                {
                    while (game.CanDealerHit)
                    {
                        game.DealDealerCard();
                    }
                }

                OutputGame(game);
                var payout = game.ComputePayout();
                Console.WriteLine($"Your payout is {payout}");
                game.Player.Money += payout;
                game.Player.Hand.Cards.Clear();
                game.Player.Bet = 0;
                game.Dealer.Hand.Cards.Clear();
            }
        }
    }
}