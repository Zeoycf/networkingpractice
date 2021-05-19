using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseShowData : MonoBehaviour
{
    private void OnMouseEnter()
    {
        this.gameObject.transform.localScale += new Vector3(.1f,.1f,.1f);
    }
    private void OnMouseExit()
    {
        this.gameObject.transform.localScale -= new Vector3(.1f, .1f, .1f);
    }
}
