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

            max.gameObject.SetActive(true);

          }
       else if (gameObject.tag.Equals("Beyin"))
        {
            max.gameObject.SetActive(true);
        }
        else
        {
            min.gameObject.SetActive(true);


        }


       
    }




}
