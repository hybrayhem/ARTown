using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAnimator : MonoBehaviour
{
    public float speed = 1f;
    void Start()
    {
        Debug.Log("PlaneAnimator");
    }

    void Update()
    {
        Debug.Log("PlaneAnimator Speed: " + speed);
        transform.Rotate(0f, 0f, speed * Time.fixedDeltaTime, Space.Self);
    }
}
