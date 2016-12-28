using UnityEngine;
using System.Collections;
using System.Collections.Generic;


//------------------------------------------------------------------------------
//==============================================================================
// 弾プール.
public class BulletGenerator : MonoBehaviour {


	[SerializeField] private GameObject[] bullets = null;	// 子要素に入っている弾プール.
	

	//------------------------------------------------------------------------------
	void Start() {

		// 子要素の弾たちを配列にしている.
		Queue< GameObject > q = new Queue< GameObject >();
		for ( int i = 0; i < this.transform.childCount; ++i ) {
			q.Enqueue( this.transform.GetChild( i ).gameObject );
		}
		this.bullets = q.ToArray();
		q.Clear();
		
	}

	
	//------------------------------------------------------------------------------
	void Update() {}


	//------------------------------------------------------------------------------
	public void shot(
			Transform origin ) {

		// 子要素の配列の中から使えるものを探し、あれば使いまわす.
		for ( int i = 0; i < this.bullets.Length; ++i ) {
			if ( !this.bullets[ i ].activeSelf ) {
				this.bullets[ i ].SetActive( true );
				this.bullets[ i ].transform.position = origin.position;
				this.bullets[ i ].transform.rotation = origin.rotation;
				break;
			}
		}
	}
	



}















