﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class music : MonoBehaviour {

    private void Awake() {
        //DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(this);    
    }


}
