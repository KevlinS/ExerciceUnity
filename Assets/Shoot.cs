using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ProjectilPrefab;
    public GameObject Spawner;
    public float Power;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            GameObject g = Instantiate(ProjectilPrefab,Spawner.GetComponent<Transform>().position,Quaternion.identity);
            g.tag = "Projectile";
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            g.GetComponent<Rigidbody>().AddForce(fwd * Power);
            Destroy(g,5);
        }
    }
}
