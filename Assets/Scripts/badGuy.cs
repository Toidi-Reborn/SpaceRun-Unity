using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badGuy : MonoBehaviour
{
 
    [SerializeField] GameObject BaddyBoom;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 12;


    ScoreBoard scoreBoard;

 
    void Start()
    {
        addNonTriggerBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }
    private void addNonTriggerBoxCollider() {

        addBoxCollider();
   }



    void addBoxCollider(){

        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    //add a component
    //GameObject.AddComponent<>();

    void OnParticleCollision(GameObject other) {
        print(gameObject.name + " was hit!!!!");
        scoreBoard.ScoreHit(scorePerHit);

        // create the prefab "BaddyBoom" at the position and do not rotate
        GameObject fx = Instantiate(BaddyBoom, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        
        Destroy(gameObject);


    }


}
