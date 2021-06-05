using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SS1 : MonoBehaviour
{
    public Image ss;
    public void SS(){
StartCoroutine(TakeScreenshot());
}

public IEnumerator TakeScreenshot()
{

    string imageName = "screenshot.png";

    // Take the screenshot
    ScreenCapture.CaptureScreenshot(imageName);

    //Wait for 4 frames
    for (int i = 0; i < 5; i++)
    {
        yield return null;
    }

    // Read the data from the file
    byte[] data = File.ReadAllBytes(Application.persistentDataPath + "/" + imageName);

    // Create the texture
    Texture2D screenshotTexture = new Texture2D(Screen.width, Screen.height);

    // Load the image
    screenshotTexture.LoadImage(data);

    // Create a sprite
    Sprite screenshotSprite = Sprite.Create(screenshotTexture, new Rect(0, 0, Screen.width, Screen.height), new Vector2(0.5f, 0.5f));

    // Set the sprite to the screenshotPreview
    ss.GetComponent<Image>().sprite = screenshotSprite;

}
}
