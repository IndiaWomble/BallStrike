using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
      
    }


    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level 1");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
