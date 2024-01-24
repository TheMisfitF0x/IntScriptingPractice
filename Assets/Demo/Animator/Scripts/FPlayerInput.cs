using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPlayerInput : MonoBehaviour
{
    private FCharacter _fCharacter;
    // Start is called before the first frame update
    void Start()
    {
        _fCharacter = this.GetComponent<FCharacter>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3();
        move.x = Input.GetAxis("Horizontal");

        if (move.magnitude > 0)  _fCharacter.ExecuteCommand(new FMoveCommand(move));

        if (Input.GetButtonDown("Attack")) _fCharacter.ExecuteCommand(new FAttackCommand());
    }
}
