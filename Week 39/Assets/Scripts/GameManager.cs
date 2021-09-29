using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int playerMaxHealth = 3;
    int playerHealth = 3;
    int score = 0;
    TextMeshProUGUI scoreText;
    TextMeshProUGUI healthText;
    GameObject player;
    GameObject gameOver;

    private void Start()
    {
        playerHealth = playerMaxHealth;
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        healthText = GameObject.Find("HealthText").GetComponent<TextMeshProUGUI>();
        healthText.SetText("Health: " + playerHealth);
        player = GameObject.Find("Player");
        gameOver = GameObject.Find("GameOverGroup");
        gameOver.SetActive(false);
    }

    public void addScore(int amount)
    {
        score += amount;
        scoreText.SetText("Score: "+score);
    }

    public void damagePlayer(int amount)
    {
        playerHealth -= amount;
        healthText.SetText("Health: "+playerHealth);
        if (playerHealth < 1)
        {
            Destroy(player);
            gameOver.SetActive(true);
        }
    }
}
