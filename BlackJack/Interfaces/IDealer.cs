namespace BlackJack
{
    public interface IDealer
    {
        ICard? Deal(IList<ICard> cards);
    }
}
