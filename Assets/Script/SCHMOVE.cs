using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCHMOVE : MonoBehaviour
{
    public float Movesped;
   // public Rigidbody theRb;
    public float jumpy;
    public CharacterController controller;


    private Vector3 moveDirection;
    public float gravscale;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        //moveDirection = new Vector3(Input.GetAxis("Vertical") * Movesped, moveDirection.y, Input.GetAxis("Horizontal") * Movesped);
        moveDirection = (transform.forward * Input.GetAxis("Vertical") * 0) + (transform.right * Input.GetAxis("Horizontal") * -1);

        moveDirection = moveDirection.normalized * Movesped;

        



        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravscale * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);
    }
}
