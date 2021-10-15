using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    [Header("Panels")]

    [Header("Text")]
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _bestScoreText;

    [Header("Gameplay")]
    public int _score = 0;
    public bool _isStart = false;
    void Start()
    {
        StartCoroutine(nameof(StartGame));
    }

    void Update()
    {
        _scoreText.text = _score.ToString("00");    
    }


    IEnumerator StartGame() {
        yield return new WaitForSeconds(1.5f);
        _isStart = true;
    }

    public void GameOver() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
















}
