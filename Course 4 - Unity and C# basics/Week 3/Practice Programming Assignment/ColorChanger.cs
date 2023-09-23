using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GameObject sphere = collision.collider.gameObject;
        if (sphere.CompareTag("Sphere"))
        {
            Color sphereColor = sphere.GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.color = sphereColor;
        }
    }
}
