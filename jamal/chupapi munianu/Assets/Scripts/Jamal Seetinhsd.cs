using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI

public class JamalSeetinhsd : MonoBehaviour
[SerializeField] private int health;
[SerializeField] private int maxHealth;
[SerializeField] private Slider healthBar;
{
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthBar.value = healthBar;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeD()
    {

    }

    [PunRPC]
    public void UpdateHealth(int value)
    {
        healthBar -= value;

        if(healthBar <= 0)
        {
            health = maxHealth;
            transform.GetComponent
        }
    }
}
