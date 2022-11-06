using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesUI : MonoBehaviour
{
  
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
         
         
    }
}
