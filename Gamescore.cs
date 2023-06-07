using UnityEngine;
using UnityEngine.UI;

public class Gamescore : MonoBehaviour
{
    public static int scorevalue = 0;

    Text scoretext;
    
    void Start(){
        scoretext = GetComponent<Text>();

    }
    void Update(){
        scoretext.text = "blabla" + scorevalue;
        
    } 
}
