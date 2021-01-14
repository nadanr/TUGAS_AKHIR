using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //harus pake

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] //cari sendiri
    private LayerMask layerMask; 
    [SerializeField]
    private Camera camera;
    [SerializeField]
    private Image interactionImage;

    FirstPersonAIO playerMovement;
    Transform player;
    public Transform PlayerCamera;
    public float range = 2f;
    private int flag = 0;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        playerMovement = player.GetComponent<FirstPersonAIO>();
    }

    private void Update()
    {
        CheckInteraction();

        if (Input.GetKeyDown(KeyCode.F))
        {
            Interaction();
        }

        else if (Input.GetKeyDown(KeyCode.R) && flag == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            playerMovement.enableCameraMovement = false;
            flag = 1;
        }

        else if(Input.GetKeyDown(KeyCode.R) && flag == 1)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            playerMovement.enableCameraMovement = true;
            flag = 0;
        }
    }

    private void CheckInteraction()
    {
        Ray ray = camera.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, range, layerMask))
        {
            interactionImage.gameObject.SetActive(true);
        }
        else interactionImage.gameObject.SetActive(false);
    }

    void Interaction()
    {
        RaycastHit hit;
        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.tag == "Door")
            {
                Door doorScript = hit.transform.GetComponent<Door>();
                doorScript.Pressed();
            }

            if (hit.transform.tag == "Lift")
            {
                Lift liftScript = hit.transform.GetComponent<Lift>();
                liftScript.Pressed();
            }

            else if(hit.transform.tag == "Photocopy")
            {
                Photocopy photocopyScript = hit.transform.GetComponent<Photocopy>();
                photocopyScript.ShowInfo();
            }

            else if (hit.transform.tag == "Restricted")
            {
                ResDoor resDoorScript = hit.transform.GetComponent<ResDoor>();
                resDoorScript.ShowInfo();
            }

            else if(hit.transform.tag == "Television")
            {
                Television televisionScript = hit.transform.GetComponent<Television>();
                televisionScript.ShowInfo();
            }

            else if (hit.transform.tag == "Proyektor")
            {
                Proyektor proyektorScript = hit.transform.GetComponent<Proyektor>();
                proyektorScript.ShowInfo();
            }

            else if (hit.transform.tag == "Book")
            {
                Books booksScript = hit.transform.GetComponent<Books>();
                booksScript.BookId();
            }
        }
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerMovement.enableCameraMovement = true;
        flag = 0;
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
