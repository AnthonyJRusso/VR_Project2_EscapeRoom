using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightup : MonoBehaviour
{
    public void LightUp()
    {
        GetComponent<MeshRenderer>().material.color = new Color(0f, 1f, 1f);
    }
}
