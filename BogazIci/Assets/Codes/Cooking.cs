using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour
{
 
    
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag.Equals("Sebze" + "Sos" + "Et" + "Baharatlar" + "Hamur iş" + "İğrenç" + "Kızartmalar"))
        {
           
            print("w");
        }
    }
}
