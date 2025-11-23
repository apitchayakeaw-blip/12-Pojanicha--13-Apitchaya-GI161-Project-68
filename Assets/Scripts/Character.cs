using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private float maxHealth;
    private float health;
    public float Health
    {
        get => health;
        set => health = (value<0) ? 0:value;
    }

    protected Animator anim;
    protected Rigidbody2D rb;


    public abstract void Shoot();

    public void Tnti(int hp)
    {
        maxHealth = hp;
        Health = hp;

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log($"{this.name} is dead and destroyed");
            return true;
        }
        else return false;
    }

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
