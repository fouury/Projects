﻿using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
	Vector3 cameraInitialPosition;
	public float shakeMagnitude=0.05f,shakeTime=0.5f;
	public Camera mainCamera;
	public float Repeatingrate;

	public void ShakeIt(){
		cameraInitialPosition = mainCamera.transform.position;
		InvokeRepeating ("StartCameraShaking", 0f, Repeatingrate);
		Invoke ("StopCameraShaking", shakeTime);
	}

	void StartCameraShaking(){
		float cameraShakingOffsetX = Random.value * shakeMagnitude * 2 - shakeMagnitude;
		float cameraShakingOffsetY = Random.value * shakeMagnitude * 2 - shakeMagnitude;
		Vector3 cameraIntermadiatePosition = mainCamera.transform.position;
		cameraIntermadiatePosition.x += cameraShakingOffsetX;
		cameraIntermadiatePosition.y +=	cameraShakingOffsetY;
		mainCamera.transform.position = cameraIntermadiatePosition;
	}

	void StopCameraShaking(){
		CancelInvoke ("StartCameraShaking");
		//mainCamera.transform.position = cameraInitialPosition;
	}



}