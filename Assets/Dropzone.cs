using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dropzone : MonoBehaviour , IDropHandler , IPointerEnterHandler,IPointerExitHandler{




	public AudioClip [] audios;
	public GameObject patlama;




	//public Dragable.Slot typeOfItem = Dragable.Slot.WEAPON;
	public Fark.Slot typeOfItem;

	public void OnPointerEnter(PointerEventData eventData){
	
		Debug.Log ("Onpointer enter");
	
	
	}

	public void OnPointerExit(PointerEventData eventData){

		Debug.Log ("Onpointer exit");


	}

	public void OnDrop(PointerEventData eventData){
	
		Debug.Log ( eventData.pointerDrag.name+  "was drop on " + gameObject.name );
		 Dragable d= eventData.pointerDrag.GetComponent<Dragable> ();


		Fark f = eventData.pointerDrag.GetComponent<Fark> ();

		if (d != null) {

			if (typeOfItem == f.nesnetip || typeOfItem == Fark.Slot.DEFAULT) {

				d.parentToReturnTo = this.transform;

					
					
			}else
				animasyonoynat (); 
				
				

		}
	
	}

	public void animasyonoynat()  {

		GameObject a1 = (GameObject)Instantiate (patlama);

		a1.transform.parent.transform.position = transform.position;


	}


}
