using UnityEngine;
using System.Collections;
using System;

public class State {
	
	private int maxValue;

	private int currentStateValue;

	public int MaxValue {
		get {
			return maxValue;
		}
		set {
			maxValue = value;
		}
	}

	public int CurrentStateValue {
		get {
			return currentStateValue;
		}
		set {
			currentStateValue = value;
		}
	}
}
