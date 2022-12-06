using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerAccount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //string account = PlayerPrefs.GetString("Account");
        string account = "0x920192019200a9f0a9s92s09a0s960sa";
      // string account = "0x1F571B139599e93F927ec393dDdCF80305eB7C9d"; 
        //PlayerPrefs.SetString("Wallet", account);
        StartCoroutine(LoginCheck(account));
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoginCheck(string pAccount)
    {
        WWWForm form = new WWWForm();
        form.AddField("wallet_address", pAccount);

        using (UnityWebRequest www = UnityWebRequest.Post("http://127.0.0.1:8000/api/check-user", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                string data = www.downloadHandler.text;
                //Debug.Log(data);
                PlayerPrefs.SetString("PlayerInfo", data);
                //print(data);
            }
        }
    }
    public void NextScene(){
        SceneManager.LoadScene(1);
    }
    
    // public void MyJson(){
    //     public int userid;
    //     public int inventoryId;
    //     public int bronzeOre;
    //     public int ironOre;
    //     public int silverOre;
    //     public int goldOre;
    //     public int diamondOre;
    // }
}
