using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    public Text text;
	int max;
	int min;
	int guess;
    public int maxGuessesAllowed = 5;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
        NextGuess();
		
	}
	
	// Update is called once per frame
	void Update () {	
		
	} 

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
	
	void NextGuess() {
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;

        if(maxGuessesAllowed == 0)
        {
            Application.LoadLevel("Win");
        }
	}
}
