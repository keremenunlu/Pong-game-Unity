using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int scoreToWin;

    // Update is called once per frame
    void Update()
    {
        if(this.scorePlayer1 >= this.scoreToWin || this.scorePlayer2 >= this.scoreToWin)
        {
            Debug.Log("Game Won");

            SceneManager.LoadScene("GameOver");
        }
    }
    private void FixedUpdate() // for updating UI.
    {
        TextMeshProUGUI uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<TextMeshProUGUI>();
        uiScorePlayer1.text = this.scorePlayer1.ToString();

        TextMeshProUGUI uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<TextMeshProUGUI>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }
    public void GoalPlayer1()
    {
        this.scorePlayer1++;
    }
    public void GoalPlayer2()
    {
        this.scorePlayer2++;
    }
}
