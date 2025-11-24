using UnityEngine;

public abstract class Items : MonoBehaviour
{
    [field: SerializeField] protected int ItemsValue { get; set; }

    public abstract void UseItem(Player player);

    public void Pickup(Player player)
    {
        UseItem(player);
        Destroy(this.gameObject);

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
