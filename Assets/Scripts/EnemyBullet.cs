using UnityEngine;

public class EnemyBullet : Weaphon
{

    public float bulletLife = 10f;
    public float rotations = 10f;
    public float speed = 15f;

    private Vector2 spawnPoint;
    private float timer = 0f;
    

    private Vector2 Movement(float timer)
    {

        float x = timer * speed * transform.right.x;
        float y = timer * speed * transform.right.y;
        return new Vector2(x + spawnPoint.x, y + spawnPoint.y);

    }

    public override void OnHitWih(Character character)
    {
        if (character is Player)
            character.TakeDamage(this.damage);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPoint = new Vector2(transform.position.x, transform.position.y);
        damage = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > bulletLife) Destroy(this.gameObject);
        timer += Time.deltaTime;
        transform.position = Movement(timer);

    }
}
