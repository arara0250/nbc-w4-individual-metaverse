using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FlappyUIManager;

public abstract class FlappyBaseUI : MonoBehaviour
{
    protected FlappyUIManager flappyUIManager;

    public virtual void Init(FlappyUIManager uiManager)
    {
        flappyUIManager = uiManager;
    }

    protected abstract FlappyUIState GetUIState();
    public void SetActive(FlappyUIState state)
    {
        gameObject.SetActive(GetUIState() == state);
    }
}
