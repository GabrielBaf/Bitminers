using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinerRock2 : MonoBehaviour
{
    public Sprite[] sprites;
    private int oldSprite;
    private int newSprite;
    private List<int> availableSprites = new List<int>();

    
   
    private string oreType;
    public float hitPoints;
    public ResourcesUI UI;
    
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
                    UI.mineredBronz ++;
                }else if(i == 1){
                     UI.mineredIron ++;
                   
                }else{
                    UI.mineredDiamond ++;
                    
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
}
