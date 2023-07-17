using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCollection : MonoBehaviour
{
    private AudioSource click;

    private void Start()
    {
        click = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        { 
            Destroy(other.gameObject);
            click.Play();
        }
    }
}
