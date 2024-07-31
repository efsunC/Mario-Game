using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text gameOverText;

    void Start()
    {
        gameOverPanel.SetActive(false); 
    }

    void GameOver()
    {
        Time.timeScale = 0f; 
        gameOverPanel.SetActive(true); 
        gameOverText.text = "Game Over"; 
    }
}
