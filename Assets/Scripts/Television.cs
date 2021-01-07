using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Television : MonoBehaviour
{
    public GameObject layarTV;

    public void ShowInfo()
    {
        layarTV.gameObject.SetActive(true);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            layarTV.gameObject.SetActive(false);
        }
    }

}
