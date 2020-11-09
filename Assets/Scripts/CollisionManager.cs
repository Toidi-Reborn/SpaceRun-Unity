using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{

    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] GameObject deathFX;



    void OnTriggerEnter(Collider other) {
        //print("Collid - Trigger");

        StartDeathSequence();
        deathFX.SetActive(true);
        Invoke("ReloadSceen", levelLoadDelay);

        
    }

    private void StartDeathSequence(){

        print("dye");
        SendMessage("OnPlayerDeath");


    }


    private void ReloadSceen() { //string ref

        SceneManager.LoadScene(1);

    }


























    // Update is called once per frame
    void Update()
    {
        
    }
}
