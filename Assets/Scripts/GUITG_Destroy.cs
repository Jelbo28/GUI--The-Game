﻿using UnityEngine;
using System.Collections;

public class GUITG_Destroy : MonoBehaviour
{
	// Use this for initialization
	void Awake ()
    {
        Destroy(gameObject, 6f);
	}
    
    public void Destruct()
    {
        Destroy(gameObject, 0f);
    }	
}
