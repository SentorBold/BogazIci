using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenShot : MonoBehaviour
{
    public RawImage SS;
    // Start is called before the first frame update
 public void ss()
    {
        int randomNumber = Random.Range(0,10000);
        string filePath = "Assets/" + "SS" + randomNumber + ".png";
        ScreenCapture.CaptureScreenshot(filePath);
        SS.texture = LoadPNG(filePath);

    }

    private static Texture2D LoadPNG(string filePath)
    {
       
        Texture2D tex = null;
        byte[] fileData;

        if (System.IO.File.Exists(filePath))
        {
            fileData = System.IO.File.ReadAllBytes(filePath);
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
        }
        return tex;
    }

}
