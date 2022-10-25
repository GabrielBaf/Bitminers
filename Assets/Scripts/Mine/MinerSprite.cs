using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MinerSprite : MonoBehaviour
{
    public Sprite[] sprites;
    private int oldSprite;
    private int newSprite;
    private List<int> availableSprites = new List<int>();

    public Text minedoreBronze;
    public int mineredBronz;
    public Text minedoreIron;
    public int mineredIron;
    public Text minedoreDiamond;
    public int mineredDiamond;
    public int minedOreAmount = 0;
    private string oreType;
    public float hitPoints;
    
    public float[] minerios = {60,30,10};
    public string[] mineriosNomes = {"bronze","prata","diamante"};
    public float lootValue;
    public float lootValueMax;
    // Start is called before the first frame update
    void Start()
    {
        oldSprite = 0;

        for(int i = 0; i < sprites.Length;i++){
            availableSprites.Add(i);
        }
    }

 
    public void Picked(int damage){

        hitPoints -= damage;
   
    if(hitPoints <= 0){
        //Destroy(this.gameObject);
       // LootCalc();
         foreach (var item in minerios)
        {
            lootValueMax += item;
        }
        lootValue = Random.Range(0,lootValueMax);

        for(int i =0; i <= minerios.Length;i++){
            if(lootValue <= minerios[i])
            {
                oreType += mineriosNomes[i];
                if(i == 0){
                    mineredBronz ++;
                    minedoreBronze.text = "Bronze: " + mineredBronz; 
                }else if(i == 1){
                     mineredIron ++;
                    minedoreIron.text = "Iron: " + mineredIron; 
                }else{
                    mineredDiamond ++;
                    minedoreDiamond.text = "Diamond: " + mineredDiamond;
                }
                hitPoints = 3;
                lootValueMax = 0;
                lootValue = 0;
                return;
            }else
            {
                lootValue -= minerios[i];
            }
    }
        
    }
    availableSprites.Remove(oldSprite);
    newSprite = availableSprites[Random.Range(0,availableSprites.Count)];
    GetComponent<SpriteRenderer>().sprite = sprites[newSprite];
    availableSprites.Add(oldSprite);
    oldSprite = newSprite;
     
    }
// public static LootCalc(){
//         foreach (var item in minerios)
//         {
//             lootValueMax += item;
//         }
//      lootValue = Random.Range(0,lootValueMax);

//         for(int i =0; i <= minerios.Length;i++){
//             if(randomNumber <= table[i])
//             {
//                 oreType = mineriosNomes[i];
//                 return;
//             }else
//             {
//                 randomNumber -= table[i];
//             }
//     }
// }
 
}

