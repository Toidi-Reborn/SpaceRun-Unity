using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceenLoader : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start(){
        Invoke("LoadFirstSceen", 2f);
        
    }

    // Update is called once per frame
    void LoadFirstSceen(){
        SceneManager.LoadScene(1);
    }
}
