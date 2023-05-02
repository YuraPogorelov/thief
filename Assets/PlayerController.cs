using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _movemenSpeed = 10f;

    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mov = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * _movemenSpeed;
        mov = Vector3.ClampMagnitude(mov, _movemenSpeed);

        if (mov != Vector3.zero)
        {
            _rb.MovePosition(transform.position + mov * Time.deltaTime);
            _rb.MoveRotation(Quaternion.LookRotation(mov));
        }
    }
}
