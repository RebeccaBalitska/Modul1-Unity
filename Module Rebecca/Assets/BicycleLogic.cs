using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleLogic : MonoBehaviour
{
    public float speed = 5f; // швидкість руху
    public float rotationSpeed = 50f; // швидкість повороту

    void Update()
    {
        // рух вперед
        transform.position += transform.forward * speed * Time.deltaTime;

        // поворот вправо
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        // поворот вліво
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        // поворот вгору
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
        }

        // поворот вниз
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left, -rotationSpeed * Time.deltaTime);
        }
    }
}
