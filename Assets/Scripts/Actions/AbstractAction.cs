using UnityEngine;
using System.Collections;

public abstract class AbstractAction : MonoBehaviour {
	// TODO: for now don't pass in Dorf. However later we would want to pass in the Dorf that performed this action.
	public abstract void PerformAction();
}
