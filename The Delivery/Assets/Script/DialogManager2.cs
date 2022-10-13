using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogManager2 : MonoBehaviour
{
    public Text nameText;
    public Text DialogueText;
    public Animator animator;
    public GameObject quest;
    //public string scene;
    private Queue<string> kata;
    // Start is called before the first frame update
    void Start()
    {
        kata = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);
        //Debug.Log("Memulai scene");
        nameText.text = dialogue.name;
        kata.Clear();

        foreach (string kalimat in dialogue.kalimat)
        {
            kata.Enqueue(kalimat);
        }

        DisplayNextKalimat();
    }

    public void DisplayNextKalimat()
    {
        if (kata.Count == 0)
        {
            EndDialogue();
            return;
        }

        string kalimat = kata.Dequeue();
        //Debug.Log(kalimat);
        DialogueText.text = kalimat;
    }



    public void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        Debug.Log("Selesai!");
        quest.SetActive(true);
    }
}
