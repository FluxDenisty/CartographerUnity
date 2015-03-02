using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : AbstractManager {

	[SerializeField]
	List<AbstractAction> availableActions;

	public delegate void NextTurnDelegate();
	public NextTurnDelegate notifyNextTurn;

	private int currentTurn = 1;
	public int CurrentTurn {
		get { return this.currentTurn; }
	}
	
	public override void Initialize() {}

	public void GotoNextTurn() {
		this.currentTurn += 1;
		this.notifyNextTurn();
	}

	// TODO: action idx stuff is temporary.
	public void PerformAction(int actionIdx) {
		availableActions[actionIdx].PerformAction();
	}
}
