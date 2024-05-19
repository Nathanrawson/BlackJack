namespace BlackJack
{
    public class Shuffler: IShuffler
    {
        public void Shuffle(IList<ICard> cards)
        {
            Random random = new Random();
            int deckCount = cards.Count;

            while (deckCount > 1)
            {
                deckCount--;
                int randomIndex = random.Next(deckCount + 1);
                ICard tempCard = cards[randomIndex];
                cards[randomIndex] = cards[deckCount];
                cards[deckCount] = tempCard;
            }
        }
    }
}
