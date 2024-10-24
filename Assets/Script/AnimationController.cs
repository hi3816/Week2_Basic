using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    enum State
    { 
        Idle = 0,
        Jump = 1,
        Attack = 2
    }

    private Animator _animator;
    private int animationVariable = (int)State.Idle;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (animationVariable > 1)
        {
            animationVariable = 0;
        }
        else
        {
            animationVariable++;
        }
        _animator.SetInteger("State", animationVariable);
        Debug.Log($"animationVariable : {animationVariable}");
        
    }
}
