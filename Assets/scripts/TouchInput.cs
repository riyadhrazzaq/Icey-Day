using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class TouchInput : MonoBehaviour,IPointerDownHandler,IDragHandler {
	public float sensitivity = 2; 
	private Vector2 initialpos;
	public Animator Playeranimator;
	void Start () {
		if (gameObject.GetComponent<EventTrigger> () == null)
			gameObject.AddComponent<EventTrigger> ();
	}
	public void OnPointerDown(PointerEventData eventData)
	{
		initialpos = eventData.position;
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (initialpos.y - sensitivity > eventData.position.y) {
			StartCoroutine (PlayerAnimation ("Slide"));
		} 
		else if (initialpos.y + sensitivity < eventData.position.y) {
			StartCoroutine (PlayerAnimation ("Jump"));
		}

	}


	IEnumerator PlayerAnimation(string state){
		Playeranimator.SetBool(state,true);
		yield return new WaitForSeconds(0.25f);
		Playeranimator.SetBool (state, false);
	}
		

}
