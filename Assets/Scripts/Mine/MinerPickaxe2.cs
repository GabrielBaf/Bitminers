using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinerPickaxe2 : MonoBehaviour
{
    public int damage;
    private float time = 0.0f;
    public float delayTime = 10.0f;
     public MinerRock2 miner2;

      IEnumerator ExecuteAfterTime(float time)
        {
     
        yield return new WaitForSeconds(time);
        
        miner2.Picked(damage);
        }
   public void Update() {
       time += Time.deltaTime;

       if(time >= delayTime){
        time = 0.0f;
        MinerTime();
      }
  
  }
  private void Start() {
     MinerTime();
  }
  public void MinerTime(){
      StartCoroutine(ExecuteAfterTime(3));
      StartCoroutine(ExecuteAfterTime(6));
      StartCoroutine(ExecuteAfterTime(9));
  }

}
