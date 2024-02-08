using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField]
    private PlayerScriptableObject PlayerData;
    public TextMeshProUGUI name;
    public TextMeshProUGUI health;
    public TextMeshProUGUI lives;

    private void Start()
    {
        name.text = PlayerData.name;
        health.text = "Health: " + PlayerData.health;
        lives.text = "Lives: " + PlayerData.lives;
    }

    public void Update()
    {
        SwitchScenes();
    }

    public void SwitchScenes()
    {
        if (Input.GetKeyDown(KeyCode.Space) && PlayerData.pressCount == 1)
        {
            SceneManager.LoadScene("SceneDos");
            PlayerData.pressCount += 1;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && PlayerData.pressCount == 2)
        {
            SceneManager.LoadScene("SceneUno");
            PlayerData.pressCount -= 1;
        }
    }
}
