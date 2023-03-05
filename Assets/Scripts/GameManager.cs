using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject menuView;
    public GameObject gameplayView;
    public TMP_InputField inputText;
    public TextMeshProUGUI responseText;
    private int randomNumber;
    private int guesses;
    
    public void StartGame()
    {
        menuView.SetActive(false);
        gameplayView.SetActive(true);
        responseText.text = "Guess the number form 1 - 100";
        randomNumber = Random.Range(1, 100);
        guesses = 0;
    }
    
    public void GetInput(string input)
    {
        Debug.Log("You Entered "+ input);
        if (int.TryParse(input, out int number))
        {
            guesses++;
            if (randomNumber == number)
            {
                responseText.text = "Congratulation, this is correct number. It took you "+ guesses+" guesses";
                menuView.SetActive(true);
            }
            else if (randomNumber > number)
            {
                responseText.text = "My number is higher";
            }
            else if (randomNumber < number)
            {
                responseText.text = "My number is lower";
            }
            
            inputText.text = "";
            
        }
        
    }
    
}
