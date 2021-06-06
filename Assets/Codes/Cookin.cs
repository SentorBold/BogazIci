using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookin : MonoBehaviour
{
    public Sprite PismisElma;
    public Sprite PismisEkmek;
    public Sprite PismisSalatalık;
    public Sprite PismisEt;
    public Sprite PismisPatlican;
    public Sprite PismisMantar;
    public Sprite PismisBeyin;


    public SpriteRenderer Elma;
    public SpriteRenderer Ekmek;
    public SpriteRenderer Salatalık;
    public SpriteRenderer Et;
    public SpriteRenderer Patlican;
    public SpriteRenderer Mantar;
    public SpriteRenderer Beyin;


   
private void OnTriggerEnter2D(Collider2D other)
    {
        print("x");
        if (other.CompareTag("Domates"))
        {
            Debug.Log("Pis");
        }

        if (other.CompareTag("Patlican"))
        {
            Patlican.sprite = PismisPatlican;
            Debug.Log("Pis");
        }
        if (other.CompareTag("Havuc"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Makarna"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Tursu"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Elma"))
        {
            Elma.sprite = PismisElma;
            Debug.Log("Pis");
        }
        if (other.CompareTag("Armut"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Mantar"))
        {
            Mantar.sprite = PismisMantar;
            Debug.Log("Pis");
        }
        if (other.CompareTag("Limon"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Biber"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Tuz"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Ketcap"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Mayonez"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Kolonya"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Ekmek"))
        {
            Ekmek.sprite = PismisEkmek;
            Debug.Log("Pis");
        }
        if (other.CompareTag("Cig kofte"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Aci sos"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Salatalik"))
        {
            Salatalık.sprite = PismisSalatalık;
            Debug.Log("Pis");
        }
        if (other.CompareTag("Et"))
        {
            Et.sprite = PismisEt;
            Debug.Log("Pis");
        }
        if (other.CompareTag("Olu et"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Kan"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Balik"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Beyin"))
        {
            Beyin.sprite = PismisBeyin;
            Debug.Log("Pis");
        }
        if (other.CompareTag("Yarasa"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Zeytinyagi"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Yumurta"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Cheddar"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Nutella"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Kekik"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Tozbiber"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Pul biber"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Zerdecal"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Zencefil"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Tarcin"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Karabiber"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Kimyon"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Barbeku sos"))
        {
            Debug.Log("Pis");
        }
        if (other.CompareTag("Kuru nane"))
        {
            Debug.Log("Pis");
        }
    }
}
