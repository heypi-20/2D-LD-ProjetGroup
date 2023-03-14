using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingLVL : MonoBehaviour
{
    [SerializeField]
    private GameObject Ending;
    private void OnTriggerEnter2D(Collider2D pCollision)
    {
        if (pCollision.gameObject.CompareTag("Player"))
        {
            Ending.SetActive(true);
        }
    }

}
