using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : BaseWeapon
{

    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;

    int arrowExitCount; 

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        
        if(containsDefect(WeaponDefect.ArrowThrough)) {
            arrow1.gameObject.SetActive(true);
            arrow2.gameObject.SetActive(true);
            arrow3.gameObject.SetActive(true);
            arrowExitCount = 0;
        }

        if(containsDefect(WeaponDefect.Blunt)) {
            defects.Remove(WeaponDefect.Blunt);
        }

        if(containsDefect(WeaponDefect.Unpolished)) {
            defects.Remove(WeaponDefect.Unpolished);
        }
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();

    }

    void OnTriggerExit(Collider col) {
        if(col.gameObject.Equals(arrow1) || col.gameObject.Equals(arrow2) || col.gameObject.Equals(arrow3) ) {
            col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            arrowExitCount += 1;
            Debug.Log("Arrow removed");
            if(arrowExitCount > 2) {
                defects.Remove(WeaponDefect.ArrowThrough);
            }
        } 


    }

}
