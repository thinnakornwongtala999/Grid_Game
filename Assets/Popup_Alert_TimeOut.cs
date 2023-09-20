using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Popup_Alert_TimeOut : MonoBehaviour
{
    public Image background_Alert_timeout;

    void Start()
    {
        StartCoroutine(GetData_Image());
    }
    private IEnumerator GetData_Image()
    {
        string uri = LoadDataAPI.Background_Alert_timeout_uri;
        using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
        {
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                Debug.Log(request.error);
            else
            {
                Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                background_Alert_timeout.sprite = sprite;
            }
        }
    }
}
