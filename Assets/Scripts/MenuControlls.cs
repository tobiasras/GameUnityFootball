using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlls : MonoBehaviour
{
    // Start is called before the first frame update
    public void End()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    // Update is called once per frame
  
}
