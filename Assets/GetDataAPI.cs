using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class GetDataAPI : MonoBehaviour
{
    [SerializeField] TMP_InputField inputFieldWeb;
    void GetDataWeb() => StartCoroutine(GetData_Coroutine());

    IEnumerator GetData_Coroutine()
    {
        inputFieldWeb.text = "Loading...";
        string uri = "https://postman-echo.com/post";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                Debug.Log(request.error);
            else
            {
                inputFieldWeb.text = request.downloadHandler.text;

            }
        }
    }
    public void btnGet()
    {
        GetDataWeb();
    }
}
