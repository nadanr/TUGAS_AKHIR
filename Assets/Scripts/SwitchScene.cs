using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    Scene currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NextSceneCollider")
        {
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }
    }
}
