using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private PlayerScriptableObject pData;
    public TextMeshProUGUI pHealth;
    public GameObject end;

    private void Update()
    {
        AdjustHealth();
    }

    public void AdjustHealth()
    {
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            pData.health += 10;
            pHealth.text = "Health: " + pData.health;
        }
        else if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            pData.health -= 10;
            pHealth.text = "Health: " + pData.health;

            if (pData.health <= 0)
            {
                end.SetActive(true);
            }
        }
    }
}
