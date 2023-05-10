using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public Transform player;
    public Transform ball;
    public BoxCollider boxCollider;

    public string playerTag = "Player";
    public string ballTag = "Football";

    private Vector3 originalPosPlayer;
    private Vector3 originalPosBall;

    private CharacterController characterController;

    private void Start()
    {
        originalPosPlayer = player.transform.position;
        originalPosBall = ball.transform.position;

        characterController = player.GetComponent<CharacterController>();
    }

    private void Update()
    {
        Collider[] colliders = Physics.OverlapBox(boxCollider.bounds.center, boxCollider.bounds.extents);

        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag(playerTag))
            {
                characterController.enabled = false;
                player.transform.position = originalPosPlayer;
                characterController.enabled = true;
            }

            if (collider.CompareTag(ballTag))
            {
                ball.transform.position = originalPosBall;
            }
        }
    }
}