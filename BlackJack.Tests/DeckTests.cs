using BlackJack.Interfaces;
namespace BlackJack.Tests
{
    public class DeckTests
    {
        private readonly IDeckFactory deckFactory;
        private readonly IShuffler shuffler;
        private readonly IDealer dealer;

        public DeckTests()
        {
            deckFactory = new DeckFactory();
            shuffler = new Shuffler();
            dealer = new Dealer();
        }

        [Fact]
        public void DeckContains52CardsWithNoDuplicates()
        {
            // Arrange
            IDeck deck = new Deck(deckFactory, shuffler, dealer);

            // Act
            IList<ICard> cards = deck.GetCards();

            // Assert
            Assert.Equal(52, cards.Count);
            Assert.Equal(52, cards.Distinct().Count());
        }

        [Fact]
        public void OrderOfCardsIsDifferentAfterBeingShuffled()
        {
            // Arrange
            IDeck deck = new Deck(deckFactory, shuffler, dealer);
            IList<ICard> originalDeck = new List<ICard>(deck.GetCards());

            // Act
            deck.Shuffle();
            IList<ICard> shuffledDeck = deck.GetCards();

            // Assert
            Assert.NotEqual(originalDeck, shuffledDeck);
        }

        [Fact]
        public void NumberOfCardsAvailableAfterDealingIsReduced()
        {
            // Arrange
            IDeck deck = new Deck(deckFactory, shuffler, dealer);
            IList<ICard> cards = deck.GetCards();
            int initialCount = cards.Count;

            // Act
            ICard? dealtCard = deck.Deal();
            int remainingCount = cards.Count;

            // Assert
            Assert.NotNull(dealtCard);
            Assert.Equal(initialCount - 1, remainingCount);
        }

        [Fact]
        public void DealtCardIsRemovedFromDeck()
        {
            // Arrange
            IDeck deck = new Deck(deckFactory, shuffler, dealer);
            IList<ICard> cards = deck.GetCards();
            ICard firstCard = cards[0];

            // Act
            ICard? dealtCard = deck.Deal();
            IList<ICard> remainingCards = deck.GetCards();

            // Assert
            Assert.Equal(firstCard, dealtCard); 
            Assert.DoesNotContain(dealtCard, remainingCards);
        }
    }
}