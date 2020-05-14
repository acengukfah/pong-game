using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class EndingScript : MonoBehaviour
{
    public TextMeshProUGUI endingText;
    // Start is called before the first frame update
    void Start()
    {
        if (ScoringScript.ScoreP1 > ScoringScript.ScoreP2){
            endingText.text = "Player 1 Win";
        }else if(ScoringScript.ScoreP1 < ScoringScript.ScoreP2)
        {
            endingText.text = "Player 2 Win";
        }else
        {
            endingText.text = "Draw";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
