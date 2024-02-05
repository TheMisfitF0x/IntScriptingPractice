using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIIdle : StateMachineBehaviour
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

        //Anim props
        animator.SetFloat("Bravery", 4f);
        animator.SetFloat("Energy", 5f); 
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _aiInput.energy += .05f;
        animator.SetFloat("Energy", _aiInput.energy);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
