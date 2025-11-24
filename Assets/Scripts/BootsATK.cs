using UnityEngine;

public class BootsATK : Items
{
    public override void UseItem(Player player)
    {
        player.IncreasedATK(ItemsValue);
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
