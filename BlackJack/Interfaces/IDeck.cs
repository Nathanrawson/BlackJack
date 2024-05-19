namespace BlackJack
{
    public interface IDeck
    {
        IList<ICard> GetCards();

        void Shuffle();

        ICard? Deal();
    }
}
