using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditButton;

    // Start is called before the first frame update
    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditButton.onClick.AddListener(Credit);
    }
    public void Credit() {
        SceneManager.LoadScene("CreditScene");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePinball");
    }
    private void ExitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
