using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Dragable : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler {

	public Transform parentToReturnTo=null;

	//public enum Slot {WEAPON , HEAD , CHEST ,LEGS , FEET};

	//public Slot typeOfItem = Slot.WEAPON;

	public void OnBeginDrag(PointerEventData eventData){
	
		Debug.Log ("OnBeginDrag");	

		parentToReturnTo = this.transform.parent;
		this.transform.SetParent (this.transform.parent.parent);   
	
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData){



		this.transform.position = eventData.position; 

	}

	public void OnEndDrag(PointerEventData eventData){

		Debug.Log ("OnEndDrag");

		this.transform.SetParent (parentToReturnTo);
		GetComponent<CanvasGroup> ().blocksRaycasts = true;



	}


}
