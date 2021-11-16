using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("You Hit The Wall!");
        GetComponent<MeshRenderer>().material.color = Color.magenta;
    }
}
