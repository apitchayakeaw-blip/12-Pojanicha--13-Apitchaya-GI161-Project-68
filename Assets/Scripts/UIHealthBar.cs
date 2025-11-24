using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    [SerializeField] private Slider healthBar;

    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        healthBar.value = currentValue / maxValue;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
