using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Envanter : MonoBehaviour
{
    public List<Items> items;
    public int slotMiktar;
    public GameObject slot;

    DataItem dataitem;

    void Start()
    {
        dataitem = GameObject.FindGameObjectWithTag("DataItem").GetComponent<DataItem>();
        for (int i = 0; i < slotMiktar; i++)
        {
            GameObject slotObje = (GameObject)Instantiate(slot);
            slotObje.transform.SetParent(gameObject.transform);
            slotObje.GetComponent<RectTransform>().localScale = new Vector2(1, 1);
            items.Add(new Items());
            
        }
        itemEkle(1, 5);
        itemEkle(2, 3);
    }

    public void itemEkle(int id, int miktar)
    {
        for(int i = 0; i < dataitem.items.Count; i++)  // items.Count uzunluk
        {
            if (dataitem.items[i].itemID == id)
            {
                Items yeniItem = new Items(dataitem.items[i].itemIsmi, dataitem.items[i].itemBilgisi, dataitem.items[i].itemID,
                       miktar, dataitem.items[i].itemStocku,
                       dataitem.items[i].itemHasar, dataitem.items[i].itemTipi);
                BosSlotitemEkle(yeniItem);
            }
        }
    }

    public void BosSlotitemEkle(Items item)
    {
        for(int i = 0; i < items.Count; i++)
        {
            if (items[i].itemIsmi == null)
            {
                items[i] = item;
                break; // For döngüsünden çýksýn.
            }
        }
    }

    void Update()
    {
        
    }
}
