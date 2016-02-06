using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
    // PUBLIC INSTANCE VARIABLES
    public float minVerticalSpeed = -1f;
    public float maxVerticalSpeed = 1f;
    public float minHorizontalSpeed = 3f;
    public float maxHorizontalSpeed = 5f;

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _verticalDrift;
    private float _horizontalSpeed;

    // Use this for initialization
    void Start()
    {
        // Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();

        // Reset the Cloud Sprite to the Top
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._horizontalSpeed, this._verticalDrift);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -343)
        {
            this.Reset();
        }
    }

    public void Reset()
    {
        this._horizontalSpeed = Random.Range(this.minHorizontalSpeed, this.maxHorizontalSpeed);
        this._verticalDrift = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        float yPosition = Random.Range(-200f, 200f);// random positions of enemy when reaches end 
        this._transform.position = new Vector2(246f, yPosition);
    }
}
