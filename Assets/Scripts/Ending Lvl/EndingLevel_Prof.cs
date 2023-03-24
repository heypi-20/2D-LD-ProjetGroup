using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingLevel_Prof : MonoBehaviour
{
    [SerializeField]
    public string levelname;

    int playersInTrigger = 0;

    private void OnTriggerEnter2D(Collider2D pCollision)
    {
        if (pCollision.gameObject.CompareTag("Player"))
        {
            playersInTrigger++;
            
        
        }

        if (playersInTrigger >= 2)
        {
            SceneManager.LoadScene(levelname);
        }
    }

    private void OnTriggerExit2D(Collider2D pcollision)
    {
        if (pcollision.gameObject.CompareTag("Player"))
        {
            playersInTrigger--;
        }
    }


}
