using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    public BoxCollider2D boxCollider;
    private float groundHorizontalLength;

	// Use this for initialization
	void Start () {
        boxCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = boxCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -groundHorizontalLength)
        {
            RepostionBackground();
        }
		
	}

    private void RepostionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
