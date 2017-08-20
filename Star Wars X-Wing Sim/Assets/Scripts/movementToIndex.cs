using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementToIndex : MonoBehaviour {

    public StarShip ship;

    //The GameObject that parents all of the movement-buttons.
    public GameObject movementUI;
    
    //This function does not really generate Buttons, but it decides wether to show or hide them.
    void generateButtons ()
    {
        //First, the 2-dimensional array movementData from the Starship class will be transformed into a
        //1-dimensional array with 30 indexes. To do so, a List<int> is created to store all information
        //that will then be transformed to an array.
        List<int> listMovement = new List<int>();
        foreach (var item in ship.movementData)
        {
            listMovement.Add(item);
        }
        int[] arrMovement = listMovement.ToArray();


    }

}
