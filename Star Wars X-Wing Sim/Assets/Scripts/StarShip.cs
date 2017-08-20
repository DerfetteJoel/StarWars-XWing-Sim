using UnityEngine;

/**
 * Contains all information about the starship this script is attached to.
 */
public class StarShip : MonoBehaviour
{

    public string shipName;
    public int captainSkill;
    public int attack;
    public int defense;
    public int hull;
    public int shields;

    //Movement Data is stored in a sprite that contains the information about the movement-data.
    public Texture2D movementSprite;

    //A 2-dimensional array that holds information about the movement of the ship.
    public int[,] movementData = new int[5, 6];

    void Start()
    {
        ReadMoveData(movementSprite, movementData);

        Debug.Log(movementData[0, 0] + ", " + movementData[0, 1] + ", " + movementData[0, 2] + ", "
                + movementData[0, 3] + ", " + movementData[0, 4] + ", " + movementData[0, 5]);

        Debug.Log(movementData[1, 0] + ", " + movementData[1, 1] + ", " + movementData[1, 2] + ", "
                + movementData[1, 3] + ", " + movementData[1, 4] + ", " + movementData[1, 5]);

        Debug.Log(movementData[2, 0] + ", " + movementData[2, 1] + ", " + movementData[2, 2] + ", "
                + movementData[2, 3] + ", " + movementData[2, 4] + ", " + movementData[2, 5]);

        Debug.Log(movementData[3, 0] + ", " + movementData[3, 1] + ", " + movementData[3, 2] + ", "
                + movementData[3, 3] + ", " + movementData[3, 4] + ", " + movementData[3, 5]);

        Debug.Log(movementData[4, 0] + ", " + movementData[4, 1] + ", " + movementData[4, 2] + ", "
                + movementData[4, 3] + ", " + movementData[4, 4] + ", " + movementData[4, 5]);
    }

    //Read movement-Data from Sprite and store it in a 2-dimensional array.
    //Note: The finished Array is reversed horizontally:
    //  [1, 2]  =>  [3, 4]
    //  [3, 4]  =>  [1, 2]
    void ReadMoveData (Texture2D moveData, int[,] output)
    {
        for (int x = 0; x < movementSprite.height ; x++)
        {
            for (int y = 0; y < moveData.height; y++)
            {
                Color pixelColor = moveData.GetPixel(x, y);


                if (pixelColor == Color.black)
                {
                    output[y, x] = 0;
                    //Debug.Log("(Y=" + y + ", X=" + x + "): " + movementData[y,x]);
                }
                else if (pixelColor == Color.white)
                {
                    output[y, x] = 1;
                    //Debug.Log("(Y=" + y + ", X=" + x + "): " + movementData[y, x]);
                }
                else if (pixelColor == Color.green)
                {
                    output[y, x] = 2;
                    //Debug.Log("(Y=" + y + ", X=" + x + "): " + movementData[y, x]);
                }
                else if (pixelColor == Color.red)
                {
                    output[y, x] = 3;
                    //Debug.Log("(Y=" + y + ", X=" + x + "): " + movementData[y, x]);
                }
            }

        }
    }
}
