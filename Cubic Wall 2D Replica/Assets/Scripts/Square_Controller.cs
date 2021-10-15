using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square_Controller : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Game_Manager game_Manager;
    [SerializeField] private Shake_Controller shake_Controller;

    [Header("Bubble")]
    [SerializeField] private GameObject _bubblePrefab;

    [Header("Gameplay")]
    [SerializeField] private string _currentColor;
    [SerializeField] private float _lifeTime;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == _currentColor) {
            game_Manager._score++;
            Destroy(other.gameObject);
            shake_Controller._isShake = true;
            GameObject _newBubble = Instantiate(_bubblePrefab, transform.position, Quaternion.identity);
            Destroy(other.gameObject, _lifeTime);
        }
        else {
           game_Manager.GameOver();
        }
    }
}
