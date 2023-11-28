using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour {

	//public void PlayGame () {
	//	SceneManager.LoadScene (2);
	//}

	public void PlayGame () {
		SceneManager.LoadScene (2);
	}

	public void MainMenu () {
		SceneManager.LoadScene (1);
	}

	//Below here are track selection buttons

	public void Track01 () {
		SceneManager.LoadScene (3);
	}

	public void Track02 () {
		SceneManager.LoadScene (4);
	}

    public void CreditScene()
    {
        SceneManager.LoadScene(5);
    }

}
