using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sos"))
        {
            Debug.Log("Pi�");
        }
        if (other.CompareTag("Sebze"))
        {
            Debug.Log("Pi�");
        }
        if (other.CompareTag("Et"))
        {
            Debug.Log("Pi�");
        }
        if (other.CompareTag("Baharatlar"))
        {
            Debug.Log("Pi�");
        }
        if (other.CompareTag("Hamur i�"))
        {
            Debug.Log("Pi�");
        }
        if (other.CompareTag("��ren�"))
        {
            Debug.Log("Pi�");
        }
        if (other.CompareTag("K�zartmalar"))
        {
            Debug.Log("Pi�");
        }
















    }
        
}
