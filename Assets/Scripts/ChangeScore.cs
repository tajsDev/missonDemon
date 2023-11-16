using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ChangeScore : MonoBehaviour
{
    TMP_Text score;
    // Start is called before the first frame update
    void Awake()
    {
        score = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.SetText($"{ScoreTracker.score}");
        if(ScoreTracker.score > 7500 )
        {
            score.color  = Color.green;
        }
        else if ( ScoreTracker.score > 5000 )
        {
            score.color  = Color.yellow;
        }
        else 
        {
            score.color  = Color.red;
        }
    }
}
