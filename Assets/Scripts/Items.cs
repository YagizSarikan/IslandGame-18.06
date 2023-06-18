using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Items // 
{
    [Header("Item")]
    public string itemIsmi, itemBilgisi;
    public int itemID, itemMiktari, itemStocku, itemHasar;
    public Sprite itemIcon;
    public GameObject itemModel;
    public ItemType itemTipi;

    public enum ItemType
    { 
        Silah,
        Malzeme,
        Yiyecek,
        Bos  // Boþ Slot
    }

    public Items(string itemName, string bilgi, int ID, int miktar, int Stock, int hasar, ItemType tip)
    {
        itemIsmi = itemName;
        itemBilgisi = bilgi;
        itemID = ID;
        itemMiktari = miktar;
        itemStocku = Stock;
        itemHasar = hasar;
        itemTipi = tip;
        itemIcon = Resources.Load<Sprite> (ID.ToString());
        itemModel = Resources.Load<GameObject> ("Kup");
    }
    public Items()
    {

    }
}
