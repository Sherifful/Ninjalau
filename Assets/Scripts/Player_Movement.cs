using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody2D body;
    private bool isjumping = false;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    public void Update()
    { 
        isjumping = Input.GetButtonDown("NinjaJump");
        if (isjumping)
            body.velocity = new Vector2(1, 1);
    }
}

