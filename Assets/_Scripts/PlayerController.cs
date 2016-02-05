using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 6f;
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPosition;
    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;



        this._playerInput = Input.GetAxis("Horizontal");
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(this.speed, 0);

        }
        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(this.speed, 0);
        }

        this._playerInput = Input.GetAxis("Vertical");
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(0, this.speed);

        }
        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(0, this.speed);
        }



        if (this._currentPosition.x < -260)
        {

            this._currentPosition.x = -260;
        }
        if (this._currentPosition.x > 240)
        {

            this._currentPosition.x = 240;
        }

        if (this._currentPosition.y< -190)
        {

            this._currentPosition.y = -190;
        }
        if (this._currentPosition.y> 200)
        {

            this._currentPosition.y = 200;
        }
        this._transform.position = this._currentPosition;
    }
}
