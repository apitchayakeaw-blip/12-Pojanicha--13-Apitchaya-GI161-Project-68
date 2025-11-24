using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    private Character target;


    public void SetTarget(Character character)
    { 
        target = character;
        target.OnDeath += HideHealthBar;



    }


    public void HideHealthBar()
    {
        Destroy(gameObject);
    }


    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        healthBar.value = currentValue / maxValue;

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
