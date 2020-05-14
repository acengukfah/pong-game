using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringScript : MonoBehaviour
{
    public Text P1, P2;
    public static int ScoreP1 = 0, ScoreP2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        P1.text = ScoreP1.ToString();
        P2.text = ScoreP2.ToString();
    }

    public void UpdateScore(string namaWall)
    {
        if (namaWall == "WallVerticalLeft")
        {
            ScoreP2 += 1;
            P2.text = ScoreP2.ToString();
        }
        else if (namaWall == "WallVerticalRight")
        {
            ScoreP1 += 1;
            P1.text = ScoreP1.ToString();
        }
    }
}
