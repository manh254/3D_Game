using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void UpdateHealthBar(float maxHealth, float currentHealth)
    {
        healthBar.fillAmount = currentHealth/maxHealth;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
