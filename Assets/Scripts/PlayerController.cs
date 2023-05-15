using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    public CharacterController characterController;
    
 
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovementInput();
    }

    void HandleMovementInput()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        //Vector3 _movement = new Vector3(_horizontal, 0, _vertical);
        //transform.Translate(_movement * movementSpeed * Time.deltaTime, Space.World);

        Vector3 _move = transform.right * _horizontal + transform.forward * _vertical;
        characterController.Move(_move * movementSpeed * Time.deltaTime);
    }

   
}
