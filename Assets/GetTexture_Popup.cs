using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetTexture_Popup : MonoBehaviour
{
    [SerializeField] Image background_AlertError;
    [SerializeField] Image background_AlertSuccess;
    [SerializeField] Image background_AlertTimeout;
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            byte[] textureBytes = File.ReadAllBytes(Application.persistentDataPath + "Background_AlertSuccess");
            Texture2D loadedTexture = new Texture2D(0, 0);
            loadedTexture.LoadImage(textureBytes);
            Sprite sprite = Sprite.Create(loadedTexture, new Rect(0, 0, loadedTexture.width, loadedTexture.height), new Vector2(0.5f, 0.5f));
            background_AlertSuccess.sprite = sprite;

            byte[] textureBytes1 = File.ReadAllBytes(Application.persistentDataPath + "Background_AlertError");
            Texture2D loadedTexture1 = new Texture2D(0, 0);
            loadedTexture1.LoadImage(textureBytes1);
            Sprite sprite1 = Sprite.Create(loadedTexture1, new Rect(0, 0, loadedTexture1.width, loadedTexture1.height), new Vector2(0.5f, 0.5f));
            background_AlertError.sprite = sprite1;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            byte[] textureBytes = File.ReadAllBytes(Application.persistentDataPath + "Background_Alert_timeout");
            Texture2D loadedTexture = new Texture2D(0, 0);
            loadedTexture.LoadImage(textureBytes);
            Sprite sprite = Sprite.Create(loadedTexture, new Rect(0, 0, loadedTexture.width, loadedTexture.height), new Vector2(0.5f, 0.5f));
            background_AlertTimeout.sprite = sprite;
        }
        //StartCoroutine(GetData_Image());
    }
    /*private IEnumerator GetData_Image()
    {
        for (int i = 0; i <= 3; i++)
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
            else if (i == 3)
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

                        background_AlertTimeout.sprite = sprite;
                    }
                }
            }
        }
    }*/
}
