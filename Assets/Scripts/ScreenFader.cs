using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour {

	public Image fadeImage;
	public float fadeSpeed;
	public float delay;

	void Start(){
		fadeImage.color = Color.black;
	}
	void Update(){
		float factor = Mathf.Clamp ((0.01f * fadeSpeed) * (Time.time - delay), 0f, 255f);
		fadeImage.color = Color.Lerp (fadeImage.color, Color.clear, factor);
		}
}
