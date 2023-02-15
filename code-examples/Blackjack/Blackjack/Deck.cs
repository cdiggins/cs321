namespace Blackjack
{
    public class Deck
    {
        public Deck()
        {
            Reset();
        }

        public List<Card> Cards = new List<Card>();

        public void Shuffle()
        {
            var rnd = new Random();
            for (var i=0; i < Cards.Count; ++i)
            {
                var tmp = rnd.Next(Cards.Count);
                (Cards[i], Cards[tmp]) = (Cards[tmp], Cards[i]);
            }
        }

        public Card DealCard() 
        {
            if (IsEmpty)
                Reset();
            var last = Cards.Count - 1;
            var card = Cards[last];
            Cards.RemoveAt(last);
            return card;
        }

        public void Reset()
        {
            Cards.AddRange(NewPack());
            Shuffle();
        }

        public bool IsEmpty
            => Cards.Count == 0;

        public static IEnumerable<Card> NewPack()
        {
            foreach (var suit in Enum.GetValues<Suit>())
                foreach (var rank in Enum.GetValues<Rank>())
                    yield return new Card() { Rank = rank, Suit = suit };
        }

    }
}