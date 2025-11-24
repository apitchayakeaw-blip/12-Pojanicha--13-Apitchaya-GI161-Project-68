using UnityEngine;

public class Player : Character, IShootable
{

  

    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform ShootPoint { get; set; }
    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }

    public int Damagehit = 20;

  

    void Start()
    {
        base.Tnti(100);
        ReloadTime = 0.2f;
        WaitTime = 0.0f;
      


    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            Debug.Log($"{this.name} Hit with {enemy.name} Current HP : {Health}");
            OnHitWith(enemy);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       Items item = other.GetComponent<Items>();
        if (item)
        {
          
            item.Pickup(this);
        }
    }

    public void Heal (int value)
    {
        Health += value;
        Debug.Log($"Player got 20HP Current HP : {Health}");
    }

    public void IncreasedATK(int value)
    {

        Damagehit += value;
        Debug.Log($"Player got BootsATK Current ATK : {value}");


    }


    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
    }



   


    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && WaitTime >= ReloadTime)
        {
            var bullet = Instantiate(Bullet, ShootPoint.position, Quaternion.identity);
            PlayerBullet playerBullet = bullet.GetComponent <PlayerBullet>();
            if (playerBullet != null)
                playerBullet.InitWeapon(20, this);

            WaitTime = 0.0f;
        }
    }
}
