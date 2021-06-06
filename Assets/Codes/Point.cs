using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public Text max;
    public bool max1;
    public Text min;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag.Equals("Yarasa"))
        {

            max.enabled = true;

          }
       else if (gameObject.tag.Equals("Beyin"))
        {
            max.enabled = true;
        }
        else
        {
            min.enabled = true;


        }


       
    }




}
