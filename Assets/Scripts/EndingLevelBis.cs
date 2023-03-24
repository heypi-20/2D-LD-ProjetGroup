using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingLevelBis : MonoBehaviour
{
    [SerializeField]
    public string levelname;

    [SerializeField]
    private EndingTrigger whiteTrigger;

    [SerializeField]
    private EndingTrigger blackTrigger;

    float playersReady = 0;

    int playersInTrigger = 0;

    private void Start()
    {
        whiteTrigger.OnEntered.AddListener(WhiteEntered);
        whiteTrigger.OnExited.AddListener(WhiteExited);
        blackTrigger.OnEntered.AddListener(BlackEntered);
        blackTrigger.OnExited.AddListener(BlackExited);

    }

    private void WhiteEntered(ColoredCharacter character)
    {
        if(character.color == ElementColor.Color1)
        {
            playersReady++;
            CheckEnd();
        }
    }

    private void WhiteExited(ColoredCharacter character)
    {
        if (character.color == ElementColor.Color1)
        {
            playersReady--;
            CheckEnd();
        }
    }

    private void BlackEntered(ColoredCharacter character)
    {
        if (character.color == ElementColor.Color2)
        {
            playersReady++;
            CheckEnd();
        }
    }

    private void BlackExited(ColoredCharacter character)
    {
        if (character.color == ElementColor.Color2)
        {
            playersReady--;
            CheckEnd();
        }
    }

    private void CheckEnd()
    {
        if(playersReady >= 2)
        {
            SceneManager.LoadScene(levelname);
        }
    }
}
