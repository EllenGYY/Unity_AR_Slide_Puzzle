using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txt;
    void Start()
    {
        if (!PlayerPrefs.HasKey("Score"))
        {
            PlayerPrefs.SetInt("Score", 0);
        }
        Debug.Log(PlayerPrefs.GetInt("Score"));
        txt.text = "Score: " + PlayerPrefs.GetInt("Score");
        Debug.Log(txt.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
