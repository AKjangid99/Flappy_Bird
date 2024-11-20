using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;
    public GameObject GameOverScreen;
    


    [ContextMenu("Increase Score")]
     public void AddScore (int ScoreToAdd) 
    {
        PlayerScore = PlayerScore +ScoreToAdd;
        ScoreText.text = PlayerScore.ToString();
    }

    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void GameOver ()
    {
        GameOverScreen.SetActive(true);
    }
  


}
