using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    //Staring score
    public int score = 50;

    public void OnTriggerEnter(Collider other)
    {
        {
            Debug.Log("object enter the trigger");
            //countdown by 1
            score -= 1;
            scoreText.text = score.ToString();
            
        }
    }
   
}
