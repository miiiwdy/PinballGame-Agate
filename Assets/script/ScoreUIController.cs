using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUIController : MonoBehaviour
{
    public TMP_Text scoreText;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     private void Update()
    {
		scoreText.text = scoreManager.score.ToString();
    }
}
