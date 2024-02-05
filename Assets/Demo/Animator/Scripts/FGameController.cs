using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FGameController : MonoBehaviour
{
    public Image[] playerHealthBars;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetPlayerHealth(int player, float healthAmt)
    {
        playerHealthBars[player].fillAmount = healthAmt;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
