using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wincond : MonoBehaviour
{
    Text win1;

    void Start()
    {
        win1 = GetComponent<Text>();
        
    }

    void Update()
    {
        if (set1.temp1 == 3)
            {
                win1.text = "Player1 win!"; 
                Invoke("DelayedFunction", 4f);
                set1.temp1 = 0;
            }
        else if(set2.temp2 == 3)
            {
                win1.text = "Player2 win!"; 
                Invoke("DelayedFunction", 4f);
                set2.temp2 = 0;
            }
    }

    void DelayedFunction()
    {
        SceneManager.LoadScene("Menu");
    }
}
