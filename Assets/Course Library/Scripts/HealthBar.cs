using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int playerHealth = 100, currentHealth, amount = -10;
    public GameObject[] animalPrefabs;
    public GameObject player;
    public event System.Action<float> onHealthPctChange = delegate{ };
    // Start is called before the first frame update
    private void OnEnable()
    {
        currentHealth = playerHealth;
    }
    private void OnTriggerEnter(Collider other)
    {
        currentHealth += amount;
        float currentHealthPct = (float)currentHealth / (float)playerHealth;
        onHealthPctChange(currentHealth);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
