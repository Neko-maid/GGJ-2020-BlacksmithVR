using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : MonoBehaviour
{
    public enum WeaponDefect {
        Blunt, 
        Unpolished,
        Broken,
        Bent,
        ArrowThrough
    }

    public WeaponDefect[] defects;


    public void GenerateRandomDefects(int numOfDefects) {
        if(numOfDefects == 0) return;
        defects = new WeaponDefect[numOfDefects];

        for(int i = 0; i < numOfDefects; i++) {
            WeaponDefect defect = (WeaponDefect) Random.Range(0, System.Enum.GetValues(typeof(WeaponDefect)).Length);
            while (System.Array.FindIndex(defects, x => x == defect) != -1) {
                defect = (WeaponDefect) Random.Range(0, System.Enum.GetValues(typeof(WeaponDefect)).Length);
            }
            defects[i] = defect;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GenerateRandomDefects(2);
        
        Debug.Log(defects[0]);
        Debug.Log(defects[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isFixed() {
        if(defects.Length == 0) {
            return true;
        }
        return false;
    }
}
