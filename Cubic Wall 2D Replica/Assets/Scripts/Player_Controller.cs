using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [Header("Position")]
    [SerializeField] private Vector3 _startPos;
    [SerializeField] private Vector3 _endPos;

    [Header("Move Speed")]
    [SerializeField] private float _moveSpeed;

    [Header("Check Position")]
    [SerializeField] private bool _isPos = false;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && _isPos == false && transform.position.x == _startPos.x) {
            _isPos = true;
        }
        else if(Input.GetMouseButtonDown(0) && _isPos == true && transform.position.x == _endPos.x) {
            _isPos = false;
        }

        if(_isPos == true) {
            transform.position = Vector2.MoveTowards(transform.position, _endPos, _moveSpeed * Time.deltaTime);
        }
        else if(_isPos == false) {
            transform.position = Vector2.MoveTowards(transform.position, _startPos, _moveSpeed * Time.deltaTime);
        }
    }
}
