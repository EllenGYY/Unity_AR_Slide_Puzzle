using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhenCompleted : MonoBehaviour
{
    public Text txt;
    bool changed;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (PuzzleDisplay.Complete && (!changed))
        {
            txt.text = "COMPLETED!";
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")+1);
            PlayerPrefs.Save();
            changed = true ;
        }
    }
}
