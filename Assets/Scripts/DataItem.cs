using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DataItem : MonoBehaviour
{
    public List<Items> items;

    void Awake()
    {
        items.Add(new Items("","",0,0,0,0,Items.ItemType.Bos));
        items.Add(new Items("�ubuk", "�ubuktan E�ya Yapabilirsin.", 1, 1, 10, 0, Items.ItemType.Malzeme));
        items.Add(new Items("Balta", "Balta ile A�a� Kesebilirsin.", 2, 1, 1, 0, Items.ItemType.Silah));
    }

}
