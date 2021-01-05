using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField]
    private LayerMask layerMask;
    [SerializeField]
    private Camera camera;
    [SerializeField]
    private Image interactionImage;

    public Transform PlayerCamera;
    public float range = 2f;

    private void Update()
    {
        CheckInteraction();

        if (Input.GetKeyDown(KeyCode.F))
        {
            Interaction();
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
        }
    }
}
