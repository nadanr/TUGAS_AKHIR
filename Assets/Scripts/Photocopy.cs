using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Photocopy : MonoBehaviour
{
    public Image infoUI;

    public void ShowInfo()
    {
       infoUI.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            infoUI.gameObject.SetActive(false);
        }
    }

}
