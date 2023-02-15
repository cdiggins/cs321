namespace Blackjack
{
    public class Player   
    {
        public int Money = 100;
        public Hand Hand = new Hand();
        public int Bet = 0; 
        
        public void Double()
        {
            Money -= Bet;
            Bet += Bet;
        }

        public bool CanHit
            => !Hand.IsBust && !Hand.IsBlackjack;            

        public void Surrender()
        {
            Money += Bet / 2;
            Bet = 0;
        }

        public bool CanSurrender
            => Hand.Cards.Count == 2;
    }
}