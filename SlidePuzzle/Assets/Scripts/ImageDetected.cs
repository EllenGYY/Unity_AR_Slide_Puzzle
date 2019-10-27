using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImageDetected : MonoBehaviour
{
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("empty") != null)
        {
            SceneManager.LoadScene("PuzzleScene");
        }
    }
}
