using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Unit : MonoBehaviour
{
    int currentHealth;
    int maxHealth = 100;
    int healthRestoreAmount = 5;
    float timerHoT = 0.5f;
    float timerLength = 3f;

    public void Start()
    {
        ReceiveHealing(currentHealth, maxHealth, healthRestoreAmount, timerHoT, timerLength);
    }

    private void ReceiveHealing(int cHealth, int mHealth, int amount, float timesPerSec, float length)
    {
        float upheal = amount * timesPerSec * length;
        int wound = mHealth - cHealth;
        if (upheal < wound)
            ThreeSecondsHealing(cHealth, amount, timesPerSec, length);
        else
            FullHpHealing(cHealth, mHealth, amount, timesPerSec);
    }

    IEnumerator ThreeSecondsHealing(int health, int healthRestore, float timesPerSecond, float healingLength)
    {
        float time = 0;
        while (time < healingLength)
        {
            yield return new WaitForSeconds(timesPerSecond);
            health += healthRestore;
            time += timesPerSecond;
        }
    }
    IEnumerator FullHpHealing(int health, int healthMax, int healthRestore, float timesPerSecond)
    {
        while (health < healthMax)
        {
            yield return new WaitForSeconds(timesPerSecond);
            health += healthRestore;
        }
    }
}
