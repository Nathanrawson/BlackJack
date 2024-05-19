using BlackJack.Enums;

namespace BlackJack
{
    public class DeckFactory : IDeckFactory
    {
        public IList<ICard> CreateDeck()
        {
            List<ICard> deck = new List<ICard>();

            foreach (SuitType suit in Enum.GetValues(typeof(SuitType)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    deck.Add(new Card
                    {
                        SuitType = suit,
                        Rank = rank
                    });
                }
            }

            return deck;
        }
    }
}
