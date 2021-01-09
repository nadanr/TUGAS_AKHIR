using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyektor : MonoBehaviour
{
    public GameObject layarLCD;

    public void ShowInfo()
    {
        layarLCD.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            layarLCD.gameObject.SetActive(false);
        }
    }
}
