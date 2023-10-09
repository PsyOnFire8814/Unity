using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D player;
    private Vector2 moveVector;
    private float moveSpeed = 15.5f;
    
    void Awake()
    {
        player = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        player.MovePosition(player.position + moveVector * moveSpeed * Time.deltaTime);


    }
}
