using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject menu;

    void OnMouseDown()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            menu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            menu.SetActive(false);
        }
    }
}
