using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int IsMoving = Animator.StringToHash("IsMoving");
    private static readonly int MoveFront = Animator.StringToHash("MoveFront");
    private static readonly int MoveSide = Animator.StringToHash("MoveSide");
    private static readonly int MoveBack = Animator.StringToHash("MoveBack");


    private Animator animator;
    private SpriteRenderer playerRenderer;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerRenderer = GetComponent<SpriteRenderer>();
    }

    public void Move(Vector2 obj)
    {
        if (animator == null)
        {
            Debug.LogError("Animator is null!");
            return;
        }

        if (obj.x < -0.5f || obj.x > 0.5f)
        {
            // 좌우 이동 (대각선 이동 포함)
            animator.SetBool(MoveFront, false);
            animator.SetBool(MoveSide, true);
            animator.SetBool(MoveBack, false);
        }
        else if (obj.y == 1)
        {
            // 뒤 (위쪽 방향) 로 이동
            animator.SetBool(MoveFront, false);
            animator.SetBool(MoveSide, false);
            animator.SetBool(MoveBack, true);
        }
        else
        {
            animator.SetBool(MoveFront, true);
            animator.SetBool(MoveSide, false);
            animator.SetBool(MoveBack, false);
        }

        animator.SetBool(IsMoving, obj.magnitude > 0.5f);
    }

    public void Rotate(Vector2 moveDir)
    {
        if (moveDir.x < 0.5f)
        {
            playerRenderer.flipX = true;
        }
        else if (moveDir.x > 0.5f)
        {
            playerRenderer.flipX = false;
        }
    }
}
