using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    
public int score = 0;
Text scoreDisplay;


    void Start()
    {
      scoreDisplay = GetComponent<Text>();

      score = 0;
    }

    // Update is called once per frame
    void Update()
    {
          scoreDisplay.text = score.ToString();
    }
}
