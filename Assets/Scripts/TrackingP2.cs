using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackingP2 : DefaultTrackableEventHandler {

	public bool p2Active = false;
	// Use this for initialization
	protected override void OnTrackingFound() {
		base.OnTrackingFound();
		p2Active = true;
	}

	protected override void OnTrackingLost() {
		base.OnTrackingLost();
		p2Active = false;
	}
}
