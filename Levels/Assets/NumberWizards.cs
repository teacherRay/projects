using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;


public class NumberWizards : MonoBehaviour
{

    // Use this for initialization
    int min=1;
    int max=1000;
    int guess=500;
    public int MaxGuessesAllowed = 10;

   public void Start()
        {
            max = max + 1;
        }

    public void Update()
    {
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

        

    void NextGuess()
    {
        guess = (max + min) / 2;
        MaxGuessesAllowed = MaxGuessesAllowed - 1;

        if (MaxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }

    }

}

