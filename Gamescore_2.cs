using UnityEngine;
using UnityEngine.UI;

public class Gamescore_2 : MonoBehaviour
{
    public static int scorevalue_player_2 = 0;
    
    Text scoretext_2;
    
    void Start(){
         
         scoretext_2 = GetComponent<Text>();
    }
    void Update(){

        scoretext_2.text = "Player2 " + scorevalue_player_2;
        

    } 
}
