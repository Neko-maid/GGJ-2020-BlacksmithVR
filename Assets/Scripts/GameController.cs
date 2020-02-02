using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float timeLeft = 90;
    public static int score;
    public int numWeaponsFixed;
    public TextMesh timer;
    public TextMesh scoreMesh;

    public GameObject[] WeaponPrefabs;
    public Transform SpawnLocation;

    public bool IsWeaponActive = false;


    void Start()
    {
        //SpawnPrefab(WeaponPrefabs[RandomNumber()]);

        //IsWeaponActive = true;
    }

    private void SpawnPrefab(GameObject weapon)
    {
        Instantiate(weapon, SpawnLocation.transform.position, Quaternion.identity);
    }

    private int RandomNumber()
    {
        return Random.Range(0, WeaponPrefabs.Length);
    }

    void Update()
    {
        if (!IsWeaponActive)
        {
            SpawnPrefab(WeaponPrefabs[RandomNumber()]);
            IsWeaponActive = true;
        }
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        } 

        scoreMesh.text = "Score: " + score;

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

        if (OVRInput.GetDown(OVRInput.RawButton.Y) || OVRInput.GetDown(OVRInput.RawButton.B))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
