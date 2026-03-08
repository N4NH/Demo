using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerHealth PlayerHealth;
    [SerializeField] private GameObject GameOver_Panel;
    [SerializeField] private GameObject gameWinUI;
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    void Start()
    {
        GameOver_Panel.SetActive(false);
        gameWinUI.SetActive(false);
        PlayerHealth.onDead += OnGameOver;
    }
    private void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }
    private void OnGameOver()
    {
        GameOver_Panel.SetActive(true);
    }
    private void OnGameWin()
    {
        gameWinUI.SetActive(true);
        PlayerHealth.gameObject.SetActive(false);
    }
}
