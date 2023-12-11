using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private bool isRotating = false;
    private Quaternion originalRotation;
    private Quaternion targetRotation;

    private AudioSource audioSource;

    void Start()
    {
        originalRotation = transform.rotation;
        targetRotation = originalRotation;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isRotating = !isRotating;
            targetRotation = isRotating ? Quaternion.Euler(90, 0, 0) : originalRotation;
            if (audioSource == null)
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.Play();

            }
            else
            {
                audioSource.Play();
            }
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
    }
}
