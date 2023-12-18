using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    int lives = 3;

    [SerializeField]
    GameObject textGameObject;

    TextMeshProUGUI textComponent;

    void Start()
    {
        textComponent = textGameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        string livesText = "Lives: " + lives;
        textComponent.text = livesText;
    }

}
