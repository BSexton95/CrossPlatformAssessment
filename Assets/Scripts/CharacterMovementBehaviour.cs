using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementBehaviour : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Camera _camera;
    private Vector2 _moveDirection;

    public Vector2 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }

    // Start is called before the first frame update
    void Awake()
    {
        //Initializes the game objects rigidbody
        _rigidbody = GetComponent<Rigidbody>();
        //Initializes camera to be the first enabled camera component found
        _camera = Camera.main;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //_moveDirection = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        //_rigidbody.MovePosition(transform.position + MoveDirection * 50 * Time.fixedDeltaTime);
        //_rigidbody.AddForce(MoveDirection * 50);
        //_rigidbody. = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")).normalized;
        //Input.
        //A ray cast from the camera using the mouse position
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        //A point the line has hit
        RaycastHit hitInfo;

        //If the ray hit an object..
        if (Physics.Raycast(ray, out hitInfo))
        {
            //...find the direction to move in and set the velocity
            Vector3 direction = (hitInfo.point - transform.position).normalized;
            direction = new Vector3(direction.x, 0, direction.z);
            _rigidbody.velocity = direction * 150 * Time.fixedDeltaTime;
        }

        //RaycastHit hitInfo;

        //if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 10))
        //{
        //    if (hitInfo)
        //    //do something
        //}
    }
}
