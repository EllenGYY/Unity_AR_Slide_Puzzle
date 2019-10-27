using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cancel : MonoBehaviour
{
    public Button cancelButton;
    void Start()
    {
        cancelButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("DetectScene");
    }
    
}
