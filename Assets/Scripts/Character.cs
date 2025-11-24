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

    public int DamageHit { get; protected set; }

    protected Animator anim;
    protected Rigidbody2D rb;

    [SerializeField] UIHealthBar healthBar;

    public System.Action OnDeath;


    public void Tnti(int hp)
    {
        maxHealth = hp;
        Health = hp;
        healthBar = GetComponentInChildren<UIHealthBar>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} got {damage} Current HP : {this.Health}");

        if (healthBar != null)
        { 
            healthBar.UpdateHealthBar(Health, maxHealth);

        }

        IsDead();
    }

    public bool IsDead()
    {
        if (Health <= 0)
        {
            
            Debug.Log($"{this.name} is dead and destroyed");
            OnDeath?.Invoke();
            Destroy(this.gameObject);
            return true;
            
        }
        else return false;

        



    }

    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        healthBar = GetComponent<UIHealthBar>();

    }




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.UpdateHealthBar(Health, maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
