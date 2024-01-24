using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCharacter : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 10f;

    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    void Start()
    {
        //Store the attached RB as a ref
        _rigidbody2D = this.GetComponent<Rigidbody2D>();
        _animator = this.GetComponent<Animator>();
    }

    public void ExecuteCommand(FCommand command)
    {
        switch(command.type)
        {
            case FCommandType.Move:
                Move(command as FMoveCommand);
                break;
            case FCommandType.Jump:
                break;
            case FCommandType.Attack:
                Attack();
                break;
        }
    }

    private void Move(FMoveCommand command)
    {
        _rigidbody2D.velocity = command.moveDirection * speed;
    }

    private void Attack()
    {
        _animator.SetTrigger("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("Speed", _rigidbody2D.velocity.x);
    }
}
