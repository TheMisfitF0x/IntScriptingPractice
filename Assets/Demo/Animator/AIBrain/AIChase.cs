using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : StateMachineBehaviour
{

    private GameObject _player; 
    private GameObject _self;
    private FCharacter _fCharacter;
    private AIState _aiInput;


    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _player = GameObject.FindWithTag("Player");
        _self = animator.gameObject.transform.parent.gameObject; //Ugly. Bad. Fuck. This grabs daddy, but honestly it just looks bad.
        _fCharacter = _self.GetComponent<FCharacter>();
        _aiInput = _self.GetComponent<AIState>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //I made a mistake. Don't you dare say anything off topic or Travis derails.
        Vector3 dist = _player.transform.position - _self.transform.position;

        if(Mathf.Abs(dist.x) > 3f)
        {
            //Close the gap. Go in for the kill.
            _fCharacter.ExecuteCommand(new FMoveCommand(dist.normalized));
        }
        else
        {
            _fCharacter.ExecuteCommand(new FAttackCommand());
            _aiInput.energy -= .5f;
            Debug.Log("bam");
        }
        animator.SetFloat("Energy", _aiInput.energy);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Implement code that processes and affects root motion
        Debug.Log("Bing");
    }

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
