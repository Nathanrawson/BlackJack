using BlackJack.Enums;

namespace BlackJack
{
    public class Card : ICard
    {
        public SuitType SuitType { get; set; }

        public Rank Rank { get; set; }
    }
}
