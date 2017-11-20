using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float movementSpeed = 10;
    Animator Anim;

    void Start()
    {
        Anim = GetComponent<Animator>();
    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0, 0, -vertical) * Time.deltaTime * movementSpeed;
        transform.Translate(movement);

        Vector3 rotation = new Vector3(-horizontal, 0, 0) * movementSpeed * Time.deltaTime;
        transform.Translate(rotation);

        Anim.SetFloat("CHorizontal", horizontal);
        Anim.SetFloat("CVertical", vertical);

    }
}
