using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
  int max;
  int min;
  int guess;
  // Start is called before the first frame update
  void Start()
  {
    StartGame();
  }

  void StartGame()
  {
    max = 1000;
    min = 1;
    guess = 500;

    Debug.Log("Welcome to number wizard.");
    Debug.Log("Pick a number");
    Debug.Log("The highest number you can pick is: " + max);
    Debug.Log("And the lowest number you can pick is: " + min);
    Debug.Log("Tell me if your number is higher or lower than: " + 500);
    Debug.Log("Push Up Arrow for higher, Push Down Arrow for lower, Push Enter for Correct");
    max = max + 1;
  }

  // Update is called once per frame
  void Update()
  {
    //Detect when the up arrow key is pressed down
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      min = guess;
      NextGuess();
    }
    else if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      max = guess;
      NextGuess();
    }
    else if (Input.GetKeyDown(KeyCode.Return))
    {
      Debug.Log("I knew it!");
      StartGame();
    }


  }
  void NextGuess()
  {
    guess = (max + min) / 2;
    Debug.Log("Ok how about " + guess);
  }
}
