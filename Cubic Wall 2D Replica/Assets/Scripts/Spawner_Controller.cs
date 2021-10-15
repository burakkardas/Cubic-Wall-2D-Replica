using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Controller : MonoBehaviour
{
    [SerializeField] private Game_Manager game_Manager;
    [SerializeField] private GameObject[] _balls;
    [SerializeField] private float _minX , _maxX;
    [SerializeField] private float _duration;
    private float _currentTime;
    void Update()
    {
        if(game_Manager._isStart) {
            if(_currentTime < 0) {
                _currentTime = _duration;
                Spawn();
            }
            else {
                _currentTime -= Time.deltaTime;
            }
        }
    }

    private void Spawn() {
        GameObject _newBall = Instantiate(_balls[Random.Range(0, _balls.Length)]);

        _newBall.transform.position = new Vector2(
            Random.Range(_minX, _maxX),
            transform.position.y
        );

        _newBall.transform.SetParent(transform);
    }
}
