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

    public List<WeaponDefect> defects;

    public float polishAmount;
    public Material rusted;
    public Material defaultMat;

    public GameObject polishPart;

    public void GenerateRandomDefects(int numOfDefects) {
        if(numOfDefects == 0) return;
        defects = new  List<WeaponDefect> ();

        for(int i = 0; i < numOfDefects; i++) {
            WeaponDefect defect = (WeaponDefect) Random.Range(0, System.Enum.GetValues(typeof(WeaponDefect)).Length);
            while (defects.Contains(defect)) {
                defect = (WeaponDefect) Random.Range(0, System.Enum.GetValues(typeof(WeaponDefect)).Length);
            }
            defects.Add(defect);
        }
    }

    public bool containsDefect(WeaponDefect defect) {
        return (defects.Contains(defect));
    }

    // Start is called before the first frame update
    public void Start()
    {
        defaultMat = polishPart.GetComponent<MeshRenderer> ().material;
        GenerateRandomDefects(2);
        
        Debug.Log(defects[0]);
        Debug.Log(defects[1]);

        if(containsDefect(WeaponDefect.Unpolished)) {
            RequirePolish();
        }

        

    }

    // Update is called once per frame
    public void Update()
    {
        if(containsDefect(WeaponDefect.Unpolished)) {
            CheckPolish();
        }
    }

    public bool isFixed() {
        if(defects.Count == 0) {
            return true;
        }
        return false;
    }

    void RequirePolish() {
        polishAmount = 100f;
        polishPart.GetComponent<MeshRenderer> ().material = rusted;

    }

    void CheckPolish() {
        if(polishAmount < 0f) {
            polishPart.GetComponent<MeshRenderer> ().material = defaultMat; 
            defects.Remove(WeaponDefect.Unpolished);
        }
    }
}
