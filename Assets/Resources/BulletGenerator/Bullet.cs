using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += this.transform.forward * speed;

		if ( 50 < this.transform.position.z )
			this.gameObject.SetActive( false );
	}


}
