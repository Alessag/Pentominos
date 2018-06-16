using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LoadingScene : MonoBehaviour , IPointerClickHandler{
	public string nameScene;
	public void OnPointerClick(PointerEventData p){
		SceneManager.LoadScene(nameScene);
	}
}
