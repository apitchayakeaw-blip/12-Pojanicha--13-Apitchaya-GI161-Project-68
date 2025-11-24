using UnityEngine;

public class Heal : Items
{
    public override void UseItem(Player player)
    {
        player.Heal(ItemsValue);
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
