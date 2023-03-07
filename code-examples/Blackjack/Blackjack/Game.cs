namespace Blackjack
{
    public class Game
    {
        private Deck Deck = new Deck();
        private Player Dealer = new Player();
        private Player Player = new Player();

        public bool CanPlayerHit
            => Player.CanHit;

        public bool CanDealerHit
            => !Dealer.Hand.IsBust
                && Dealer.Hand.SoftValue < 17;
    
        public void DealPlayerCard()
        {
            if (!Player.CanHit)
            {
                Console.WriteLine("Player cannot hit");
                return;
            }
            var card = Deck.DealCard();
            Console.WriteLine($"You were dealt a {card}");
            Player.Hand.Cards.Add(card);
        }

        public void DealDealerCard()
        {
            if (!CanDealerHit)
            {
                Console.WriteLine("Dealer cannot hit");
                return;
            }
            var card = Deck.DealCard();
            Console.WriteLine($"Dealer was dealt a {card}");
            Dealer.Hand.Add(card);
        }

        public int ComputePayout()
        {
            var bet = Player.Bet;            
            if (Player.Hand.IsBust)
                return 0;
            if (Dealer.Hand.IsBlackjack && Player.Hand.IsBlackjack)
                return bet;
            if (Player.Hand.IsBlackjack) 
                return bet + bet * 3 / 2;
            if (Dealer.Hand.IsBust)
                return bet + bet;
            if (Player.Hand.Value > Dealer.Hand.Value)
                return bet + bet;
            if (Player.Hand.Value == Dealer.Hand.Value)
                return bet;
            return 0;
        }
    }
}