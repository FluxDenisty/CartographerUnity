using UnityEngine;
using System.Collections;

public class DoNothingAction : AbstractAction {
	public override void PerformAction() {
		Debug.Log("Dorf performed no action");
	}
}
