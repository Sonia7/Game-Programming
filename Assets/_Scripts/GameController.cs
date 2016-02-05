using UnityEngine;
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
            this.LivesLabel.text = "lives: " + this._livesValue;
        }
    }


    // PUBLIC INSTANCE VARIABLES
    public int enemyNumber = 3;
    public EnemyController  No_of_Enemy;
    public Text LivesLabel;
    public Text ScoreLabel;


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


        for (int cloudCount = 0; cloudCount < this.enemyNumber; cloudCount++)
        {
            Instantiate(No_of_Enemy.gameObject);
        }
    }
}

