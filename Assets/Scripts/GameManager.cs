using UnityEngine;
using System.Collections;

public class GameManager : AbstractManager {

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
}
