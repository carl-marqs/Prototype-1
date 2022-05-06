using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed = 2000;

    void Update()
    {
        transform.Rotate(speed * Time.deltaTime * Vector3.forward);
    }
}
