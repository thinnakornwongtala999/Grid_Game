using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetImage : MonoBehaviour
{
    private Image background_main;
    private SpriteRenderer background_null;
    private Image background_qr;
    private Image button_Image;
    private Image background_thank;
    private Image background_Button_home;
    private Image background_Button_num;
    private Image background_Button_num_1;
    private SpriteRenderer background_Button;
    private SpriteRenderer background_Button1;
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            background_main = GameObject.Find("background_main").GetComponent<Image>();
            byte[] textureBytes = File.ReadAllBytes(Application.persistentDataPath + "background_main");
            Texture2D loadedTexture = new Texture2D(0, 0);
            loadedTexture.LoadImage(textureBytes);
            Sprite sprite = Sprite.Create(loadedTexture, new Rect(0, 0, loadedTexture.width, loadedTexture.height), new Vector2(0.5f, 0.5f));
            background_main.sprite = sprite;

            button_Image = GameObject.Find("Button_Image").GetComponent<Image>();
            byte[] textureBytes1 = File.ReadAllBytes(Application.persistentDataPath + "Button_Image");
            Texture2D loadedTexture1 = new Texture2D(0, 0);
            loadedTexture1.LoadImage(textureBytes1);
            Sprite sprite1 = Sprite.Create(loadedTexture1, new Rect(0, 0, loadedTexture1.width, loadedTexture1.height), new Vector2(0.5f, 0.5f));
            button_Image.sprite = sprite1;

            background_Button_num_1 = GameObject.Find("background_Button_num_1").GetComponent<Image>();
            background_Button_num = GameObject.Find("background_Button_num").GetComponent<Image>();
            byte[] textureBytes2 = File.ReadAllBytes(Application.persistentDataPath + "background_Button_num");
            Texture2D loadedTexture2 = new Texture2D(0, 0);
            loadedTexture2.LoadImage(textureBytes2);
            Sprite sprite2 = Sprite.Create(loadedTexture2, new Rect(0, 0, loadedTexture2.width, loadedTexture2.height), new Vector2(0.5f, 0.5f));
            background_Button_num.sprite = sprite2;
            background_Button_num_1.sprite = sprite2;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            background_qr = GameObject.Find("Background_qr").GetComponent<Image>();
            byte[] textureBytes1 = File.ReadAllBytes(Application.persistentDataPath + "Background_qr");
            Texture2D loadedTexture1 = new Texture2D(0, 0);
            loadedTexture1.LoadImage(textureBytes1);
            Sprite sprite1 = Sprite.Create(loadedTexture1, new Rect(0, 0, loadedTexture1.width, loadedTexture1.height), new Vector2(0.5f, 0.5f));
            background_qr.sprite = sprite1;

            background_main = GameObject.Find("background_main").GetComponent<Image>();
            byte[] textureBytes = File.ReadAllBytes(Application.persistentDataPath + "background_main");
            Texture2D loadedTexture = new Texture2D(0, 0);
            loadedTexture.LoadImage(textureBytes);
            Sprite sprite = Sprite.Create(loadedTexture, new Rect(0, 0, loadedTexture.width, loadedTexture.height), new Vector2(0.5f, 0.5f));
            background_main.sprite = sprite;

            background_Button_num = GameObject.Find("background_Button_num").GetComponent<Image>();
            byte[] textureBytes2 = File.ReadAllBytes(Application.persistentDataPath + "background_Button_num");
            Texture2D loadedTexture2 = new Texture2D(0, 0);
            loadedTexture2.LoadImage(textureBytes2);
            Sprite sprite2 = Sprite.Create(loadedTexture2, new Rect(0, 0, loadedTexture2.width, loadedTexture2.height), new Vector2(0.5f, 0.5f));
            background_Button_num.sprite = sprite2;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            background_null = GameObject.Find("background_null").GetComponent<SpriteRenderer>();
            byte[] textureBytes = File.ReadAllBytes(Application.persistentDataPath + "Background_null");
            Texture2D loadedTexture = new Texture2D(0, 0);
            loadedTexture.LoadImage(textureBytes);
            Sprite sprite = Sprite.Create(loadedTexture, new Rect(0, 0, loadedTexture.width, loadedTexture.height), new Vector2(0.5f, 0.5f));
            background_null.sprite = sprite;

            background_Button = GameObject.Find("background_Button").GetComponent<SpriteRenderer>();
            background_Button1 = GameObject.Find("background_Button1").GetComponent<SpriteRenderer>();
            byte[] textureBytes2 = File.ReadAllBytes(Application.persistentDataPath + "Background_Button");
            Texture2D loadedTexture2 = new Texture2D(0, 0);
            loadedTexture2.LoadImage(textureBytes2);
            Sprite sprite2 = Sprite.Create(loadedTexture2, new Rect(0, 0, loadedTexture2.width, loadedTexture2.height), new Vector2(0.5f, 0.5f));
            background_Button.sprite = sprite2;
            background_Button1.sprite = sprite2;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            background_thank = GameObject.Find("background_thank").GetComponent<Image>();
            byte[] textureBytes = File.ReadAllBytes(Application.persistentDataPath + "Background_thank");
            Texture2D loadedTexture = new Texture2D(0, 0);
            loadedTexture.LoadImage(textureBytes);
            Sprite sprite = Sprite.Create(loadedTexture, new Rect(0, 0, loadedTexture.width, loadedTexture.height), new Vector2(0.5f, 0.5f));
            background_thank.sprite = sprite;

            background_Button_home = GameObject.Find("background_Button_home").GetComponent<Image>();
            byte[] textureBytes1 = File.ReadAllBytes(Application.persistentDataPath + "Background_Button_home");
            Texture2D loadedTexture1 = new Texture2D(0, 0);
            loadedTexture1.LoadImage(textureBytes1);
            Sprite sprite1 = Sprite.Create(loadedTexture1, new Rect(0, 0, loadedTexture1.width, loadedTexture1.height), new Vector2(0.5f, 0.5f));
            background_Button_home.sprite = sprite1;
        }
    }

}
