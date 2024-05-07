
using TMPro;
using UnityEngine;


public class GameDesign : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public BirdController birdController;
    

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        gameOver.SetActive(false);
        playButton.SetActive(false);

        Time.timeScale = 1f;
        birdController.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
       

    }

    public void Pause()
    {
        Time.timeScale = 0;
        birdController.enabled = false;
        
    }

    public void GameOver()
    {
       gameOver.SetActive(true);
       playButton.SetActive(true);

        Pause();
       

    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    
}
