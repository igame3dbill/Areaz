using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMove2DArray : MonoBehaviour {
    [SerializeField]
    float moveSpeed;

    // Data Type + [] makes array string[], int[], float[], bool[], GameObject[] etc.
    [SerializeField]
    Transform[] transforms;

	// Use this for initialization
	void Start () {
       // transforms = this.gameObject.GetComponent<Transform>();	
	}
	
	// Update is called once per frame
        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // move many objects at once
        foreach (Transform T in transforms)
        {
            T.Translate(new Vector3(moveHorizontal, moveVertical));
        }

         
        }
    
}
