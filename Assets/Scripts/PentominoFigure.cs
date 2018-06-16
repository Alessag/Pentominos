using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentominoFigure : MonoBehaviour {

	Vector2 pos;
	public bool select = false;
	// Use this for initialization
	public void Rotar () {
		
		//print(transform.childCount);
		for(int i=0; i<transform.childCount; i++){
			Transform hijo = transform.GetChild(i);
			pos = new Vector2(hijo.localPosition.x*Mathf.Cos(Mathf.Deg2Rad * 90f) - hijo.localPosition.y*Mathf.Sin(Mathf.Deg2Rad * 90f) , hijo.localPosition.x*Mathf.Sin(Mathf.Deg2Rad * 90f) + hijo.localPosition.y*Mathf.Cos(Mathf.Deg2Rad * 90f) );
			transform.GetChild(i).localPosition = pos;
		}
	}


	void OnMouseUp(){


		if(!RotateButton.instance.Comprobar()){
			select = true;
			RotateButton.instance.selectP = true;
		}

		else if(select)
			select = !select;
	}

	private void OnMouseDrag() {
		if(select){
			transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0,0,10);
		}

	}

}
