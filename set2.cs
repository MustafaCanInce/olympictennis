using UnityEngine;
using UnityEngine.UI;

public class set2 : MonoBehaviour
{
    Text pset2;
    public static int sett2;
    public static int temp2;
    void Start()
    {
        pset2 = GetComponent<Text>();
        sett2 = 0;
        pset2.text = "0";
    }
    
    void Update()
    {
        if (Gamescore_2.scorevalue_player_2 == 55)
        {
            temp2 += 1;
            sett2 = temp2;
            pset2.text = (sett2).ToString();
            Gamescore_2.scorevalue_player_2 = 0;
        }
    } 
}
