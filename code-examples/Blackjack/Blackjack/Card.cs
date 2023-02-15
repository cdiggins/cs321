namespace Blackjack
{
    public class Card
    {
        public Rank Rank;
        public Suit Suit;

        public override string ToString()
            => $"{RankToString(Rank)}{SuitToChar(Suit)}";

        public int HardValue 
            => RankToValue(Rank, true);
        
        public int SoftValue 
            => RankToValue(Rank, false);

        public static string RankToString(Rank rank)
        {
            switch (rank)
            {
                case Rank.Two: return "2";
                case Rank.Three: return "3";
                case Rank.Four: return "4";
                case Rank.Five: return "5";
                case Rank.Six: return "6";
                case Rank.Seven: return "7";
                case Rank.Eight: return "8";
                case Rank.Nine: return "9";
                case Rank.Ten: return "10";
                case Rank.Jack: return "J";
                case Rank.Queen: return "Q";
                case Rank.King: return "K";
                case Rank.Ace: return "A";
            }
            return "?";
        }

        public static char SuitToChar(Suit suit)
        {
            switch (suit)
            {
                case Suit.Hearts: return '♥';
                case Suit.Diamonds: return '♦';
                case Suit.Spades: return '♠';
                case Suit.Clubs: return '♣';
            }
            return '?';
        }

        public static int RankToValue(Rank rank, bool hard)
        {
            switch (rank)
            {
                case Rank.Two: return 2;
                case Rank.Three: return 3;
                case Rank.Four: return 4;
                case Rank.Five: return 5;
                case Rank.Six: return 6;
                case Rank.Seven: return 7;
                case Rank.Eight: return 8;
                case Rank.Nine: return 9;
                case Rank.Ten: return 10;
                case Rank.Jack: return 10;
                case Rank.Queen: return 10;
                case Rank.King: return 10;
                case Rank.Ace: return hard ? 1 : 11;
            }
            return 0; ;
        }
    }
}