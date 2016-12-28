using UnityEngine;
using System.Collections;



//------------------------------------------------------------------------------
//==============================================================================
// プレイヤー.
public class Player : MonoBehaviour {



	public BulletGenerator bg = null;


	//------------------------------------------------------------------------------
	void Start() {}

	
	//------------------------------------------------------------------------------
	void Update() {
	
		if ( Input.GetKeyDown( KeyCode.Space ) ) {
			this.bg.shot( this.transform );
		}

	}


}
