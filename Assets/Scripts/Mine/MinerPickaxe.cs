using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinerPickaxe : MonoBehaviour
{
	public int damage;
    public MinerSprite miner;
    private float time = 0.0f;
    public float delayTime = 10.0f;
 /* private void OnTriggerEnter2D(Collider2D col){
	  if(col.isTrigger == true && col.CompareTag("Ore")){
		  col.GetComponent<MinerSprite>().Picked(damage);
	  }
  }*/
  IEnumerator ExecuteAfterTime(float time)
        {
     
        yield return new WaitForSeconds(time);
        
        miner.Picked(damage);
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
