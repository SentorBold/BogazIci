using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Texture2D mouse;

    void Start()

    {
        Cursor.SetCursor(mouse, Vector2.zero, CursorMode.ForceSoftware);
    }

}
