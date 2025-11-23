using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private Vector2 velocity;
    public Transform[] MovePoint;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Tnti(200);
        DamageHit = 20;
        velocity = new Vector2(-1.0f, 0.0f);
    }

    public void Behavior()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (velocity.x < 0 && rb.position.x <= MovePoint[0].position.x)
        {
            Flip();
        }
        if (velocity.x > 0 && rb.position.x >= MovePoint[1].position.x)
        {
            Flip();
        }

    }

    public void Flip()
    {
        velocity.x *= -1;

        Vector3 theScale = transform.localScale;
        theScale.x *= 1;
        transform.localScale = theScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Behavior();
    }
}
