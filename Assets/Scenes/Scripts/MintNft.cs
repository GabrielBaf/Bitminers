using System.Collections;
using UnityEngine.Networking;
using UnityEngine;

public class MintNft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string account = PlayerPrefs.GetString("Account");
        StartCoroutine(MintNftFunc(account));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MintNftFunc(string pAccount)
    {
        WWWForm form = new WWWForm();
        form.AddField("wallet_address", pAccount);
        

        using (UnityWebRequest www = UnityWebRequest.Post("http://127.0.0.1:8000/api/check-user/", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }

        using (UnityWebRequest www2 = UnityWebRequest.Post("http://127.0.0.1:8000/api/mint-nft/", form))
        {
            yield return www2.SendWebRequest();

            if (www2.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www2.error);
            }
            else
            {
                Debug.Log(www2.downloadHandler.text);
            }
        }
    }
}
