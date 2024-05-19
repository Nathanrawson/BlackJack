using BlackJack.Enums;

namespace BlackJack
{
    public interface ICard
    {
        SuitType SuitType { get; set; }

        Rank Rank { get; set; } 
    }
}
