using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Button_exit : MonoBehaviour, IPointerClickHandler {
	public void OnPointerClick(PointerEventData p){
		Application.Quit();
	}
	
}
