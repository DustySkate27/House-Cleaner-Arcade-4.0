using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausaManager : MonoBehaviour
{
    [SerializeField] private GameObject pausarPanel;
    [SerializeField] private GameObject escape;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "nivel1")
        {
            Time.timeScale = 0f;
            pausarPanel.SetActive(true);
        }
        if (SceneManager.GetActiveScene().name == "nivel2")
        {
            Time.timeScale = 0f;
            pausarPanel.SetActive(true);
        }
        if (SceneManager.GetActiveScene().name == "nivel4")
        {
            Time.timeScale = 0f;
            pausarPanel.SetActive(true);
        }
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            pausar();
        }
    }

    public void pausar()
    {
        pausarPanel.SetActive(true);
        escape.SetActive(true);
        Time.timeScale = 0f;
    }
    public void despausar()
    {
        Time.timeScale = 1f;
    }

    public void volverMenu()
    {
        SceneManager.LoadScene("Menu");
        perfectManager.perfect = 0;
        economyManager.playerMoney = 0;
        economyManager.LevelMoney = 0;  
    }
}
