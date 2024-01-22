using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    public int scoreValue = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void activate()
    {
        this.SendMessage("OnActivate", SendMessageOptions.DontRequireReceiver);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Erase()
    {
        GameObject.FindWithTag("GameController").GetComponent<GameController>().CardDestroyed();

        this.SendMessage("OnDestroy", SendMessageOptions.DontRequireReceiver);
    }

    public void OnPlay()
    {
        GameObject.FindWithTag("GameController").GetComponent<GameController>().CardAdded();
    }
}
