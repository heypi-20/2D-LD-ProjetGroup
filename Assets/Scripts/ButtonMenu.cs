using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public string sceneName; // Nom de la sc¨¨ne que vous voulez charger

    public void OnMenuButtonPressed()
    {
        SceneManager.LoadScene(sceneName);
    }
}
