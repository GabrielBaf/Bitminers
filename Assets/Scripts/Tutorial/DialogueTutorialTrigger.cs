using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTutorialTrigger : MonoBehaviour
{
   public DialogueClasseTutorial dialogue;
   public GameObject comunMiner,MinerSlot2,minerSprite2,Ore2;
   public Text bronzeOre;
   public void Start(){
    StartDialogue();
   }

   public void StartDialogue(){
    FindObjectOfType<DialogueTutorial>().StartDialogue(dialogue);
   }
   public void SpawnComumTutorial(){
    bronzeOre.text = "Bronze: 0";
    comunMiner.SetActive(true);
   }
   public void EquipMinerTutorial(){
      comunMiner.SetActive(false);
    MinerSlot2.SetActive(true);
    minerSprite2.SetActive(true);
    Ore2.SetActive(true);
   }
}
