using UnityEngine;

public abstract class Weaphon : MonoBehaviour
{
    public int damage;

    public IShootable Shooter;
   
    public abstract void OnHitWih(Character character);

    public void InitWeapon(int newDamage, IShootable newShooter)
    {
        damage = newDamage;
        Shooter = newShooter;
    }

    public int GetShootDirection()
    {
        float value = Shooter.ShootPoint.position.x - Shooter.ShootPoint.parent.position.x;

        if (value > 0)
            return 1;
        else return 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Character character = other.GetComponent<Character>();
        if (character != null)
        {
            OnHitWih(character);
            Destroy(this.gameObject, 5f);
        }
    }
}
