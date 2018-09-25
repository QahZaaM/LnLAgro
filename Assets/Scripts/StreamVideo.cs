﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVideo : MonoBehaviour {

	public VideoPlayer videoPlayer;
	public RawImage rawImage;


	// Use this for initialization
	void Start () {
		StartCoroutine(PlayVideo());
	}

	IEnumerator PlayVideo() {
		videoPlayer.Prepare();
		WaitForSeconds waitForSeconds = new WaitForSeconds(1);
		while(!videoPlayer.isPrepared) {
			yield return waitForSeconds;
			break;
		}
		rawImage.texture = videoPlayer.texture;
		videoPlayer.Play();
	}
}
