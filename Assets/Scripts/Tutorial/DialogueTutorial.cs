using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueTutorial : MonoBehaviour
{
    public Queue<string> sentences;
    public Text textDialogueUI,nameText;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

  public void StartDialogue(DialogueClasseTutorial dialogue){
    sentences.Clear();
    nameText.text = dialogue.nameSpeaker;
    foreach(string sentence in dialogue.sentences){
        sentences.Enqueue(sentence);
         
    }
    DisplayNextSentence();
  }
  public void DisplayNextSentence(){
    if(sentences.Count == 0){
        EndDialogue();
        return;
    }
    string sentence = sentences.Dequeue();
    textDialogueUI.text = sentence;
  }
  void EndDialogue(){
    SceneManager.LoadScene(2);
  }
}
