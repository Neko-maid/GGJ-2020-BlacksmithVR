using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : BaseWeapon
{


    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        defects = new List<WeaponDefect>();
        defects.Add(WeaponDefect.Unpolished);

        if(containsDefect(WeaponDefect.Unpolished)) {
            RequirePolish();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }

}
