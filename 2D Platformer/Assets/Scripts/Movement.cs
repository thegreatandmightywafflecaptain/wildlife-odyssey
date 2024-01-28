using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    private void Awake(){
        body = GetComponent<Rigidbody2D>();

    }

    private void Update(){
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        if(Input.GetKey(KeyCode.Space)){
            body.velocity = new Vector2(body.velocity.x, speed);
        }

        if (horizontalInput > .01)
        {
            transform.localScale = new Vector2((float).6, (float).6);

        }else if(horizontalInput < -.01)
        {
            transform.localScale = new Vector2((float)-.6, (float).6);
        }

    }
}
