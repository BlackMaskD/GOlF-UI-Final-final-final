using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void JumpScence(string scenceName)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(scenceName);
    }
    public void EndGame()
    {
        Application.Quit();
    }
}
