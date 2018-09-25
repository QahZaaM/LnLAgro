using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackingP3 : DefaultTrackableEventHandler {

	public bool p3Active = false;
	// Use this for initialization
	protected override void OnTrackingFound() {
		base.OnTrackingFound();
		p3Active = true;
	}

	protected override void OnTrackingLost() {
		base.OnTrackingLost();
		p3Active = false;
	}
}
