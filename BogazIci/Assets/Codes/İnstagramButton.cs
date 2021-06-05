using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İnstagramButton : MonoBehaviour
{
    public Animator instagram;
    public bool anim ;

    void Start()
    {
        instagram = GetComponent<Animator>();
    }

    public void Instagram()
    {
        anim = true;
        if (anim == true)
        {
            instagram.Play("Camera move");
        }
    }
}
