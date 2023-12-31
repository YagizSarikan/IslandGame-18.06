using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class ItemPanelHelper : MonoBehaviour
{
    public Action<int, bool> OnClickEvent;

    public Image itemImage;
    [SerializeField]

    private TextMeshProUGUI nameText, countText;
    public string itemName, itemCount;
    public bool isEmpty = true;
    public Outline outline;
    public bool isHotbarItem = false;

    public Sprite backgroundSprite;


    private void Start()
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;
        if (itemImage.sprite == backgroundSprite)
        {
            ClearItem();
        }
    }

    public void SetInventoryUIElement(string name, int count, Sprite image)
    {
        itemName = name;
        itemCount = count + "";
        if (!isHotbarItem)
            nameText.text = itemName;
        countText.text = itemCount;
        isEmpty = false;
        SetImageSprite(image);
    }

    public void SwapWithData(string name, int count, Sprite image, bool isEmpty)
    {
        SetInventoryUIElement(name, count, image);
        this.isEmpty = isEmpty;
    }


    private void SetImageSprite(Sprite image)
    {
        itemImage.sprite = image;
    }

    private void ClearItem()
    {
        itemName = "";
        itemCount = "";
        countText.text = itemCount;

        if (!isHotbarItem)
            nameText.text = itemName;
        ResetImage();
        isEmpty = true;
        ToggleHighlight(false);
    }

    private void ToggleHighlight(bool val)
    {
        outline.enabled = val;
    }

    private void ResetImage()
    {
        itemImage.sprite = backgroundSprite;
    }
}
