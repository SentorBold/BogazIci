using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    public Texture2D knifemouse;
    public Texture2D realmouse;
    public bool knife;

    public Sprite KesilmisDomates;
    public Sprite KesilmisSalatalik;
    public Sprite KesilmisYarasa;
    public Sprite KesilmisTuz;
    public Sprite KesilmisTursu;
    public Sprite KesilmisBeyin;
    public Sprite KesilmisMantar;
    public Sprite KesilmisEt;
    public Sprite KesilmisPatlican;
    public Sprite KesilmisLimon;
    public Sprite KesilmisBalik;
    public Sprite KesilmisElma;
    public Sprite KesilmisYumurta;
    public Sprite KesilmisEkmek;
    public Sprite KesilmisBiber;
    public Sprite KesilmisCheddar;
    public Sprite KesilmisMayonez;
    public Sprite KesilmisPulBiber;
    public Sprite KesilmisBarbekuSos;

    public SpriteRenderer Domates;
    public SpriteRenderer Salatalik;
    public SpriteRenderer Yarasa;
    public SpriteRenderer Tuz;
    public SpriteRenderer Tursu;
    public SpriteRenderer Beyin;
    public SpriteRenderer Mantar;
    public SpriteRenderer Et;
    public SpriteRenderer Patlican;
    public SpriteRenderer Limon;
    public SpriteRenderer Balik;
    public SpriteRenderer Elma;
    public SpriteRenderer Yumurta;
    public SpriteRenderer Ekmek;
    public SpriteRenderer Biber;
    public SpriteRenderer Cheddar;
    public SpriteRenderer Mayonez;
    public SpriteRenderer PulBiber;
    public SpriteRenderer BarbekuSos;
    void Start()

    {
  
    }
    
    // Update is called once per frame
    void Update()
    {     
     
        if (Input.GetKeyDown(KeyCode.K))    
        {
            knife = true;
        }
        if (knife == true)
        {

            Cursor.SetCursor(knifemouse, Vector2.zero, CursorMode.ForceSoftware);
            if (Input.GetButtonDown("Fire2"))
            {
                    //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                //RaycastHit2D hit;

                    if (hit.collider != null)
                    {
                        Debug.Log(hit.transform.gameObject.name);
                    if (hit.transform.gameObject.tag.Equals("Domates"))
                    {
                        Domates.sprite = KesilmisDomates;
                        
                    }
                   else if (hit.transform.gameObject.tag.Equals("Salatalik"))
                    {
                        Salatalik.sprite = KesilmisSalatalik;
                       
                    }
                    else if(hit.transform.gameObject.tag.Equals("Yarasa"))
                    {
                        Yarasa.sprite = KesilmisYarasa;
                        
                    }
                    else if (hit.transform.gameObject.tag.Equals("Tuz"))
                    {
                        Tuz.sprite = KesilmisTuz;
                     
                    }
                    else if (hit.transform.gameObject.tag.Equals("Tursu"))
                    {
                        Tursu.sprite = KesilmisTursu;
                       
                    }
                    else if (hit.transform.gameObject.tag.Equals("Beyin"))
                    {
                        Beyin.sprite = KesilmisBeyin;
                        
                    }
                    else if (hit.transform.gameObject.tag.Equals("Mantar"))
                    {
                        Mantar.sprite = KesilmisMantar;
                        
                    }
                    else if (hit.transform.gameObject.tag.Equals("Et"))
                    {
                         Et.sprite = KesilmisEt;
                        
                    }
                    else if (hit.transform.gameObject.tag.Equals("Patlican"))
                    {
                        Patlican.sprite = KesilmisPatlican;
                       
                    }
                    else if (hit.transform.gameObject.tag.Equals("Limon"))
                    {
                        Limon.sprite = KesilmisLimon;
                       
                    }
                    else if (hit.transform.gameObject.tag.Equals("Balik"))
                    {
                        Balik.sprite = KesilmisBalik;
                       
                    }
                    else if (hit.transform.gameObject.tag.Equals("Elma"))
                    {
                        Elma.sprite = KesilmisElma;
                     
                    }
                    else if (hit.transform.gameObject.tag.Equals("Yumurta"))
                    {
                        Yumurta.sprite = KesilmisYumurta;
                      
                    }
                    else if (hit.transform.gameObject.tag.Equals("Ekmek"))
                    {
                        Ekmek.sprite = KesilmisEkmek;
                        
                    }
                    else if (hit.transform.gameObject.tag.Equals("Biber"))
                    {
                        Biber.sprite = KesilmisBiber;
                        
                    }
                    else if (hit.transform.gameObject.tag.Equals("Cheddar"))
                    {
                        Cheddar.sprite = KesilmisCheddar;
                    
                    }
                    else if (hit.transform.gameObject.tag.Equals("Mayonez"))
                    {
                        Mayonez.sprite = KesilmisMayonez;
                        
                    }
                    else if (hit.transform.gameObject.tag.Equals("Pul biber"))
                    {
                        Yarasa.sprite = KesilmisYarasa;
                        
                    }
                    else if (hit.transform.gameObject.tag.Equals("Barbeku sos"))
                    {
                        BarbekuSos.sprite = KesilmisBarbekuSos;
                       
                    }
                }
                   
                
            }
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            knife = false;
        }
        if (knife == false)
        {
            Cursor.SetCursor(realmouse, Vector2.zero, CursorMode.ForceSoftware);
        }

    }
}
