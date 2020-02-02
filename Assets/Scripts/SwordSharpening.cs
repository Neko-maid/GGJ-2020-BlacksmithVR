using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSharpening : BaseWeapon
{
    public float TotalTime = 6f;
    public float TimeSharpened = 0f;
    private Renderer rend;



    new void Start()
    {
        base.Start();
        rend = GetComponent<Renderer>();
        if(!defects.Contains(WeaponDefect.Blunt))
        {
            defects.Add(WeaponDefect.Blunt);
        }
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag != "Grindstone") return;
        if (TimeSharpened >= TotalTime)
        {
            defects.Remove(WeaponDefect.Blunt);
            return;
        }
        TimeSharpened += Time.deltaTime;

        //float amount = Mathf.Lerp(0f, TotalTime, TimeSharpened);


        //rend.material.SetFloat("_Blend", amount);

        TimeSharpened += Time.deltaTime; // add time each frame
        float percentComplete = TimeSharpened / TotalTime; // value between 0 - 1
        percentComplete = Mathf.Clamp01(percentComplete); // this prevents it exceeding 1
        rend.material.SetFloat("_Blend", percentComplete);
    }
}

