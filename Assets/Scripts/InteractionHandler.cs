using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionHandler : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private GameObject canvas;

    private bool isPlayerInRange = false;
    private string miniGameName;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        // null check
        if (spriteRenderer == null) 
        {
            Debug.LogError("Interactable object must have Sprite Renderer!");
            return;
        }

        canvas = GetComponentInChildren<Canvas>().gameObject;
        
        // null check
        if (canvas == null)
        {
            Debug.LogError("Interactable object must have Canvas!");
            return;
        }
        else
        {
            // Text UI 초기화 (꺼놓은 상태)
            canvas.SetActive(false);
        }

        // 상호작용 오브젝트별 미니게임 배정
        // InteractableChicken -> FlappyChicken (Flappy Plane)
        // InteractablePig -> StackStraw (The Stack)
        if (transform.name == "InteractableChicken")
            miniGameName = "FlappyChickenScene";
        else
            miniGameName = "StackStrawScene";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("OnTriggerEnter!");
            spriteRenderer.color = Color.yellow;
            transform.localScale = new Vector2(1.05f, 1.05f);
            canvas.SetActive(true);
            isPlayerInRange = true;
        } 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("OnTriggerExit...");
            spriteRenderer.color = Color.white;
            transform.localScale = Vector2.one;
            canvas.SetActive(false);
            isPlayerInRange = false;
        }
    }

    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.Space))
            Interact();
    }

    private void Interact()
    {
        Debug.Log("상호작용 성공!");

        // null check
        if (string.IsNullOrEmpty(miniGameName))
        {
            Debug.LogError("miniGameName (string) is null!");
            return;
        }

        // StackStraw => 세로모드
        if (miniGameName == "StackStrawScene")
        {
            /*Screen.orientation = ScreenOrientation.Portrait;
            Screen.SetResolution(1080, 1920, true);*/
        }
            
        SceneManager.LoadScene(miniGameName);
    }
}
