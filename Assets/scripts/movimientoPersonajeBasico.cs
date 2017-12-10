using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPersonajeBasico : MonoBehaviour {
    public float speed = 6f;
    Vector2 movement;
    Rigidbody2D playerRigidBody;
    
    void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }
   
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        
        Move(h, v);
    }
    void Move(float h,float v)
    {
        
        movement.Set(h, v);
        movement = movement * speed * Time.deltaTime;
        playerRigidBody.MovePosition( playerRigidBody.position + movement);
    }
}
