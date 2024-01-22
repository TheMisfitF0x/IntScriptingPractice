using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public int cardCount = 0;
    public TMP_Text txtFeedback;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CardDestroyed()
    {
        cardCount--;
        this.UpdateCountDisplay();

        if(cardCount<=0)
        {
            //Game over
        }
    }

    public void CardAdded()
    {
        cardCount += 1;
        this.UpdateCountDisplay();
    }

    private void UpdateCountDisplay()
    {
        txtFeedback.text = cardCount.ToString();
    }
    
}
