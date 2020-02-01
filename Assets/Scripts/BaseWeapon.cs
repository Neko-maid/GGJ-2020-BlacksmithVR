using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : MonoBehaviour
{
    bool isFixed;
    public enum WeaponDefect {
        Blunt, 
        Unpolished,
        Broken,
        Bent,
        ArrowThrough
    }

    public WeaponDefect defect;  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
