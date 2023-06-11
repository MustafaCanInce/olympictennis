using UnityEngine;
using UnityEngine.UI;

public class Gamescore : MonoBehaviour
{
    public static int scorevalue_player = 0;

    Text scoretext;
    
    void Start(){
         scoretext = GetComponent<Text>();

    }
    void Update(){

        scoretext.text = "Player1 " + scorevalue_player;
        
        

    } 
}
