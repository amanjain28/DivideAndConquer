using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivideAndConquerEngine : MonoBehaviour {

    public int Guess;
    public int min;
    public int max;

	// Use this for initialization
	void Start () {
        Debug.Log("Hello! Welcome to Divide and Conquer Game");
        Debug.Log("Pick a number in your mind. Let's see how good you are in hiding numbers");
        //fancy way to from strings.
        Debug.Log(string.Format("The highest number you can pick is : {0}", max));
        Debug.Log("The lower number you can pick is :  " + min);
        Debug.Log("Is the number > or < than" + Guess + "?");
        Debug.Log("Up arrow == >, Down arrow == <, Enter == equal");
       // Debug.Log(string.Format("Up {0} {1} >, Down {0} {1} <, Enter {1} equal", "arrow", "=="));


    }

    // Update is called once per frame
    void Update () {
        Engine();

	}

    void Engine() {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = Guess;
            Algorithm();
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = Guess;
            Algorithm();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You Won!");
        }
    }

    void Algorithm()
    {
        Guess = (max + min) / 2;
        Debug.Log("Higher > or lower than : " + Guess + "?");
    }


}
