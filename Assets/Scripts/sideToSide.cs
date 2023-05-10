using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideToSide : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float movementSpeed = 2f;
    public Vector3 target;
    public Vector3 startPointPos;
    
    
    private void Start()
    {
        target = endPoint.position;
        startPointPos = startPoint.position;
    }


    void Update()
    {
        float distanceToMove = movementSpeed * Time.deltaTime;
        
        transform.position = Vector3.MoveTowards(transform.position, target, distanceToMove);

        if (transform.position == target)
        {
            (startPointPos, target) = (target, startPointPos);
        }
    }
}
