using UnityEngine;

public class PlayerBullet : Weaphon
{

    [SerializeField] private float speed;
    public void Move()
    {


        float x = speed * transform.right.x;
        float y = speed * transform.right.y;
        Vector2 newPosition = new Vector2(x, y);
        transform.position = newPosition;
    }

    public override void OnHitWih(Character character)
    {
        if (character is Enemy)
            character.TakeDamage(this.damage);
    }

  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 4.0f * GetShootDirection();
        
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
}
