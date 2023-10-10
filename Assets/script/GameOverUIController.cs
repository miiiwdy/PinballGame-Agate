using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public Button mainMenuButton;
    public Button playButton;

    private void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
        playButton.onClick.AddListener(PlayGame);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePinball");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
