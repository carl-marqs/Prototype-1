using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public int speed;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }
}
