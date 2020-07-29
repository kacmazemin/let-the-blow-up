using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public InputMaster controls;

    public float speed = 5f;
    // Start is called before the first frame update
    private void Awake()
    {
        controls = new InputMaster();
        controls.Player.Movements.performed += context => Move(context.ReadValue<Vector2>());
    }
    
    private void OnEnable()
    {
        controls.Enable();
    }
    
    private void OnDisable()
    {
        controls.Disable();
    }

    void Move(Vector2 direction)
    {
        Vector2 m = new Vector2(direction.x, direction.y) * Time.deltaTime * speed;
        transform.Translate(direction, Space.World);
        Debug.Log(direction);
    }

}
