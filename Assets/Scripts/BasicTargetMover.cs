using UnityEngine;
using System.Collections;

public class BasicTargetMover : MonoBehaviour {

	public enum motionDirections{Spin, Horizontal, Vertical};
	public motionDirections motionState=motionDirections.Horizontal;


	public float spinSpeed = 180f, motionMagnitude = 0.1f;
	// Update is called once per frame
	void Update () {


		switch (motionState) {
		case motionDirections.Spin:
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
			break;
		case motionDirections.Horizontal:
			gameObject.transform.Translate (Vector3.right * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
			break;
		case motionDirections.Vertical:
			gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
			break;
		}
				
	}
}
