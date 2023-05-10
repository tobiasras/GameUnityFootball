using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballreset : MonoBehaviour
{
    public Transform ball;
    public BoxCollider boxCollider;

    public string ballTag = "Football";

    private Vector3 originalPosBall;

    private CharacterController characterController;

    private void Start()
    {
        originalPosBall = ball.transform.position;
    }

    private void Update()
    {
        Collider[] colliders = Physics.OverlapBox(boxCollider.bounds.center, boxCollider.bounds.extents);

        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag(ballTag))
            {
                ball.transform.position = originalPosBall;
            }
        }
    }
}
