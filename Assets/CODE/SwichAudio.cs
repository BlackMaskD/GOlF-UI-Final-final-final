using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwichAudio : MonoBehaviour
{
    private Image im;
    public Sprite sp1, sp2;
    bool isPlay=true;
    // Start is called before the first frame update
    void Start()
    {
        im = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlay)
        {
            AudioListener.volume = 1;
            im.sprite = sp1;
        }
        else
        {
            AudioListener.volume = 0;
            im.sprite = sp2;
        }
    }
    public void Click()
    {
        isPlay=!isPlay;
    }
}
