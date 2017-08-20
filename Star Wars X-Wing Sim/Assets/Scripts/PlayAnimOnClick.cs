using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * a class that plays an animation once when the button is pressed.
 */
public class PlayAnimOnClick : MonoBehaviour
{

    public GameObject animObject;
    public string animationName;
	
	void Start ()
    {
        GetComponent<Button>().onClick.AddListener(onClick);
	}
	
	
	void onClick ()
    {
        animObject.GetComponent<Animator>().Play(animationName);
	}
}
