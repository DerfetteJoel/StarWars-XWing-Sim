using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public StarShip[] faction1_starships;
    public StarShip[] faction2_starships;

    //Stores information about whos turn it is.
    private int turn = 0;

    //Stores information about the phase of the game.
    //0 = planning phase, 1 = movement phase, 2 = battle phase, 3 = end phase;
    private int phase = 0;

	void Start ()
    {

	}


    public int getTurn ()
    {
        return turn;
    }
    public void setTurn (int turn)
    {
        this.turn = turn;
    }

    public int getPhase ()
    {
        return phase;
    }
    public void setPhase (int phase)
    {
        this.phase = phase;
    }
}
