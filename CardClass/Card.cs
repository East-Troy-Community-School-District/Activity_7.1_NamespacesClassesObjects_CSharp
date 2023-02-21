using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a typical playing card.
/// </summary>
public class Card
{
    /// <summary>
    /// Gets the suit of the card. 
    /// </summary>
    public Suit Suit { get; }

    /// <summary>
    /// Gets the rank of the card.
    /// </summary>
    public Rank Rank { get; }

    /// <summary>
    /// Generates a random card.
    /// </summary>
    /// <param name="r">Random generator used to create card.</param>
    public Card(Random r)
    {
        int suit = r.Next(0, 4);
        Suit = (Suit)suit;
        int rank = r.Next(1, 14);
        Rank = (Rank)rank;
    }

    public override string ToString()
    {
        return Rank + " of " + Suit + "s";
    }
}

/// <summary>
/// Represents the different suits.
/// </summary>
public enum Suit
{
    Club,
    Diamond, 
    Heart,
    Spade
}

/// <summary>
/// Represents the different ranks.
/// </summary>
public enum Rank
{
    Ace = 1,
    Two = 2, 
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13
}