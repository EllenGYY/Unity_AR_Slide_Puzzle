using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenCompleted : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (ST_PuzzleDisplay.Complete)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")+1);
            PlayerPrefs.Save();
            ST_PuzzleDisplay.Complete = false;
        }
    }
}
