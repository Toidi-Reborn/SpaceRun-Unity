using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {

    private void Awake() {

        int numMusicPlayer = FindObjectsOfType<music>().Length;
        print("number of players " + numMusicPlayer );

        if (numMusicPlayer > 1) {
            Destroy(gameObject);
        }
        else {    
            DontDestroyOnLoad(this);    
        }



    }


}
