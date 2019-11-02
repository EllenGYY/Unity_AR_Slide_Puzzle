using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownAction : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown dropdown;
    public static int Height = 4;
    public static int Width = 4;
    Dictionary<int, int> corre = new Dictionary<int, int>();
    int nowValue;

    void Start()
    {
        corre.Add(0, 4);
        corre.Add(1, 3);
        corre.Add(2, 5);
        nowValue = dropdown.value;
    }

    // Update is called once per frame
    void Update()
    {
        if (dropdown.value != nowValue)
        {
            nowValue = dropdown.value;
            Height = corre[nowValue];
            Width = corre[nowValue];
        }
    }
}
