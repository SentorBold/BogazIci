using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextGoBack : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene(2);
    }
    public void GoBack()
    {
        //i want to be a monkey
        SceneManager.LoadScene(0);
    }
}
