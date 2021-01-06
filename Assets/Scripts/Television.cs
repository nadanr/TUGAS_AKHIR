using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Television : MonoBehaviour
{
    public Image televisionInfoUI;

    public void ShowInfo()
    {
        televisionInfoUI.gameObject.SetActive(true);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            televisionInfoUI.gameObject.SetActive(false);
        }
    }

}
