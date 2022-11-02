using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    void OnMouseDown()
    {
        Time.timeScale = 1;
        Application.LoadLevel("Main");
    }
}
