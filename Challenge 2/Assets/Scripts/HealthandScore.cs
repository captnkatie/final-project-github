using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthandScore : MonoBehaviour
{
    public Text healthText;
    public Text winText;
    public Text coinText;
    public int health;
    public int coin;
    public Vector3 initialPosition;
    public GameObject player;
   // public AudioSource WinSound;
    public PlaySound playsound;
    
    void Start()
    {
        coin = 0;
        health = 3;
        SetHealthText();
        SetCoinText();
        winText.text = "";
        initialPosition = transform.position;
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            health = health - 1;
            SetHealthText();
            SetCoinText();
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            coin = coin + 1;
            SetCoinText();
            playsound.CoinPickUpPlay();
        }

    }

    void SetHealthText()
    {
        healthText.text = "Lives: " + health.ToString();
        if (health <= 0)
        {
            winText.text = "You Lose";
            player.gameObject.SetActive(false);
        }

    }

    void SetCoinText()
    {
        coinText.text = "Coins: " + coin.ToString();
        
        if (coin == 4)
        {
            SetHealth();
            SetHealthText();
            transform.position = new Vector3(28, -3, 0);
            

        }
        if (coin == 8)
        {
            winText.text = "You Win!";
            player.gameObject.SetActive(false);
            playsound.WinSoundPlay();
        }
    }
    void SetHealth()
    {
        health = 3;
    }
}
