using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public int counter = 30;
    public Text timerText;
    // Start is called before the first frame update
    void Start () {
        timerText.text = counter.ToString();
    }

    // Update is called once per frame
    void Update () {
    
    }
}