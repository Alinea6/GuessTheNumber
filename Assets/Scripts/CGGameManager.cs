using TMPro;
using UnityEngine;

public class CGGameManager : MonoBehaviour
{
    public GameObject menuView;
    public GameObject gameplayView;
    public TextMeshProUGUI outputText;
    public int initialMax = 100;
    public int initialMin = 0;
    private int _currentMax;
    private int _currentMin;
    private int _lastGuess; 
    
    // Start is called before the first frame update
    public void StartGame()
    {
        menuView.SetActive(false);
        gameplayView.SetActive(true);
        _currentMax = initialMax;
        _currentMin = initialMin;
        ComputerGuess();
    }

    private void ComputerGuess()
    {
        var guess = ((_currentMax - _currentMin) / 2) + _currentMin;
        _lastGuess = guess;
        outputText.text = $"Computer's guess is {guess}. Is that correct?";
    }

    public void Higher()
    {
        _currentMin = _lastGuess + 1;
        ComputerGuess();
    }

    public void Lower()
    {
        _currentMax = _lastGuess - 1;
        ComputerGuess();
    }

    public void Correct()
    {
        outputText.text = $"Your number was {_lastGuess}";
        menuView.SetActive(true);
        gameplayView.SetActive(false);
    }
}
