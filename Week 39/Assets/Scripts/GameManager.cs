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

    private void Start()
    {
        playerHealth = playerMaxHealth;
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    public void addScore(int amount)
    {
        score += amount;
        scoreText.SetText("Score: "+score);
    }

    public void damagePlayer(int amount)
    {
        playerHealth -= amount;
        if (playerHealth < 1)
        {
            //Game over
        }
    }
}
