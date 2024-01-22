using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCard : Card
{
    private int life = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnPlay()
    {
        GameObject other = GameObject.FindWithTag("Card");

        if(other)
        {
            other.SendMessage("Activate", SendMessageOptions.DontRequireReceiver);
            life = life + 1;
        }
    }

    void onActivate()
    {
        life--;
        if(life<= 0)
        {
            this.Erase();
        }
    }

    void OnDestroy()
    {
        //Play Fire Noise
        GameObject.Find("Sounds").transform.Find("Fire").GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
