using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerGameOver : MonoBehaviour
{
    public Collider bola;
    public GameObject gameOverCanvas;
    

    

    // Start is called before the first frame update
    private void Start()
    {
        gameOverCanvas.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            gameOverCanvas.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
