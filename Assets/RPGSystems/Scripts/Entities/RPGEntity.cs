﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGEntity : MonoBehaviour {
	[SerializeField]
	private RPGEntityLevel entityLevel;

	public RPGEntityLevel EntityLevel{
		get{ return entityLevel;}
		set{ entityLevel = value;}
	}

	private void Awake(){
		if (EntityLevel == null) {
			EntityLevel = GetComponent<RPGEntityLevel> ();
			if (EntityLevel == null) {
				Debug.LogWarning ("No RPGEntityLevel assigned to RPGEntity");
			}
		}
	}
}
