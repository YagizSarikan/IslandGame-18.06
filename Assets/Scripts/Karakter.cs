using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    public float health, maxHealth, healthReductionSpeed;  //  health reduction speed = can azalma hýzý 
    public float hunger, maxHunger, hungerReductionSpeed;   //  reduction Aclik düþme hýzý (azalma)
    public float water, maxWater, waterReductionSpeed;

    public GameObject healthBar, hungerBar, waterBar;
    void Start()
    {
        health = maxHealth;
        hunger = maxHunger;
        water = maxWater;
    }

    void Update()
    {
        // Bar Olaylarý
        healthBar.transform.localScale = new Vector2(health / maxHealth, 1);
        hungerBar.transform.localScale = new Vector2(hunger / maxHunger, 1);
        waterBar.transform.localScale = new Vector2(water / maxWater, 1);

        if (health <= 0)  // Can Artma Azalma Olaylarý
        { // Oyun bitecek.

        }

        if (health > maxHealth)
        {  // caný 100'e eþitle
            health = maxHealth;
        }

        // Açlýk Olaylarý
        if (hunger > maxHunger)
        {
            hunger = maxHunger;
        }

        if (hunger <= 0)
        {
            hunger = 0;
        }
        if (hunger > 0)
        {
            hunger -= hungerReductionSpeed * Time.deltaTime;
        }

        // Su olaylarý
        if (water > maxWater)
        { 
            water = maxWater;
        }

        if (water <= 0)
        {
            water = 0;
        }

        if (water > 0)
        {
            water -= waterReductionSpeed * Time.deltaTime;
        }

        // Açlýk ve Su
        if (hunger <= 0 && water <= 0)
        {
            health -= healthReductionSpeed * 2 * Time.deltaTime;  // Can 2 Katý hýzlý azalsýn.
        }

        if (hunger <= 0 || water <= 0)
        {
            health -= healthReductionSpeed * Time.deltaTime;  // Normal 1 kat olarak caný azalsýn.
        }
    }
}
