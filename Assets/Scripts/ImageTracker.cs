using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class ImageTracker : MonoBehaviour {
	public TrackingP1 p1;
	public TrackingP2 p2;
	public TrackingP3 p3;

	public Canvas allProducts;
	public Canvas p1p2Canvas;
	public Canvas p1p3Canvas;
	public Canvas p2p3Canvas;
	public Canvas none;
	public Canvas a;
	public Canvas b;

	// Use this for initialization
	void Start () {
		
		allProducts.enabled = false;
		p1p2Canvas.enabled = false;
		p1p3Canvas.enabled = false;
		p2p3Canvas.enabled = false;
		none.enabled = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(p1.p1Active && p2.p2Active && p3.p3Active|| Input.GetKey(KeyCode.F)) {
			allProducts.enabled = true;
			p1p2Canvas.enabled = false;
			p1p3Canvas.enabled = false;
			p2p3Canvas.enabled = false;
			none.enabled = false;
		} else if(p1.p1Active && p2.p2Active) {
			allProducts.enabled = false;
			p1p2Canvas.enabled = true;
			p1p3Canvas.enabled = false;
			p2p3Canvas.enabled = false;
			none.enabled = false;
			a.enabled = false;
			b.enabled = false;
		} else if(p1.p1Active && p3.p3Active) {
			allProducts.enabled = false;
			p1p2Canvas.enabled = false;
			p1p3Canvas.enabled = true;
			p2p3Canvas.enabled = false;
			none.enabled = false;
		} else if(p2.p2Active && p3.p3Active) {
			allProducts.enabled = false;
			p1p2Canvas.enabled = false;
			p1p3Canvas.enabled = false;
			p2p3Canvas.enabled = true;
			none.enabled = false;
		} else {
			allProducts.enabled = false;
			p1p2Canvas.enabled = false;
			p1p3Canvas.enabled = false;
			p2p3Canvas.enabled = false;
			none.enabled = true;
		}
	}
}
