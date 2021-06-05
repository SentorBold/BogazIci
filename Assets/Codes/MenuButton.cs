using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
 public void game()
    {
        SceneManager.LoadScene("2)FoodChoosing");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
