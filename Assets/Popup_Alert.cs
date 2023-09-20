using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Popup_Alert : MonoBehaviour
{
    public Image background_AlertError;
    public Image background_AlertSuccess;

    void Start()
    {
        StartCoroutine(GetData_Image());
    }
    private IEnumerator GetData_Image()
    {
        for (int i = 0; i <= 2; i++)
        {
            if (i == 1)
            {
                string uri = LoadDataAPI.Background_AlertSuccess_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                        Debug.Log(request.error);
                    else
                    {
                        Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                        Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                        background_AlertSuccess.sprite = sprite;
                    }
                }
            }
            else if (i == 2)
            {
                string uri = LoadDataAPI.Background_AlertError_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                        Debug.Log(request.error);
                    else
                    {
                        Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                        Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                        background_AlertError.sprite = sprite;
                    }
                }
            }
        }
    }
}
