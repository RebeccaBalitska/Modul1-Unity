using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Transform target; // об'єкт, до якого прив'язуємо камеру
    public Vector3 offset = new Vector3(0f, 2f, -10f); // відстань між камерою та об'єктом
    public float rotationSpeed = 5f; // швидкість обертання

    void LateUpdate()
    {
        // переміщення камери за об'єктом
        transform.position = target.position + offset;

        // обертання камери навколо об'єкта
        if (Input.GetMouseButton(0))
        {
            float horizontal = Input.GetAxis("Mouse X") * rotationSpeed;
            target.Rotate(0, horizontal, 0);
        }
    }
}
