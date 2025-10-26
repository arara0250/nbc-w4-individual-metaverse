using System.Collections;
using System.Collections.Generic;
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
        float movingX = Input.GetAxisRaw("Horizontal");
        float movingY = Input.GetAxisRaw("Vertical");

        movingDir = new Vector2(movingX, movingY).normalized;
        _rigidbody.velocity = movingDir * 5f;

        animationHandler.Move(movingDir);
    }
}
