using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Map : MonoBehaviour {

	public static Map instance = null;

	List<Region> regions = new List<Region>();

	// Use this for initialization
	void Awake () {
		Map.instance = this;
		this.regions.AddRange(this.GetComponentsInChildren<Region>());
	}

	void OnDestroy() {
		Map.instance = null;
	}
}
