using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

    private AudioSource[] _audioSources;
    private AudioSource _StarSound;
    private AudioSource _EnemySound;

    // PUBLIC INSTANCE VARIABLES
    public GameController gameController;

    // Use this for initialization
    void Start()
    {
        // Initialize the audioSources array
        this._audioSources = gameObject.GetComponents<AudioSource>();
       this._EnemySound = this._audioSources[1];
        this._StarSound = this._audioSources[2];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hoop"))
        {
           
            this._StarSound.Play();
           this.gameController.ScoreValue += 100;
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            
           this._EnemySound.Play();
           this.gameController.LivesValue -= 1;
        }
    }

}
