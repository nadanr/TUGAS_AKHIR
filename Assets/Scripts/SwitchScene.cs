using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    Scene currentScene;
    public GameObject infoUI;
    FirstPersonAIO playerMovement;
    Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        playerMovement = player.GetComponent<FirstPersonAIO>();
        currentScene = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NextSceneCollider")
        {
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }

        if (other.gameObject.tag == "LiftSwitch")
        {
            infoUI.gameObject.SetActive(true);
            playerMovement.enableCameraMovement = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "LiftSwitch")
        {
            infoUI.gameObject.SetActive(false);
            playerMovement.enableCameraMovement = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void ChangeScene(int id)
    {
        StartCoroutine(OpenScene(id));
    }

     private IEnumerator OpenScene(int id)
    {
        if (id < 0)
        {
            yield break;
        }
        
        SceneManager.LoadScene(id);
    }
}
