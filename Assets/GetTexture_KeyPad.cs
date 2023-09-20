using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GetTexture_KeyPad : MonoBehaviour
{
    [SerializeField] Image background_Button_1;
    [SerializeField] Image background_Button_2;
    [SerializeField] Image background_Button_3;
    [SerializeField] Image background_Button_4;
    [SerializeField] Image background_Button_5;
    [SerializeField] Image background_Button_6;
    [SerializeField] Image background_Button_7;
    [SerializeField] Image background_Button_8;
    [SerializeField] Image background_Button_9;
    [SerializeField] Image background_Button_0;
    [SerializeField] Image background_Button_C;
    [SerializeField] Image background_Button_D;
    void Start()
    {
        byte[] textureBytes = File.ReadAllBytes(Application.persistentDataPath + "background_Button_num");
        Texture2D loadedTexture = new Texture2D(0, 0);
        loadedTexture.LoadImage(textureBytes);
        Sprite sprite = Sprite.Create(loadedTexture, new Rect(0, 0, loadedTexture.width, loadedTexture.height), new Vector2(0.5f, 0.5f));
        background_Button_0.sprite = sprite;
        background_Button_1.sprite = sprite;
        background_Button_2.sprite = sprite;
        background_Button_3.sprite = sprite;
        background_Button_4.sprite = sprite;
        background_Button_5.sprite = sprite;
        background_Button_6.sprite = sprite;
        background_Button_7.sprite = sprite;
        background_Button_8.sprite = sprite;
        background_Button_9.sprite = sprite;
        background_Button_C.sprite = sprite;
        background_Button_D.sprite = sprite;
    }
}
