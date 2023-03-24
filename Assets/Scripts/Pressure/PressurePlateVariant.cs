using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateVariant : MonoBehaviour
{
    public Vector3 originalPos;
    bool MoveBack = false;
    public GameObject TrucACTIVALBE;
    public GameObject Here;
    public Vector3 HerePos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
        HerePos = Here.transform.position;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            transform.Translate(0, -0.1f, 0);
            //MoveBack = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.transform.parent = transform;
            GetComponent<SpriteRenderer>().color = Color.green;
            TrucACTIVALBE.transform.position = HerePos;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            //MoveBack = true;
            collision.transform.parent = null;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
    private void Update()
    {
        if (MoveBack)
        {
            if (transform.position.y < originalPos.y)
            {
                transform.Translate(0, 0.1f, 0);

            }
            else
            {
                //MoveBack = false;
            }
        }
    }
}
