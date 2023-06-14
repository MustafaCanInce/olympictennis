using UnityEngine;
using UnityEngine.UI;

public class set1 : MonoBehaviour
{
    Text pset1;
     Text winText;
    public static int sett1;
    public static int temp1;
    void Start()
    {
        pset1 = GetComponent<Text>();
        
        sett1 = 0;
        pset1.text = "0";
    }
    
    void Update()
    {
        if (Gamescore.scorevalue_player == 55)
        {
            temp1 += 1;
            sett1 = temp1;
            pset1.text = (sett1).ToString();
            Gamescore.scorevalue_player = 0;
            
        }
        
    } 
}
