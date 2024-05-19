# BlackJack Deck Implementation

## Overview

This project provides an implementation of a standard deck of playing cards for a game of Blackjack. The deck includes the following functionalities:

- Creation of a new deck with 52 unique cards, each having a suit (Hearts, Diamonds, Spades, Clubs) and a face/pip (Ace, 2-10, Jack, Queen, King).
- Methods to shuffle the deck and deal a card from the deck.
- Unit tests to validate the functionality of the deck.

## Features

1. **Deck Creation**: A method to create a new deck with 52 unique cards.
2. **Shuffling**: A method to shuffle the deck.
3. **Dealing**: A method to deal a card from the deck.

## Requirements

1. A standard deck of playing cards containing:
    - A suit (Hearts, Diamonds, Spades, Clubs)
    - A face/pip (Ace, 2-10, Jack, Queen, King)
    - 52 unique cards with all 13 faces from all four suits

2. Methods to:
    - Create a new deck
    - Shuffle the deck
    - Deal a card from the deck

3. Unit tests to validate:
    - A deck contains 52 cards with no duplicates
    - The order of cards is different after being shuffled
    - The number of cards available after dealing cards is reduced

## Project Structure

### Interfaces

- `IDeck`: Interface for deck operations.
- `IDeckFactory`: Interface for creating a deck.
- `IShuffler`: Interface for shuffling a deck.
- `IDealer`: Interface for dealing a card from the deck.

### Classes

- `Deck`: Implements `IDeck`, manages the deck of cards using `IDeckFactory`, `IShuffler`, and `IDealer`.
- `DeckFactory`: Implements `IDeckFactory`, responsible for creating a new deck of cards.
- `Shuffler`: Implements `IShuffler`, responsible for shuffling the deck of cards.
- `Dealer`: Implements `IDealer`, responsible for dealing a card from the deck.

## Unit Tests

The unit tests validate the functionality of the `Deck` class, ensuring the deck contains 52 unique cards, shuffles correctly, and deals cards as expected.

### Test Cases

- **DeckContains52CardsWithNoDuplicates**: Validates that a deck contains 52 unique cards.
- **OrderOfCardsIsDifferentAfterBeingShuffled**: Ensures the order of cards is different after shuffling.
- **NumberOfCardsAvailableAfterDealingIsReduced**: Verifies that the number of cards in the deck is reduced by one after dealing a card.
- **DealtCardIsRemovedFromDeck**: Confirms that the dealt card is removed from the deck.

## How to Run the Tests

1. Ensure you have the .NET SDK installed on your machine.
2. Clone the repository.
3. Navigate to the project directory.
4. Run the tests using the following command:```sh
dotnet test```
