﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;

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
        }
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
        }
    }


    // PUBLIC INSTANCE VARIABLES
    public int enemyNumber = 3;
    public EnemyController  No_of_Enemy;
    public PlayerController player;
    public StarController star;
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;

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
        this.ScoreValue = 0;
        this.LivesValue = 5;

        this.GameOverLabel.gameObject.SetActive(false);
        for (int cloudCount = 0; cloudCount < this.enemyNumber; cloudCount++)
        {
            Instantiate(No_of_Enemy.gameObject);
        }
    }
    private void _endGame()
    {
      //  this.HighScoreLabel.text = "High Score: " + this._scoreValue;
        this.GameOverLabel.gameObject.SetActive(true);
       // this.HighScoreLabel.gameObject.SetActive(true);
        this.LivesLabel.gameObject.SetActive(false);
        this.ScoreLabel.gameObject.SetActive(false);
        this.player.gameObject.SetActive(false);
        this.star.gameObject.SetActive(false);
      //  this._gameOverSound.Play();
      //  this.RestartButton.gameObject.SetActive(true);
    }
}

