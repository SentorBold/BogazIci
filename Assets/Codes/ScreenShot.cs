using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class ScreenShot : MonoBehaviour
{

    public RawImage SS;
   
   public GameObject finalScreenShot;


    private IEnumerator takeScreenshot()
    {
        ScreenCapture.CaptureScreenshot("karilarbanahayran.png", 0);
        yield return new WaitForEndOfFrame();
        yield return new WaitForSecondsRealtime(1.5f);
        GetPhoto();

        StartCoroutine(takeScreenshot());
    }
    public void GetPhoto()
    {
    string url  = Application.persistentDataPath + "/" + "karilarbanahayran.png";
        var bytes = File.ReadAllBytes(url);
        Texture2D texture = new Texture2D(2, 2);
        bool imageLoadSuccess = texture.LoadImage(bytes);
        while (!imageLoadSuccess)
        {
            print("image load failed");
            bytes = File.ReadAllBytes(url);
            imageLoadSuccess = texture.LoadImage(bytes);
        }
        print("Image load success: " + imageLoadSuccess);
        finalScreenShot.GetComponent<Image>().overrideSprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0f, 0f), 100f);
    }
}

