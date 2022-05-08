using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeMovement : MonoBehaviour
{
    int speed = 3000;
    Rigidbody2D _rigidbody;
    Direction _direction;
    private Vector2 startTouchPosition;
    private Vector2 currentTouchPosition;
    private Vector2 endTouchPosition;
    private bool stopTouch = false;
    public float swipeRange = 50;
    AudioSource audioSrc;

    enum Direction {
        up, down, left, right, idle
    }

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        audioSrc = GetComponent<AudioSource> ();
        Transition();
        // _direction = (Direction)System.Enum.Parse(typeof(Direction), PlayerPrefs.GetString("movement"));
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            startTouchPosition = Input.GetTouch(0).position;
        }
        
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            currentTouchPosition = Input.GetTouch(0).position;
            Vector2 Distance = currentTouchPosition - startTouchPosition;
            if (!stopTouch) {
                SwipeCount.swipeAmount += 1;
                if (Distance.y > swipeRange) {
                    _direction = Direction.up;
                    stopTouch = true;
                }

                else if (Distance.y < -swipeRange) {
                    _direction = Direction.down;
                    stopTouch = true;
                }

                else if (Distance.x < -swipeRange) {
                    _direction = Direction.left;
                    stopTouch = true;
                }

                else if (Distance.x > swipeRange) {
                    _direction = Direction.right;
                    stopTouch = true;
                }
            }
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) {
            stopTouch = false;
            endTouchPosition = Input.GetTouch(0).position;
            Vector2 Distance = endTouchPosition - startTouchPosition;
            audioSrc.Play();
        }

        // PlayerPrefs.SetString("movement", _direction.ToString());
    }

    private void FixedUpdate() {
        switch(_direction) {
            case Direction.up:
                _rigidbody.velocity = new Vector2(0, speed * Time.deltaTime);
                break;
            
            case Direction.down:
                _rigidbody.velocity = new Vector2(0, -speed * Time.deltaTime);
                break;
            
            case Direction.left:
                _rigidbody.velocity = new Vector2(-speed * Time.deltaTime, 0);
                break;
            
            case Direction.right:
                _rigidbody.velocity = new Vector2(speed * Time.deltaTime, 0);
                break;
        }
    }

    public void Transition() {
        if (SceneManager.GetActiveScene().name == "Level1") {
            _direction = Direction.idle;
        }

        else if (SceneManager.GetActiveScene().name == "Level2") {
            _direction = Direction.right;
        }

        else if (SceneManager.GetActiveScene().name == "Level3") {
            _direction = Direction.right;
        }

        else if (SceneManager.GetActiveScene().name == "Level4") {
            _direction = Direction.down;
        }

        else if (SceneManager.GetActiveScene().name == "Level5") {
            _direction = Direction.left;
        }
    }
}
