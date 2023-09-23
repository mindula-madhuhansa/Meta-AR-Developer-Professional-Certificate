using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCreator : MonoBehaviour
{
    public int numberOfSpheres;
    public GameObject spherePrefab;

    void Start()
    {
        for (var i = 0; i < numberOfSpheres; i++)
        {
            CreateSphere();
        }
    }

    void CreateSphere()
    {
        GameObject newSphere = Instantiate(spherePrefab);
        newSphere.transform.position = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
        int randomColor = Random.Range(0, 3);
        Color sphereColor = Color.white;

        switch (randomColor)
        {
            case 0:
                sphereColor = Color.red;
                break;
            case 1:
                sphereColor = Color.green;
                break;
            case 2:
                sphereColor = Color.blue;
                break;
        }

        newSphere.GetComponent<Renderer>().material.color = sphereColor;
    }
}
