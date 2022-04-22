using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeMovement : MonoBehaviour
{
    int speed = 3000;
    Rigidbody2D _rigidbody;
    Direction _direction = Direction.idle;
    private Vector2 startTouchPosition;
    private Vector2 currentTouchPosition;
    private Vector2 endTouchPosition;
    private bool stopTouch = false;
    public float swipeRange = 50;

    enum Direction {
        up, down, left, right, idle
    }

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
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
                if (Distance.y > swipeRange) {
                    //_rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX;
                    _direction = Direction.up;
                    stopTouch = true;
                }

                else if (Distance.y < -swipeRange) {
                    //_rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX;
                    _direction = Direction.down;
                    stopTouch = true;
                }

                else if (Distance.x < -swipeRange) {
                    //_rigidbody.constraints = RigidbodyConstraints2D.FreezePositionY;
                    _direction = Direction.left;
                    stopTouch = true;
                }

                else if (Distance.x > swipeRange) {
                    //_rigidbody.constraints = RigidbodyConstraints2D.FreezePositionY;
                    _direction = Direction.right;
                    stopTouch = true;
                }
            }
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) {
            stopTouch = false;
            endTouchPosition = Input.GetTouch(0).position;
            Vector2 Distance = endTouchPosition - startTouchPosition;
        }
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
}
