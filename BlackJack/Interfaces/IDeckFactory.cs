namespace BlackJack
{
    public interface IDeckFactory
    {
        IList<ICard> CreateDeck();
    }
}
