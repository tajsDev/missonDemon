﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
    //A static field accessible by code anywhere
    static public bool goalMet = false;

    private void OnTriggerEnter(Collider other)
    {
        //When trigger is hit, check to see if it is projectile
        Projectile proj = other.GetComponent<Projectile>();
        if (proj != null)
        {
            //If so, set goalMet to true
            Goal.goalMet = true;
            Slingshot.aimingMode = false;
            //Also set the alpha of the color to higher opacity
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 1;
            mat.color = c;
            Invoke("loadEndCard",5f);
            
        }
    }
    private void loadEndCard()
    {
        SceneManager.LoadScene("EndCard");
    }
}
