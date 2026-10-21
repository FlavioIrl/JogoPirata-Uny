using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D corpo;
    private SpriteRenderer sprite;
    public float velocidade = 1.35f;
    private bool olhandoEsquerda = false; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        corpo = GetComponent<Rigidbody2D>();
        sprite  = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        corpo.linearVelocity = new Vector2(horizontal * velocidade, corpo.linearVelocity.y);
        flip(horizontal);
    }

    private void flip(float horizontal)
    {

         
        if (horizontal < 0 && !olhandoEsquerda)
        {
            olhandoEsquerda = true;
            sprite.flipX = true;
        }
        else if (horizontal > 0 && olhandoEsquerda)
        {
            olhandoEsquerda = false;
            sprite.flipX = false;
        }
    }
}
