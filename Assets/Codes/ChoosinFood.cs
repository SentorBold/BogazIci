using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosinFood : MonoBehaviour
{
    public GameObject place1;
    public GameObject place2;
    public GameObject place3;
    public GameObject place4;
    public GameObject place5;
    public GameObject place6;
    public bool CanIChoose;


    public bool choosen0;
    public bool choosen1;
    public bool choosen2;
    public bool choosen3;
    public bool choosen4;
    public bool choosen5;
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
    public bool choosenMayonnaise;

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
    public GameObject mayonnaise;

    public int choose;
    
    void Start()
    {
        CanIChoose = true;
        choose = 6;
    }
    


    // Update is called once per frame
    void Update()
    {
        if (choose == 5)
        {
            choosen5 = true;
            print("choosen5");
        }
        if (choose == 4)
        {
            choosen5 = false;
            choosen4 = true;
            print("choosen4");
        }
        if (choose == 3)
        {
            
            choosen4 = false;
            choosen3 = true;
            print("choosen3");
        }
        if (choose == 2)
        {
            choosen3 = false;
            choosen2 = true;
            print("choosen2");
        }
        if (choose == 1)
        {
            choosen2 = false;
            choosen1 = true;
            print("choosen1");
        }
        if (choose == 0)
        {
            choosen1 = false;
            choosen0 = true;
        }

        Debug.Log(choose);
        if (choose < 1)
        {
            CanIChoose = false;
            Debug.Log("hakkýn doldu");

        }
    }
    void LateUpdate()
    {
        //5
        if (choosen5 && choosenCucumber)
        {
            cucumber.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenCucumber = false;
        }
        if (choosen5 && choosenTomato)
        {
            tomato.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenTomato = false;
        }
        if (choosen5 && choosenPickles)
        {
            pickles.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenPickles = false;
        }
        if (choosen5 && choosenEggplant)
        {
            eggplant.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenEggplant = false;
        }
        if (choosen5 && choosenMeat)
        {
            meat.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenMeat = false;
        }
        if (choosen5 && choosenMushroom)
        {
            mushroom.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenMushroom = false;
        }
        if (choosen5 && choosenLemon)
        {
            lemon.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenLemon = false;
        }
        if (choosen5 && choosenSalt)
        {
            salt.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenSalt = false;
        }
        if (choosen5 && choosenApple)
        {
            apple.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenApple = false;
        }
        if (choosen5 && choosenFish)
        {
            fish.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenFish = false;
        }
        if (choosen5 && choosenBrain)
        {
            brain.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenBrain = false;
        }
        if (choosen5 && choosenBat)
        {
            bat.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenBat = false;
        }
        if (choosen5 && choosenMayonnaise)
        {
            mayonnaise.transform.position = new Vector2(place1.transform.position.x, place1.transform.position.y);
            choosenMayonnaise = false;
        }
        //4
        if (choosen4 && choosenCucumber)
        {
            cucumber.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenCucumber = false;
        }
        if (choosen4 && choosenTomato)
        {
            tomato.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenTomato = false;
        }
        if (choosen4 && choosenPickles)
        {
            pickles.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenPickles = false;
        }
        if (choosen4 && choosenEggplant)
        {
            eggplant.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenEggplant = false;
        }
        if (choosen4 && choosenMeat)
        {
            meat.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenMeat = false;
        }
        if (choosen4 && choosenMushroom)
        {
            mushroom.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenMushroom = false;
        }
        if (choosen4 && choosenLemon)
        {
            lemon.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenLemon = false;
        }
        if (choosen4 && choosenSalt)
        {
            salt.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenSalt = false;
        }
        if (choosen4 && choosenApple)
        {
            apple.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenApple = false;
        }
        if (choosen4 && choosenFish)
        {
            fish.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenFish = false;
        }
        if (choosen4 && choosenBrain)
        {
            brain.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenBrain = false;
        }
        if (choosen4 && choosenBat)
        {
            bat.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenBat = false;
        }
        if (choosen4 && choosenMayonnaise)
        {
            mayonnaise.transform.position = new Vector2(place2.transform.position.x, place2.transform.position.y);
            choosenMayonnaise = false;
        }
        //3
        if (choosen3 && choosenCucumber)
        {
            cucumber.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenCucumber = false;
        }
        if (choosen3 && choosenTomato)
        {
            tomato.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenTomato = false;
        }
        if (choosen3 && choosenPickles)
        {
            pickles.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenPickles = false;
        }
        if (choosen3 && choosenEggplant)
        {
            eggplant.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenEggplant = false;
        }
        if (choosen3 && choosenMeat)
        {
            meat.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenMeat = false;
        }
        if (choosen3 && choosenMushroom)
        {
            mushroom.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenMushroom = false;
        }
        if (choosen3 && choosenLemon)
        {
            lemon.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenLemon = false;
        }
        if (choosen3 && choosenSalt)
        {
            salt.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenSalt = false;
        }
        if (choosen3 && choosenApple)
        {
            apple.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenApple = false;
        }
        if (choosen3 && choosenFish)
        {
            fish.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenFish = false;
        }
        if (choosen3 && choosenBrain)
        {
            brain.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenBrain = false;
        }
        if (choosen3 && choosenBat)
        {
            bat.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenBat = false;
        }
        if (choosen3 && choosenMayonnaise)
        {
            mayonnaise.transform.position = new Vector2(place3.transform.position.x, place3.transform.position.y);
            choosenMayonnaise = false;
        }
        //2
        if (choosen2 && choosenCucumber)
        {
            cucumber.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenCucumber = false;
        }
        if (choosen2 && choosenTomato)
        {
            tomato.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenTomato = false;
        }
        if (choosen2 && choosenPickles)
        {
            pickles.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenPickles = false;
        }
        if (choosen2 && choosenEggplant)
        {
            eggplant.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenEggplant = false;
        }
        if (choosen2 && choosenMeat)
        {
            meat.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenMeat = false;
        }
        if (choosen2 && choosenMushroom)
        {
            mushroom.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenMushroom = false;
        }
        if (choosen2 && choosenLemon)
        {
            lemon.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenLemon = false;
        }
        if (choosen2 && choosenSalt)
        {
            salt.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenSalt = false;
        }
        if (choosen2 && choosenApple)
        {
            apple.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenApple = false;
        }
        if (choosen2 && choosenFish)
        {
            fish.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenFish = false;
        }
        if (choosen2 && choosenBrain)
        {
            brain.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenBrain = false;
        }
        if (choosen2 && choosenBat)
        {
            bat.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenBat = false;
        }
        if (choosen2 && choosenMayonnaise)
        {
            mayonnaise.transform.position = new Vector2(place4.transform.position.x, place4.transform.position.y);
            choosenMayonnaise = false;
        }
        //1
        if (choosen1 && choosenCucumber)
        {
            cucumber.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenCucumber = false;
        }
        if (choosen1 && choosenTomato)
        {
            tomato.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenTomato = false;
        }
        if (choosen1 && choosenPickles)
        {
            pickles.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenPickles = false;
        }
        if (choosen1 && choosenEggplant)
        {
            eggplant.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenEggplant = false;
        }
        if (choosen1 && choosenMeat)
        {
            meat.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenMeat = false;
        }
        if (choosen1 && choosenMushroom)
        {
            mushroom.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenMushroom = false;
        }
        if (choosen1 && choosenLemon)
        {
            lemon.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenLemon = false;
        }
        if (choosen1 && choosenSalt)
        {
            salt.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenSalt = false;
        }
        if (choosen1 && choosenApple)
        {
            apple.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenApple = false;
        }
        if (choosen1 && choosenFish)
        {
            fish.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenFish = false;
        }
        if (choosen1 && choosenBrain)
        {
            brain.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenBrain = false;
        }
        if (choosen1 && choosenBat)
        {
            bat.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenBat = false;
        }
        if (choosen1 && choosenMayonnaise)
        {
            mayonnaise.transform.position = new Vector2(place5.transform.position.x, place5.transform.position.y);
            choosenMayonnaise = false;
        }
        //0
        if (choosen0 && choosenCucumber)
        {
            cucumber.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
        }
        if (choosen0 && choosenTomato)
        {
            tomato.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenTomato = false;
        }
        if (choosen0 && choosenPickles)
        {
            pickles.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenPickles = false;
        }
        if (choosen0 && choosenEggplant)
        {
            eggplant.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenEggplant = false;
        }
        if (choosen0 && choosenMeat)
        {
            meat.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenMeat = false;
        }
        if (choosen0 && choosenMushroom)
        {
            mushroom.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenMushroom = false;
        }
        if (choosen0 && choosenLemon)
        {
            lemon.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenLemon = false;
        }
        if (choosen0 && choosenSalt)
        {
            salt.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenSalt = false;
        }
        if (choosen0 && choosenApple)
        {
            apple.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenApple = false;
        }
        if (choosen0 && choosenFish)
        {
            fish.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenFish = false;
        }
        if (choosen0 && choosenBrain)
        {
            brain.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenBrain = false;
        }
        if (choosen0 && choosenBat)
        {
            bat.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenBat = false;
        }
        if (choosen0 && choosenMayonnaise)
        {
            mayonnaise.transform.position = new Vector2(place6.transform.position.x, place6.transform.position.y);
            choosenMayonnaise = false;
        }















    }
    public void Cucumber()
    {
        if (CanIChoose)
        {
            choosenCucumber = true;
            Debug.Log(choosenCucumber);
            choose -= 1;

        }
        
    }
    public void Tomato()
    {
        if (CanIChoose)
        {
            choosenTomato = true;
            Debug.Log(choosenTomato);
            choose -= 1;
        }
        
    }
    public void Pickles()
    {
        if (CanIChoose)
        {
            choosenPickles = true;
            Debug.Log(choosenPickles);
            choose -= 1;
        }
        
    }
    public void Eggplant()
    {
        if (CanIChoose)
        {
            choosenEggplant = true;
            Debug.Log(choosenEggplant);
            choose -= 1;
        }
        
    }
    public void Meat()
    {
        if (CanIChoose)
        {
            choosenMeat = true;
            Debug.Log(choosenMeat);
            choose -= 1;
        }
       
    }
    public void Mushroom()
    {
        if (CanIChoose)
        {
            choosenMushroom = true;
            Debug.Log(choosenMushroom);
            choose -= 1;
        }
       
    }
    public void Lemon()
    {
        if (CanIChoose)
        {
            choosenLemon = true;
            Debug.Log(choosenLemon);
            choose -= 1;
        }
        
    }
    public void Salt()
    {
        if (CanIChoose)
        {
            choosenSalt = true;
            Debug.Log(choosenSalt);
            choose -= 1;
        }
        
    }
    public void Apple()
    {
        if (CanIChoose)
        {
            choosenApple = true;
            Debug.Log(choosenApple);
            choose -= 1;
        }
        
    }
    public void Fish()
    {
        if (CanIChoose)
        {
            choosenFish = true;
            Debug.Log(choosenFish);
            choose -= 1;
        }
        
    }
    public void Brain()
    {
        if (CanIChoose)
        {
            choosenBrain = true;
            Debug.Log(choosenBrain);
            choose -= 1;
        }
        
    }
    public void Bat()
    {
        if (CanIChoose)
        {
            choosenBat = true;
            Debug.Log(choosenBat);
            choose -= 1;
        }
        
    }
    public void Mayonnaise()
    {
        if (CanIChoose)
        {
            choosenMayonnaise = true;
            choose -= 1;
        }
    }

































}
