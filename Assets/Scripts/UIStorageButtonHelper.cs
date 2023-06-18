using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class UIStorageButtonHelper : MonoBehaviour
{
    public Action OnUseButtonClick, OnDropButtonClick;
    public Button useButton, dropButton;

    void Start()
    {
        useButton.onClick.AddListener(() => OnUseButtonClick?.Invoke());
        dropButton.onClick.AddListener(() => OnDropButtonClick?.Invoke());
    }
    
    public void HideAllButtons()
    {
        ToggleDropButton(false);
        ToggleUseButton(false);
    }

    public void ToggleUseButton(bool value)
    {
        useButton.interactable = value;
    }

    public void ToggleDropButton(bool v)
    {
        dropButton.interactable = v;  // v = value;
    }
}
