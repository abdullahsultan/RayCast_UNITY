using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Camera cam;
    public Transform endpoint;
    LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ControlFreak2.CF2Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 1000))
        {
            lr.SetPosition(0, endpoint.position);
            lr.SetPosition(1, hit.point);
            Debug.Log(hit.transform.name);

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * 500);
            }
        }
    }
}
