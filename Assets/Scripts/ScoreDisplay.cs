using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text playerScore;
    // Start is called before the first frame update
    void Start()
    {
        playerScore.text = PlayerPrefs.GetInt("Score", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
