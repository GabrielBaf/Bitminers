using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAccount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string account = PlayerPrefs.GetString("Account");
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
                print(data);
            }
        }
    }
}
