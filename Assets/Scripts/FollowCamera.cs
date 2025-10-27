using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;    // Player
    private Vector3 offset;     // Player 와 Camera 사이의 거리
    
    // Start is called before the first frame update
    void Start()
    {
        if (target == null) return;     // target (Player) 가 Inspector 상에서 연결되지 않았을 경우

        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        Vector3 cameraPos = transform.position;
        cameraPos = target.position + offset;

        // camera 추적 범위 제한
        cameraPos.x = Mathf.Clamp(cameraPos.x, -22, 22);
        cameraPos.y = Mathf.Clamp(cameraPos.y, -12, 12);

        transform.position = cameraPos;
    }
}
