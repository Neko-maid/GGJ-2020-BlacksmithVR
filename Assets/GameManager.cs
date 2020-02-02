using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] WeaponPrefabs;
    public Transform SpawnLocation;

    private bool IsWeaponActive = false;

    void Start()
    {

    }

    void Update()
    {
        
    }

    private void SpawnPrefab(GameObject weapon)
    {
        Instantiate(weapon, SpawnLocation.transform.position, Quaternion.identity);
    }
}
