using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosinFood : MonoBehaviour
{
    public bool CanIChoose;
    
    public bool choosenCucumber;
    public bool choosenTomato;
    public bool choosenPickles;
    public bool choosenEggplant;
    public bool choosenMeat;
    public bool choosenMushroom;
    public bool choosenLemon;
    public bool choosenSalt;
    public bool choosenApple;
    public bool choosenFish;
    public bool choosenBrain;
    public bool choosenBat;

    public GameObject cucumber;
    public GameObject tomato;
    public GameObject pickles;
    public GameObject eggplant;
    public GameObject meat;
    public GameObject mushroom;
    public GameObject lemon;
    public GameObject salt;
    public GameObject apple;
    public GameObject fish;
    public GameObject brain;
    public GameObject bat;

    public int choose;
    
    void Start()
    {
        CanIChoose = true;
        choose = 6;
    }
    


    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(choose);
        if (choose < 1)
        {
            CanIChoose = false;
            Debug.Log("hakkýn doldu");
        }
    }
    public void Cucumber()
    {
        if (CanIChoose)
        {
            choosenCucumber = true;
            Debug.Log(choosenCucumber);
            cucumber.SetActive(false);
            choose -= 1;
        }
        
    }
    public void Tomato()
    {
        if (CanIChoose)
        {
            choosenTomato = true;
            Debug.Log(choosenTomato);
            tomato.SetActive(false);
            choose -= 1;
        }
        
    }
    public void Pickles()
    {
        if (CanIChoose)
        {
            choosenPickles = true;
            Debug.Log(choosenPickles);
            pickles.SetActive(false);
            choose -= 1;
        }
        
    }
    public void Eggplant()
    {
        if (CanIChoose)
        {
            choosenEggplant = true;
            Debug.Log(choosenEggplant);
            eggplant.SetActive(false);
            choose -= 1;
        }
        
    }
    public void Meat()
    {
        if (CanIChoose)
        {
            choosenMeat = true;
            Debug.Log(choosenMeat);
            meat.SetActive(false);
            choose -= 1;
        }
       
    }
    public void Mushroom()
    {
        if (CanIChoose)
        {
            choosenMushroom = true;
            Debug.Log(choosenMushroom);
            mushroom.SetActive(false);
            choose -= 1;
        }
       
    }
    public void Lemon()
    {
        if (CanIChoose)
        {
            choosenLemon = true;
            Debug.Log(choosenLemon);
            lemon.SetActive(false);
            choose -= 1;
        }
        
    }
    public void Salt()
    {
        if (CanIChoose)
        {
            choosenSalt = true;
            Debug.Log(choosenSalt);
            salt.SetActive(false);
            choose -= 1;
        }
        
    }
    public void Apple()
    {
        if (CanIChoose)
        {
            choosenApple = true;
            Debug.Log(choosenApple);
            apple.SetActive(false);
            choose -= 1;
        }
        
    }
    public void Fish()
    {
        if (CanIChoose)
        {
            choosenFish = true;
            Debug.Log(choosenFish);
            fish.SetActive(false);
            choose -= 1;
        }
        
    }
    public void Brain()
    {
        if (CanIChoose)
        {
            choosenBrain = true;
            Debug.Log(choosenBrain);
            brain.SetActive(false);
            choose -= 1;
        }
        
    }
    public void Bat()
    {
        if (CanIChoose)
        {
            choosenBat = true;
            Debug.Log(choosenBat);
            bat.SetActive(false);
            choose -= 1;
        }
        
    }

































}
