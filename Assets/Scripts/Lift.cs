using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    private bool opened = false;
    private Animator anim;

    public void Pressed()
    {
        anim = GetComponentInParent<Animator>();
        opened = !opened;

        anim.SetBool("Opened", opened);
    }
}
