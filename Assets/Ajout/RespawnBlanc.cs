using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBlanc : MonoBehaviour
{
    public GameObject Player;
    public GameObject RespawnPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.transform.position = RespawnPoint.transform.position;
        }
    }

}

