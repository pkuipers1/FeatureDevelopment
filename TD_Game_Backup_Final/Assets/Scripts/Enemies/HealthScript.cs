using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    // EnemyClassScript enemy = new EnemyClassScript(100, 1.5f);

    [SerializeField] public float maxHealth;
    [SerializeField] public float currentHealth;

    public int amountToAdd;
    
    public CurrencyScript currencyScript;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        currencyScript = GameObject.Find("CoinAmount").GetComponent<CurrencyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            currencyScript.AddCoins(amountToAdd);
            Destroy(gameObject);
        }
    }

}
