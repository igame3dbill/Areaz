using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMove2DArray : MonoBehaviour {
    [SerializeField]
    float moveSpeed;

    // Data Type + [] makes array string[], int[], float[], bool[], GameObject[] etc.
    [SerializeField]
    Transform[] transforms;

    int altSpeed = 1;
	// Use this for initialization
	void Start () {
       // transforms = this.gameObject.GetComponent<Transform>();	
	}
	
	// Update is called once per frame
        void FixedUpdate()
        {

        altSpeed = 1;
        foreach (Transform T in transforms)
        {
            altSpeed++;
            moveSpeed = altSpeed *2;
            // move many objects at once
            float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            T.Translate(new Vector3(moveHorizontal, moveVertical));
        }

        }
    
}
