using UnityEngine;
using System.Collections;

public class shrinkPlanet : MonoBehaviour
{

    public GameObject cube;
    public float growRate = -3f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.localScale += new Vector3(0.1F, .1f, .1f) * growRate * Time.deltaTime;
    }
}

