using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMoveSingle : MonoBehaviour {
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    Transform transform;

	// Use this for initialization
	void Start () {
       transform = this.gameObject.GetComponent<Transform>();	
	}
	
	// Update is called once per frame
        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            transform.Translate(new Vector3(moveHorizontal, moveVertical));
        }
    
}
