namespace BlackJack
{
    public class Deck : IDeck
    {
        private readonly IDeckFactory deckFactory;
        private readonly IShuffler shuffler;
        private readonly IDealer dealer;
        private IList<ICard> cards;

        public Deck(IDeckFactory deckFactory, IShuffler shuffler, IDealer dealer)
        {
            this.deckFactory = deckFactory;
            this.shuffler = shuffler;
            this.dealer = dealer;
            this.cards = this.deckFactory.CreateDeck();
        }

        public IList<ICard> GetCards()
        {
            return cards;
        }

        public void Shuffle()
        {
            shuffler.Shuffle(cards);
        }

        public ICard? Deal()
        {
            return dealer.Deal(cards);
        }
    }
}
