using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{
    Animator anim = null;
    Rigidbody2D rb = null;

    public float flapForce = 6f;
    public float forwardSpeed = 3f;
    public bool isDead = false;
    float deathCooldown = 0f;

    bool isFlap = false;

    GameManager gameManager;

    // Start is called before the first frame update
    private void Start()
    {
        gameManager = GameManager.Instance;

        anim = transform.GetComponentInChildren<Animator>();
        if (anim == null)
        {
            Debug.LogError("Chicken's Children must have Animator!");
            return;
        }

        rb = transform.GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Chicken must have Rigidbody2D!");
            return;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (isDead)
        {
            if (deathCooldown <= 0)
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
                {
                    // 게임 재시작
                    gameManager.RestartGame();
                }
            }
            else
            {
                deathCooldown -= Time.deltaTime;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
                isFlap = true;
        }
    }

    private void FixedUpdate()
    {
        if (isDead) { return; }

        Vector3 velocity = rb.velocity;
        velocity.x = forwardSpeed;

        if (isFlap)
        {
            velocity.y += flapForce;
            isFlap = false;
        }
        
        rb.velocity = velocity;

        float angle = Mathf.Clamp((rb.velocity.y * 10f), -90, 90);
        float lerpAngle = Mathf.Lerp(transform.rotation.eulerAngles.z, angle, Time.fixedDeltaTime * 5f);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) { return; }

        anim.SetBool("IsDie", true);
        isDead = true;
        deathCooldown = 1f;

        // 게임 오버 처리
        gameManager.GameOver();
    }
}
