using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingZone : MonoBehaviour
{
    public float timeBetweenHeals = 1.0f; // seconds
    float healTimer;

    void OnTriggerStay2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            healTimer -= Time.deltaTime;

            if (healTimer <= 0)
            {
                controller.ChangeHealth(1);
                healTimer = timeBetweenHeals;
            }
        }
    }
}
