using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	//public GameObject MainMenuMusic;

	public void Start(){
		//MainMenuMusic = GameObject.Find ("MainMenuMusic");
		//DontDestroyOnLoad (MainMenuMusic);
	}
	/*public void changeScene( string sceneToChangeTo ){
		if (sceneToChangeTo == "GameTest") {
						//MainMenuMusic.audio.Stop ();
				}
		Application.LoadLevel (sceneToChangeTo);

	}*/

	public void changeScene( int sceneToChangeTo ){
		Application.LoadLevel (sceneToChangeTo);
	}


}