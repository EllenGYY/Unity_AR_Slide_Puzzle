using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    public Button Button;
    readonly Dictionary<string, string> toScene = new Dictionary<string, string>();
    void Start()
    {
        toScene.Add("DetectScene", "SettingScene");
        toScene.Add("SettingScene", "DetectScene");
        toScene.Add("PuzzleScene", "DetectScene");
        Button.onClick.AddListener(OnClick);
    }
   

    void OnClick()
    {
        SceneManager.LoadScene(toScene[SceneManager.GetActiveScene().name]);
    }

}
