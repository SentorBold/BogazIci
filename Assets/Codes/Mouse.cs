using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Texture2D knifemouse;
    public Texture2D realmouse;
    public bool knfie;
    void Start()

    {
        //Cursor.SetCursor(mouse, Vector2.zero,CursorMode.ForceSoftware );
  
    }
    
    // Update is called once per frame
    void Update()
    {     
     
        if (Input.GetKeyDown(KeyCode.K))    
        {
            knfie = true;
        }
        if (knfie == true)
        {

            Cursor.SetCursor(knifemouse, Vector2.zero, CursorMode.ForceSoftware);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            knfie = false;
        }
        if (knfie == false)
        {
            Cursor.SetCursor(realmouse, Vector2.zero, CursorMode.ForceSoftware);
        }

    }
}
