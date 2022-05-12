using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class CharacterInteraction : MonoBehaviour
{
    public DialogueRunner runner;
    public GameObject Mom;
    public string nodeName;
    public int count; //julia

    void OnTriggerEnter2D(Collider2D col)
    {
        if (count == 0)//julia
        {
            runner.StartDialogue(nodeName);
            count++;//julia
           
        }
        
    }

    [YarnCommand("hide_mom")]
    public void HideMom()
    {
        Mom.SetActive(false);
    }

    [YarnCommand("unhide_mom")]
    public void UnhideMom()
    {
        Mom.SetActive(true);
    }
}
