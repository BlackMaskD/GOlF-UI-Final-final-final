using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwichResolution : MonoBehaviour
{
    public Image[] im;
    public int index = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(index==0)
        {
            Screen.SetResolution(640, 360, false);
        }else if(index==1)
        {
            Screen.SetResolution(1280, 720, false);
        }
        else if (index == 2)
        {
            Screen.SetResolution(1920, 1080, false);
        }
        for (int i = 0; i < 3; i++)
        {
            if (i == index)
            {
                im[i].color = new Color(1, 1, 1, 0.1f);
            }
            else
            {
                im[i].color = new Color(1, 1, 1, 0.01f);
            }
        }
    }
    public void Click(int a)
    {
        index = a;
    }
}
