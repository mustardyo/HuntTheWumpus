using System;
using WindowsFormsApplication1;


public class Player
{
    private int turns;
    private int score;
    private int arrows;
    private int secrets; // don't need this?
    private int coins;

    public const int InitialArrowsNumber = 3;
    public const int KillWumpusPoints = 100;

    public Player()
	{
        turns = 0;
        score = 0;
        arrows = InitialArrowsNumber;
        secrets = 0; // don't need this ?
        coins = 0;

    }

    // Player Actions
    public int PurchaseArrows()
    {
        arrows +=2;
        turns++;
        return arrows;
    }

    public int ShootArrow()
    {
        arrows--;
        turns++;
        return arrows;
    }
 
    public void Move()
    {
        turns++;
    }

    public void PurchaseSecret()
    {
        secrets++; // we don't care about the number of secrets, so do't need this ?
        turns++;
    }

    public int KillTheWumpus()
    {
        score = KillWumpusPoints - turns + coins + 10 * arrows;
        return score;
    }

    // Get Properties
    public int GetArrows()
    {
        return arrows;
    }

    public int GetTurns()
    {
        return turns;
    }

    public int GetCoins()
    {
        return coins;
    }

    public int GetScore()
    {
        return score;
    }

    public void addCoins(int num)
    {
        coins += num;
    }

}
