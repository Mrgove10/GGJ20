using UnityEngine;

public class Main_Manager : MonoBehaviour
{
    public int health = 100;
    public int score;
    public UI UIManager;

    private void Update()
    {
        if (health <= 0)
        {
            Debug.Log("gameover");
            UIManager.Lost();
        }

        UIManager.ScoreText.text = score.ToString();
    }

    public void finishedGame()
    {
        UIManager.Victory();
    }
}