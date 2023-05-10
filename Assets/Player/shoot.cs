using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public BoxCollider boxCollider;
    public string tagToCheck = "Football";
    public Transform mainCamera;
    
    public AudioSource audioSource;
    public float audioPlayTime = 5f;
    
    
    public float kickAmountHard;
    public float kickAmountMedium;
    public float kickAmountSoft;
    public float kickHardAngle;
    public float kickMediumAngle;
    public float kickSoftAngle;

    private int kicks;
    public int Kicks => kicks;
    
    public TextMeshProUGUI kickText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Kicks"))
        {
            int score = PlayerPrefs.GetInt("Kicks");
            kicks = score;
        }
        else
        {
            kicks = 0;
        }

        kickText.text = "Total kicks: " + kicks;

    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            kick(kickAmountHard, kickHardAngle);
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            kick(kickAmountMedium, kickMediumAngle);
        }
        
        if (Input.GetKeyDown(KeyCode.T))
        {
           kick(kickAmountSoft, kickSoftAngle);
        }
        
    }

    void kick(float kickAmount, float angle)
    {
        Collider[] colliders = Physics.OverlapBox(boxCollider.bounds.center, boxCollider.bounds.extents);

        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag(tagToCheck))
            {
                audioSource.time = audioPlayTime;
                audioSource.Play();
                kicks += 1;
                kickText.text = "Total kicks: " + kicks;
                Rigidbody component = collider.gameObject.GetComponent<Rigidbody>();

                Vector3 cameraDirection = mainCamera.transform.forward;
                Vector3 forceDirection = new Vector3(cameraDirection.x, Mathf.Sin(Mathf.Deg2Rad * angle), cameraDirection.z).normalized;
                component.AddForce(forceDirection * kickAmount);
            }
        }
    }
}