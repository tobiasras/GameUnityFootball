using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndMessage : MonoBehaviour
{
    
    public TextMeshProUGUI textBox;
    // Start is called before the first frame update
    void Start()
    {
        float time = PlayerPrefs.GetFloat("Time");
        int score = PlayerPrefs.GetInt("Kicks");

        textBox.text = "Kicks: " + score + " \nTime:" + time.ToString("F2") + " seconds";;
    }

  
}
