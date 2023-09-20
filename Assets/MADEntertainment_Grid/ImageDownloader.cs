using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ImageDownloader : MonoBehaviour
{

    [SerializeField] Image textureImage;
    [SerializeField] GameObject loadimage_Failde;

    private void Start()
    {
        StartCoroutine(LoadTextureFromWeb());
    }

    IEnumerator LoadTextureFromWeb()
    {
        yield return new WaitForSeconds(3);
        for (int i = 0; i <= 13; i++)
        {
            if (i == 1)
            {
                string uri = LoadDataAPI.Background_main_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                        Debug.Log(request.error);
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "background_main", textureBytes);
                    }
                }
            }
            else if (i == 2)
            {
                string uri = LoadDataAPI.Background_Button_tap_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                        Debug.Log(request.error);
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "Button_Image", textureBytes);
                    }
                }
            }
            else if (i == 3)
            {
                string uri = LoadDataAPI.Background_Button_num_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                        Debug.Log(request.error);
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "background_Button_num", textureBytes);
                    }
                }
            }
            else if (i == 4)
            {
                string uri = LoadDataAPI.Background_qr_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                        Debug.Log(request.error);
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "Background_qr", textureBytes);
                    }
                }
            }
            else if (i == 5)
            {
                string uri = LoadDataAPI.Background_null_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                        Debug.Log(request.error);
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "Background_null", textureBytes);
                    }
                }
            }
            else if (i == 6)
            {
                string uri = LoadDataAPI.Background_thank_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                        Debug.Log(request.error);
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "Background_thank", textureBytes);
                    }
                }
            }
            else if (i == 7)
            {
                string uri = LoadDataAPI.Background_Button_home_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                        Debug.Log(request.error);
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "Background_Button_home", textureBytes);
                    }
                }
            }
            else if (i == 8)
            {
                string uri = LoadDataAPI.Background_AlertSuccess_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                        Debug.Log(request.error);
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "Background_AlertSuccess", textureBytes);
                    }
                }
            }
            else if (i == 9)
            {
                string uri = LoadDataAPI.Background_AlertError_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                        Debug.Log(request.error);
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "Background_AlertError", textureBytes);
                    }
                }
            }
            else if (i == 10)
            {
                string uri = LoadDataAPI.Background_Alert_timeout_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                    {
                        Debug.Log(request.error);
                        loadimage_Failde.SetActive(true);
                    }       
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "Background_Alert_timeout", textureBytes);
                    }
                }
            }
            else if (i == 11)
            {
                string uri = LoadDataAPI.Background_Button_press_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                    {
                        Debug.Log(request.error);
                        loadimage_Failde.SetActive(true);
                    }
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "Background_Button_press", textureBytes);
                    }
                }
            }
            else if (i == 12)
            {
                string uri = LoadDataAPI.Background_Button_click_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                    {
                        Debug.Log(request.error);
                        loadimage_Failde.SetActive(true);
                    }
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "Background_Button_click", textureBytes);
                    }
                }
            }
            else if (i == 13)
            {
                string uri = LoadDataAPI.Background_Button_uri;
                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                {
                    yield return request.SendWebRequest();
                    if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                    {
                        Debug.Log(request.error);
                        loadimage_Failde.SetActive(true);
                    }
                    else
                    {
                        Texture2D loadedTexture = DownloadHandlerTexture.GetContent(request);
                        textureImage.sprite = Sprite.Create(loadedTexture, new Rect(0f, 0f, loadedTexture.width, loadedTexture.height), Vector2.zero);
                        byte[] textureBytes = textureImage.sprite.texture.EncodeToPNG();
                        File.WriteAllBytes(Application.persistentDataPath + "Background_Button", textureBytes);
                        Debug.Log("File Written On Disk!");
                        SceneManager.LoadScene("Home");
                    }
                }
            }
        }
    }
}