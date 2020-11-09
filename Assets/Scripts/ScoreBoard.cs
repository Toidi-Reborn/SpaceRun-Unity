using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{

    int score;
    Text scoreText;


    // Start is called before the first frame update
    private void Update(){
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();

        
    }

    // no void is return required  /

    public void ScoreHit(int scoreUp) {
        score = score + scoreUp;
        
    }


}
