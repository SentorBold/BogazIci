using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sos"))
        {
            Debug.Log("Piþ");
        }
        if (other.CompareTag("Sebze"))
        {
            Debug.Log("Piþ");
        }
        if (other.CompareTag("Et"))
        {
            Debug.Log("Piþ");
        }
        if (other.CompareTag("Baharatlar"))
        {
            Debug.Log("Piþ");
        }
        if (other.CompareTag("Hamur iþ"))
        {
            Debug.Log("Piþ");
        }
        if (other.CompareTag("Ýðrenç"))
        {
            Debug.Log("Piþ");
        }
        if (other.CompareTag("Kýzartmalar"))
        {
            Debug.Log("Piþ");
        }
















    }
        
}
