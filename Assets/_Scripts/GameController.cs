using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;
    [SerializeField]
    private AudioSource _gameOverSound;
    // PUBLIC ACCESS METHODS
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }// set score when player hit ring
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "lives: " + this._livesValue;
            }
        }// set when player hit enemy
    }


    // PUBLIC INSTANCE VARIABLES
    public int enemyNumber = 3;
    public EnemyController  No_of_Enemy;
    public PlayerController player;
    public StarController star;
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public Text HighScoreLabel;
    public Button RestartButton;

    // Use this for initialization
    void Start()
    {
        this._initialize();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //PRIVATE METHODS ++++++++++++++++++

    //Initial Method
    private void _initialize()
    {
        this.ScoreValue = 0;// initially score 0
        this.LivesValue = 5;// lives to play 5 
        this.HighScoreLabel.gameObject.SetActive(false);//initially set invisible 
        this.GameOverLabel.gameObject.SetActive(false);
      this.RestartButton.gameObject.SetActive(false);

        for (int cloudCount = 0; cloudCount < this.enemyNumber; cloudCount++)
        {
            Instantiate(No_of_Enemy.gameObject);
        }// used cloudcount for enemy count
    }
    private void _endGame()
    {
      this.HighScoreLabel.text = "High Score: " + this._scoreValue;
        this.GameOverLabel.gameObject.SetActive(true);// set active ;that is it appears when game ends.
     this.HighScoreLabel.gameObject.SetActive(true);
        this.LivesLabel.gameObject.SetActive(false);// hide on end of game
        this.ScoreLabel.gameObject.SetActive(false);// hide on end of game
        this.player.gameObject.SetActive(false);// hide on end of game
        this.star.gameObject.SetActive(false);// hide on end of game
      this._gameOverSound.Play();//plays game end track
       this.RestartButton.gameObject.SetActive(true);// show up restart button on game over
    }
    public void RestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        this.star.gameObject.SetActive(true);
    }
}

