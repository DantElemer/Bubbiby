using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D myRb;
	public float jumpForce;

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Jump"))
		{
				myRb.AddForce(transform.up * jumpForce);
		}
	}
}
