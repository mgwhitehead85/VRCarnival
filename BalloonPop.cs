using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopBalloon : MonoBehaviour {
	int score = 0;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Balloon Board") {
			var joint = gameObject.AddComponent<FixedJoint> ();
			joint.connectedBody = col.rigidbody;
		}

		if ((col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (3)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (16)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (18)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (4)")) {
			Destroy(col.gameObject);
			setScore(30);
			Debug.Log ("30 Points!");
			Debug.Log (score.ToString());
		}

		if ((col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (9)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (14)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (6)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (5)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (7)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (12)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (17)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (15)")){
			Destroy(col.gameObject);
			setScore(20);
			Debug.Log ("20 Points!");
			Debug.Log ("Score: " + score.ToString());
		}

		if ((col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (8)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (13)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (11)")
			|| (col.gameObject.CompareTag("prey") && col.gameObject.name == "Balloon (10)")) {
			Destroy(col.gameObject);
			setScore(10);
			Debug.Log ("10 Points!");
			Debug.Log ("Score: " + score.ToString());
		}
	}

	void setScore(int i){
		score = score + i;
	}
}
