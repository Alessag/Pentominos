using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RotateButton : MonoBehaviour, IPointerClickHandler 
{
	public static RotateButton instance;
	public bool selectP = false;
	public PentominoFigure[] vec;

	 private void Start() {
		instance = this;
	}

	// Use this for initialization
	public void OnPointerClick(PointerEventData p){
		if(selectP)
		
		for(int i=0; i<12; i++){
			if(vec[i].select ) {
				vec[i].Rotar();
				

			}
		}
		}
	

	public bool Comprobar(){
		for(int i=0; i<12; i++){
			if(vec[i].select) {
				
				return true;
				

			}
		}

		
		return false;
	}
	
}
