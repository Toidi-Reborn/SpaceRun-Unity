using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class playerMove : MonoBehaviour
{
    [Header("General")]
    [Tooltip("In units per second- BOOM, Comment")][SerializeField] float xSpeed = 10f;
    [Tooltip("In units")][SerializeField] float xRange = 5f;
    [Tooltip("In units per second- BOOM, Comment")][SerializeField] float ySpeed = 8f;
    [Tooltip("In units")][SerializeField] float yRange = 3f;

    [Header("Position-Throw")]
    [SerializeField] float posPitchFactor = -5f;
    [SerializeField] float controlPitchFactor = -20f;
    [SerializeField] float posYawFactor = 5f;
    [SerializeField] float controlRollFactor = -20f;
    

    float yThrow, xThrow;
    bool controlEnabled = true;



    void Start()
    
    {
         
    }
    
    

    // Update is called once per frame
    void Update(){

        if (controlEnabled) {
            Translation();
            Rotation();
        }        
    }

    void OnPlayerDeath() {     //called by script ref
        print("sadfsfdsfds");
        controlEnabled = false;
    }


    private void Rotation(){

        float pitchInPosition = transform.localPosition.y * posPitchFactor;
        float pitchDueToThrow = yThrow * controlPitchFactor;
        float pitch = pitchInPosition + pitchDueToThrow;
        float yaw = transform.localPosition.x * posYawFactor;
        float roll = xThrow * controlRollFactor;

        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);

    }


    private void Translation(){
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        
        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float yOffset = yThrow * ySpeed * Time.deltaTime;

        float rawNewXPos = transform.localPosition.x + xOffset;
        float rawNewYPos = transform.localPosition.y + yOffset;
        //clamp
        float clampX = Mathf.Clamp(rawNewXPos, -xRange, xRange);
        float clampY = Mathf.Clamp(rawNewYPos, -yRange, yRange);

        transform.localPosition = new Vector3(clampX, clampY, transform.localPosition.z);
    }

}
