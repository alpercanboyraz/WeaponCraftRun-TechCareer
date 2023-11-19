using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public enum PlayerState { Idle, Moving, Finish }
    public static PlayerState playerState;

    [SerializeField] private float _forwardMovementSpeed = 1f;
    [SerializeField] private float _horizontalMovementSpeed = 1f;

    private Vector3 m_movementVector;
    private Vector2 m_mousePreviousPosition;
    private float currentMovementSpeed;

    public float speed = 10f;
    public float moveSpeed = 5f;

    public void Init()
    {
        EventManager.OnStartMovement += OnStartMovement;
    }

    private void OnStartMovement()
    {
        playerState = PlayerState.Moving;
    }


    private void Update()
    {
        if (playerState == PlayerState.Moving)
        {
            Move();
            CalculateMovement();
        }
        
        if (playerState == PlayerState.Finish)
        {
            Move();
            EventManager.Instance.SetFinishGame();
            SceneController.Instance.moveBullet._moveSpeed = 5;
        }
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void CalculateMovement()
    {
        MovementInput();

        m_movementVector.Normalize();

        Vector3 newPosition = new Vector3();
        //Move forward
        newPosition.z += currentMovementSpeed * Time.deltaTime;
        //Move horizontal
        newPosition.x += m_movementVector.x * _horizontalMovementSpeed * Time.deltaTime;
        transform.position += newPosition;
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -0.8f, 0.8f),
            transform.position.y,
            transform.position.z);
    }
   
    private void MovementInput()
    {
        if (!Input.anyKey)
        {
            m_movementVector = Vector3.zero;
            return;
        }

        if (Input.GetMouseButton(0))
        {
            float mouseDelta = 0;

            mouseDelta = Input.mousePosition.x - m_mousePreviousPosition.x;
            m_mousePreviousPosition = Input.mousePosition;

            m_movementVector = Vector3.right * mouseDelta;

            m_movementVector.Normalize();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            moveSpeed = 0;
            playerState = PlayerState.Finish;
        }
    }

}
