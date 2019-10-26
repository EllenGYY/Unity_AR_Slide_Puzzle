using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDetected : MonoBehaviour
{
    bool detected = false;
    public GameObject tileMap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!detected && (GameObject.FindGameObjectWithTag("empty") != null))
        {
            Instantiate(tileMap, new Vector3(0, 0, 0), Quaternion.identity);
            detected = true;
        }
        else if(detected && (GameObject.FindGameObjectWithTag("empty") == null))
        {
            Destroy(GameObject.FindGameObjectWithTag("tileMap"));
            detected = false;
        }
    }
}
