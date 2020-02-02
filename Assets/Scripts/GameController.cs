using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float timeLeft = 15;
    public static int score;
    public int numWeaponsFixed;
    public TextMesh timer;
    public TextMesh scoreMesh;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        } 

        scoreMesh.text = "" + score;

        if (timeLeft < 10)
        {
            timer.color = Color.red;
        }
        if (timeLeft > 0)
        {
            timer.text = "" + Mathf.RoundToInt(GameController.timeLeft);
        }
        else 
        { 
            timer.text = "Game Over";
        }
    }
}
