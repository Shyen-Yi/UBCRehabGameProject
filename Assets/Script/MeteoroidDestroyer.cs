using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroidDestroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Destroy meteoroids when they leave a certain area
        if (collision.CompareTag("Meteoroid"))
        {
            Destroy(collision.gameObject);
        }
    }
}