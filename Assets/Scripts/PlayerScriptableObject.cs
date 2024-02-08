using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Player", menuName = "PlayerData/Data")]
public class PlayerScriptableObject : ScriptableObject
{
    public string name;
    public int health = 100;
    public int lives = 5;
    public int pressCount;
}
