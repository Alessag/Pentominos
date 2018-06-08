using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ButtonCambiarPanel : MonoBehaviour, IPointerClickHandler {

	public GameObject panel;

	public void OnPointerClick(PointerEventData p){
		transform.parent.gameObject.SetActive(false);
		panel.SetActive(true);
	}
	
}
