using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private int currentScore;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HandleScore()
    {
        scoreText.text = "Score " + currentScore;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Respawn")
        {
            currentScore+=1;
            HandleScore();
        }
    }
}
