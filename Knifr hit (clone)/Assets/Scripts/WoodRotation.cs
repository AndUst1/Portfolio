using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodRotation : MonoBehaviour
{
    [SerializeField] float speed = 1.5f;
    void FixedUpdate()
    {
        transform.Rotate(0, 0, speed);
    }
}
