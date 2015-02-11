using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ManagerManager : MonoBehaviour {

	private static ManagerManager instance = null;
	public static ManagerManager Instance {
		get { return instance; }
	}

	[SerializeField] private List<GameObject> managersPrefrabs;

	private Dictionary<System.Type, AbstractManager> managerDict = new Dictionary<System.Type, AbstractManager>();
	
	private void Awake () {
		ManagerManager.instance = this;
		GameObject.DontDestroyOnLoad(this);	

		foreach(GameObject go in this.managersPrefrabs) {
			GameObject instance = (GameObject) Instantiate(go);
			instance.transform.parent = this.gameObject.transform;
			AbstractManager absManager = instance.GetComponent<AbstractManager>();

			absManager.Initialize();

			managerDict.Add(absManager.GetType(), absManager);
		}
	}

	public T GetManager<T>() where T : AbstractManager {
		return this.managerDict[typeof(T)] as T;
	}
}
