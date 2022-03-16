using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingObstacle : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 200f;

    [SerializeField]
    private float minZRotation = -0.7f, maxZRotation = 0.7f;

    private Rigidbody2D myBody;

    private bool rotateLeft;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();

        if (Random.Range(0, 2) > 0)
            rotateLeft = true;

    }

    private void Update()
    {

        HandleRotationWithRigidBody();

    }

    void HandleRotationWithRigidBody()
    {

        if (transform.rotation.z > maxZRotation)
            rotateLeft = true;

        if (transform.rotation.z < minZRotation)
            rotateLeft = false;

        if (rotateLeft)
            myBody.angularVelocity = -rotateSpeed;
        else
            myBody.angularVelocity = rotateSpeed;

    }

} // class
