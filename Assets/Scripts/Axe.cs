using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : BaseWeapon
{

    float polishAmount;
    public Material rusted;
    Material defaultMat;

    public GameObject axeHead;
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        defaultMat = axeHead.GetComponent<MeshRenderer> ().material;

        if(this.containsDefect(WeaponDefect.Unpolished)) {
            RequirePolish();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(this.containsDefect(WeaponDefect.Unpolished)) {
            CheckPolish();
        }
    }

    void RequirePolish() {
        polishAmount = 100f;
        axeHead.GetComponent<MeshRenderer> ().material = rusted;

    }

    void CheckPolish() {
        if(polishAmount < 0f) {
            axeHead.GetComponent<MeshRenderer> ().material = defaultMat; 
        }
    }
}
