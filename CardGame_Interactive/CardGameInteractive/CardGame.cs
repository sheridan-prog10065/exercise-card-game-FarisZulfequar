namespace CardGameInteractive;

/// <summary>
/// Defines the card game that implements the game logic and hold the card deck
/// </summary>
public class CardGame
{
    // This is where the filed variables will be declared
    /// <summary>
    /// Represents the deck of cards the game using
    /// </summary>
    private CardDeck _cardDeck;
    
    /// <summary>
    /// The score of the game
    /// </summary>
    private Score _score;
    
    /// <summary>
    /// The last card played by the user
    /// </summary>
    private Card _playerCard;
    
    /// <summary>
    /// The last card player by the house
    /// </summary>
    private Card _houseCard;
}