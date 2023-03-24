using UnityEngine;

public class RespawnNoir : MonoBehaviour
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
