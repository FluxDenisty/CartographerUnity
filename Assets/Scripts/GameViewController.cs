using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameViewController : MonoBehaviour {
	[SerializeField]
	private Text curTurnText;

	// Use this for initialization
	void Start () {
		this.HandleNextTurnProcess();
		ManagerManager.Instance.GetManager<GameManager>().notifyNextTurn += HandleNextTurnProcess;
	}


	private void HandleNextTurnProcess() {
		curTurnText.text = "Turn " + ManagerManager.Instance.GetManager<GameManager>().CurrentTurn;
	}

	public void NextTurnButtonPressed() {
		ManagerManager.Instance.GetManager<GameManager>().GotoNextTurn();
	}

	// TODO: action idx stuff is temporary.
	public void ActionButtonPressed(int actionIdx) {
		GameManager gameManager = ManagerManager.Instance.GetManager<GameManager>();

		gameManager.PerformAction(actionIdx);
	}
}
