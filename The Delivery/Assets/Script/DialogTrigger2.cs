using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger2 : MonoBehaviour
{
    public Dialogue dialogue;
    //public GameObject button;

    /*public void Start()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        gameObject.SetActive(false);
    }*/
    private void Update()
    {
        TriggerDialogue();
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogManager2>().StartDialogue(dialogue);
        gameObject.SetActive(false);
    }
}
