using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    [SerializeField] private Transform pivot;
    [SerializeField] private float range;
    [SerializeField] private float speed;

    private void OnEnable()
    {
        Vector3 targetPosition = pivot.transform.position;
        transform.position = new Vector3(targetPosition.x + range, targetPosition.y,
            targetPosition.z);
    }

    private void Update()
    {
        transform.RotateAround(pivot.position, transform.up, speed*Time.deltaTime);
    }

    private void OnValidate()
    {
        Vector3 targetPosition = pivot.transform.position;
        transform.position = new Vector3(targetPosition.x + range, targetPosition.y,
            targetPosition.z);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pivot.position, range);
    }
}
