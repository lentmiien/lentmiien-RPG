using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;

    void Update()
    {
        Camera.main.transform.position = target.position;
    }
}
