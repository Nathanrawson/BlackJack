namespace BlackJack
{
    public class Dealer: IDealer
    {
        public ICard? Deal(IList<ICard> cards)
        {
            if (cards.Count == 0)
                return null;

            ICard cardToDeal = cards[0];
            cards.RemoveAt(0);
            return cardToDeal;
        }
    }
}
