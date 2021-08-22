using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSenstivity = 100f;
    public Transform Playerbody;
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        ControlFreak2.CFCursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = ControlFreak2.CF2Input.GetAxis("Mouse X") * mouseSenstivity * Time.deltaTime;
        float mouseY = ControlFreak2.CF2Input.GetAxis("Mouse Y") * mouseSenstivity * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotation, 90f, 0f);

        Playerbody.Rotate(Vector3.up * mouseX);

    }
}
