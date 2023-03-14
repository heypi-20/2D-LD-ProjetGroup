using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterController2D controller = collision.gameObject.GetComponent<CharacterController2D>();
        controller.Die();
    }
}
