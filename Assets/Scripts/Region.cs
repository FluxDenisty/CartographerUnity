using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Region : MonoBehaviour {
	
	public List<Region> neighbors = new List<Region>();

	public Image image;

	public int wood = 0;

	public int stone = 0;

	public int food = 0;

	void Awake() {
		this.wood = Random.Range(0, 10);
		this.stone = Random.Range(0, 10);
		this.food = Random.Range(0, 10);

		this.image = this.GetComponentInChildren<Image>();

		Button button = this.gameObject.AddComponent<Button>() as Button;

		EventTrigger trigger = this.gameObject.AddComponent<EventTrigger>() as EventTrigger;
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.PointerEnter;
		entry.callback = new EventTrigger.TriggerEvent();
		entry.callback.AddListener(new UnityEngine.Events.UnityAction<BaseEventData>(this.OnPointerEnter));
		trigger.delegates = new List<EventTrigger.Entry>();
		trigger.delegates.Add(entry);

		trigger = this.gameObject.AddComponent<EventTrigger>() as EventTrigger;
		entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.PointerExit;
		entry.callback = new EventTrigger.TriggerEvent();
		entry.callback.AddListener(new UnityEngine.Events.UnityAction<BaseEventData>(this.OnPointerExit));
		trigger.delegates = new List<EventTrigger.Entry>();
		trigger.delegates.Add(entry);
	}

	public void OnPointerEnter(BaseEventData baseEvent) {
		this.image.color = Color.green;
		foreach (Region r in this.neighbors) {
			r.image.color = Color.yellow;
		}
	}

	public void OnPointerExit(BaseEventData baseEvent) {
		this.image.color = Color.white;
		foreach (Region r in this.neighbors) {
			r.image.color = Color.white;
		}
	}
}
