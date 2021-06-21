using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit a wall!");
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
