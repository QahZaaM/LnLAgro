using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackingP1 : DefaultTrackableEventHandler {

	public bool p1Active = false;
	// Use this for initialization
	protected override void OnTrackingFound() {
		base.OnTrackingFound();
		p1Active = true;
	}

	protected override void OnTrackingLost() {
		base.OnTrackingLost();
		p1Active = false;
	}
}
