using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

	public void load(int scene_index){
		SceneManager.LoadScene (scene_index);
	}
}
