using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningCard : Card
{
    public GameObject nextToGenerate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPlay()
    {
        base.OnPlay();

        GameObject other = GameObject.FindWithTag("Card");


        if (other)
        {
            other.SendMessage("Activate");
            other.SendMessage("Erase");
        }
    }

    void OnDestroy()
    {
        GameObject newLightning = Instantiate(nextToGenerate, this.transform.position, this.transform.rotation);
        newLightning.transform.SetParent(this.transform.parent, false);
        newLightning.SendMessage("OnPlay", SendMessageOptions.DontRequireReceiver);
    }
}
