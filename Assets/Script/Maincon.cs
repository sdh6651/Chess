using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maincon : MonoBehaviour {

    public void Startbut()
    {
        SceneManager.LoadScene(1);

    }
    public void Exittbut()
    {
        Application.Quit();
    }
}
