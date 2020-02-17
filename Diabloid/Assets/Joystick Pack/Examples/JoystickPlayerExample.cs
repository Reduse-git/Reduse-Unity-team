using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void FixedUpdate()
    {
        /*Vector3 direction = Vector3.up * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed, ForceMode2D.Force);*/
        Vector3 InputVector = Vector3.up * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;

        this.gameObject.transform.position += InputVector * speed * Time.deltaTime;
    }
}