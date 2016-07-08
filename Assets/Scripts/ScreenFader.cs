using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour {

	public Image fadeImage;
	public float fadeSpeed = 0.25f;

	void Start(){
		fadeImage.color = Color.black;
	}
	void Update(){
		fadeImage.color = Color.Lerp (fadeImage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}
}
