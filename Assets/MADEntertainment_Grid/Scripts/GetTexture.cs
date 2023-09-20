using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetTexture : MonoBehaviour
{
    public static Image background_main;
    private SpriteRenderer background_null;
    public static Image background_qr;
    private Image button_Image;
    private Image background_thank;
    private Image background_Button_home;
    private Image background_Button_num;
    private Image background_Button_num_1;
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            background_main = GameObject.Find("background_main").GetComponent<Image>();
            button_Image = GameObject.Find("Button_Image").GetComponent<Image>();
            background_Button_num = GameObject.Find("background_Button_num").GetComponent<Image>();
            background_Button_num_1 = GameObject.Find("background_Button_num_1").GetComponent<Image>();

        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            background_qr = GameObject.Find("Background_qr").GetComponent<Image>();
            background_main = GameObject.Find("background_main").GetComponent<Image>();
            background_Button_num = GameObject.Find("background_Button_num").GetComponent<Image>();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            background_null = GameObject.Find("background_null").GetComponent<SpriteRenderer>();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            background_thank = GameObject.Find("background_thank").GetComponent<Image>();
            background_Button_home = GameObject.Find("background_Button_home").GetComponent<Image>();
        }
        StartCoroutine(GetData_Image());
    }
    IEnumerator GetData_Image()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            for (int i = 0; i <= 4; i++)
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
                            Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                            background_main.sprite = sprite;
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
                            Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                            button_Image.sprite = sprite;
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
                            Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                            background_Button_num_1.sprite = sprite;
                        }
                    }
                }
                else if (i == 4)
                {
                    string uri = LoadDataAPI.Background_Button_num_uri;
                    using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                    {
                        yield return request.SendWebRequest();
                        if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                            Debug.Log(request.error);
                        else
                        {
                            Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                            background_Button_num.sprite = sprite;
                        }
                    }
                }
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (i == 1)
                {
                    string uri = LoadDataAPI.Background_qr_uri;
                    using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                    {
                        yield return request.SendWebRequest();
                        if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                            Debug.Log(request.error);
                        else
                        {
                            Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                            background_qr.sprite = sprite;
                        }
                    }
                }
                else if (i == 2)
                {
                    string uri = LoadDataAPI.Background_main_uri;
                    using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                    {
                        yield return request.SendWebRequest();
                        if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                            Debug.Log(request.error);
                        else
                        {
                            Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                            background_main.sprite = sprite;
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
                            Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                            background_Button_num.sprite = sprite;
                        }
                    }
                }
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            for (int i = 0; i <= 1; i++)
            {
                if (i == 1)
                {
                    string uri = LoadDataAPI.Background_null_uri;
                    using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                    {
                        yield return request.SendWebRequest();
                        if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                            Debug.Log(request.error);
                        else
                        {
                            Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                            background_null.sprite = sprite;
                        }
                    }
                }
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (i == 1)
                {
                    string uri = LoadDataAPI.Background_thank_uri;
                    using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                    {
                        yield return request.SendWebRequest();
                        if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                            Debug.Log(request.error);
                        else
                        {
                            Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                            background_thank.sprite = sprite;
                        }
                    }
                }
                else if (i == 2)
                {
                    string uri = LoadDataAPI.Background_Button_home_uri;
                    using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
                    {
                        yield return request.SendWebRequest();
                        if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
                            Debug.Log(request.error);
                        else
                        {
                            Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
                            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

                            background_Button_home.sprite = sprite;
                        }
                    }
                }
            }
        }
    }
}
