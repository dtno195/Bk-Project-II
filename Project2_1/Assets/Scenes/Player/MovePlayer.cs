using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    private float speed = 1f;
    private float jumpSpeed = 8f;
    private float lucHapDan = 20f;
    private Vector3 huongDiChuyen = Vector3.zero;

    private bool grounded = false;//co tren mat day ha k
    void Start()
    {
    }
    void FixedUpdate()
    {
        CharacterController _controller = GetComponent<CharacterController>();
        if (grounded)
        {
            huongDiChuyen = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed);

            if (Input.GetButton("Jump"))
            {
                huongDiChuyen.y = jumpSpeed;
            }
        }
		else{
			huongDiChuyen.y -=lucHapDan*Time.deltaTime;
			_controller.Move(huongDiChuyen*Time.deltaTime);
		}


    }
    // Update is called once per frame
}
