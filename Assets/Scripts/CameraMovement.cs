using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 5f;
    private float X;
    private float Y;
 
    void Update()
    {
        // Right
        if (Input.GetKey(KeyCode.D)) {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        // Left
        if (Input.GetKey(KeyCode.A)) {
            transform.position += -transform.right * Time.deltaTime * speed;
        }
        // Up
        if (Input.GetKey(KeyCode.W)) {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        // Down
        if (Input.GetKey(KeyCode.S)) {
            transform.position += -transform.forward * Time.deltaTime * speed;
        }

        // Mouse drag rotation
        if(Input.GetMouseButton(0)) {
            transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y") * speed, Input.GetAxis("Mouse X") * speed, 0));
            X = transform.rotation.eulerAngles.x;
            Y = transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(X, Y, 0);
         }
    }
}
