using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private AnimationHandler animationHandler;
    

    private Vector2 movingDir = Vector2.zero;
    public Vector2 MovingDir { get => movingDir; }


    private Vector2 lookDir = Vector2.zero;
    public Vector2 LookDir { get => lookDir; }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        animationHandler = GetComponentInChildren<AnimationHandler>();
    }

    private void Update()
    {
        HandleMovement();
        animationHandler.Rotate(movingDir);
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = movingDir * 5f;
    }

    private void HandleMovement()
    {
        float movingX = Input.GetAxisRaw("Horizontal");
        float movingY = Input.GetAxisRaw("Vertical");

        // 디버깅 코드
        /*string input = "";
        if (movingY == 1) input += "↑";
        else if (movingY == -1) input += "↓";

        if (movingX == 1) input += "→";
        else if (movingX == -1) input += "←";

        Debug.Log($"{input}");
        input = "";*/


        movingDir = new Vector2(movingX, movingY).normalized;

        animationHandler.Move(movingDir);
    }

    private void HandleInteraction()
    {
        // TODO : Player 와 Object 상호작용 구현
    }
}
