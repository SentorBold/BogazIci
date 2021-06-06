using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
 public void game()
    {
        SceneManager.LoadScene("3)Game");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
