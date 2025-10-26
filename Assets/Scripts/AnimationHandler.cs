using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int IsMoving = Animator.StringToHash("IsMoving");
    
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Move(Vector2 obj)
    {
        if (animator == null)
        {
            Debug.LogError("Animator is null!");
            return;
        }

        animator.SetBool(IsMoving, obj.magnitude > 0.5f);
    }
}
