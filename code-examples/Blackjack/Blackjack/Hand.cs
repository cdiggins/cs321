namespace Blackjack
{
    public class Hand
    {
        public List<Card> Cards = new List<Card>();

        public void Add(Card card)
            => Cards.Add(card);

        public bool IsBlackjack
            => Cards.Count == 2 && SoftValue == 21;

        public int HardValue
            => Cards.Sum(c => c.HardValue);

        public int SoftValue
            => Cards.Sum(c => c.SoftValue);

        public bool HasAce
            => Cards.Any(c => c.Rank == Rank.Ace);

        public bool IsSoft
            => HasAce && SoftValue <= 21;

        public int Value
            => IsBust ? 0 : IsSoft ? SoftValue : HardValue;

        public bool IsBust
            => HardValue > 21;

        public override string ToString()
            => string.Join(", ", Cards);
    }
}