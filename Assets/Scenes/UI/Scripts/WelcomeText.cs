using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WelcomeText : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textElement;

    void Start()
    {
        textElement.text = "Hello, World!";
        textElement.fontSize = 24;
        textElement.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
