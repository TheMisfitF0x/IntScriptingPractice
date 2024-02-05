using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCharacter : MonoBehaviour
{
    public float speed = 10f;
    public int playerNum;

    private float _health;
    public float maxHealth;
    private FGameController _gameController;

    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private bool isFlipped;

    void Start()
    {
        //Store the attached RB as a ref
        _rigidbody2D = this.GetComponent<Rigidbody2D>();
        _animator = this.GetComponent<Animator>();

        _health = maxHealth;

        _gameController = GameObject.FindWithTag("GameController").GetComponent<FGameController>();
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

        Vector2 scale = this.transform.localScale;
        if(command.moveDirection.x > 0) scale.x = 1f;
        else scale.x = -1f;

        this.transform.localScale = scale;
    }

    private void Attack()
    {
        _animator.SetTrigger("Attack");
    }

    public void Hit()
    {
        _animator.SetTrigger("Hit");
        _health -= 10f;
        _gameController.SetPlayerHealth(playerNum, _health / maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //Yeet the fact that we're moving to the animator'
        _animator.SetFloat("Speed", Mathf.Abs(_rigidbody2D.velocity.normalized.x));
    }
}
