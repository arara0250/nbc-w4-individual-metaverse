using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static StackUIManager;

public abstract class StackBaseUI : MonoBehaviour
{
    protected StackUIManager stackUIManager;

    public virtual void Init(StackUIManager uiManager)
    {
        stackUIManager = uiManager;
    }

    protected abstract StackUIState GetUIState();
    public void SetActive(StackUIState state)
    {
        gameObject.SetActive(GetUIState() == state);
    }
}
