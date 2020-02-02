using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerController : MonoBehaviour
{

    TextMesh text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.timeLeft > 0)
        {
            text.text = "" + Mathf.RoundToInt(GameController.timeLeft);
        }
        else 
        { 
            text.text = "Game Over";
        }
    } 
}
