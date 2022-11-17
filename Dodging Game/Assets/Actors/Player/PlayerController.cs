using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float jumpForce;
    public float ySpeed;
    public float originalStepOffset;

    private CharacterController cc;

    public Vector3 moveDir;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        originalStepOffset = cc.stepOffset;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        moveDir = new Vector3(horizontal, 0, vertical).normalized;
        float magnitude = Mathf.Clamp01(moveDir.magnitude) * speed;

        ySpeed += Physics.gravity.y * Time.deltaTime;

        if (cc.isGrounded)
        {
            cc.stepOffset = originalStepOffset;
            ySpeed = -0.5f;

            if (Input.GetButtonDown("Jump"))
            {
                ySpeed = jumpForce;
            }
        }
        else cc.stepOffset = 0;

        Vector3 velocity = moveDir * magnitude;
        velocity.y = ySpeed;

        cc.Move(velocity * Time.deltaTime);

        if (moveDir != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDir, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
