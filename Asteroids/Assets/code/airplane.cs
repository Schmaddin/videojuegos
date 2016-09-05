using UnityEngine;
using System.Collections;

public class airplane : MonoBehaviour {

    private float _strength = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
            GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0.0f,2.0f));
        if (Input.GetKey(KeyCode.DownArrow))
            GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0.0f, -2.0f));
        if (Input.GetKey(KeyCode.LeftArrow))
            GetComponent<Transform>().Rotate(new Vector3(0.0f, 0.0f,1.0f), 1);
        if (Input.GetKey(KeyCode.RightArrow))
            GetComponent<Transform>().Rotate(new Vector3(0.0f, 0.0f, 1.0f), -1);

        /*
        if (Input.GetKey(KeyCode.LeftArrow))
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-50.0f, 0.0f));

        if (Input.GetKey(KeyCode.RightArrow))
            GetComponent<Rigidbody2D>().AddForce(new Vector2(50.0f, 0.0f));*/
	}
}
