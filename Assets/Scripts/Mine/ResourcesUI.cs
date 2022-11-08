using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesUI : MonoBehaviour
{
  //Inventory menu 
   public static bool GameIsPaused = false;
   public GameObject pauseMenuUI;
   public GameObject pauseButton;

   //Resources values
   public Text minedoreBronze;
   public Text minedoreIron;
   public Text minedoreDiamond;
    public int mineredBronz;
    public int mineredIron;
    public int mineredDiamond;

    // Update is called once per frame
    void Update()
    {

         minedoreBronze.text = "Bronze: " + mineredBronz; 
         minedoreIron.text = "Iron: " + mineredIron; 
         minedoreDiamond.text = "Diamond: " + mineredDiamond;
         
         if(Input.GetKeyDown(KeyCode.Escape)){
          if(GameIsPaused){
               Resume();
          }else{
               Pause();
          }
         }
    }

     public void Resume() {
     pauseMenuUI.SetActive(false);
     pauseButton.SetActive(true);
     GameIsPaused = false;
    }
     public void Pause() {
     pauseMenuUI.SetActive(true);
      pauseButton.SetActive(false);
     GameIsPaused = true;
    }
}
