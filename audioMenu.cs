using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class audioMenu : MonoBehaviour {

	private GameObject[] bgm;
	private GameObject[] sfx;
	public Text bgmtxt;
	public Text sfxtxt;

	public void Start(){
		bgm = GameObject.FindGameObjectsWithTag("BGM");
		sfx = GameObject.FindGameObjectsWithTag("SFX");
	}

	void setVolume(GameObject[] temp, float volume){
		foreach(GameObject gameo in temp){
			gameo.GetComponent<AudioSource> ().volume = volume/5f;
		}
	}

	public void BGMUp(){
		float temp = float.Parse(bgmtxt.text);
		temp++;
		if (temp > 5)
			temp = 5;
		setVolume (bgm, temp);
		bgmtxt.text = ""+temp;
	}

	public void BGMDown(){
		float temp = float.Parse(bgmtxt.text);
		temp--;
		if (temp < 0)
			temp = 0;
		setVolume (bgm, temp);
		bgmtxt.text = ""+temp;
	}

	public void SFXUp(){
		float temp = float.Parse(sfxtxt.text);
		temp++;
		if (temp > 5)
			temp = 5;
		setVolume (sfx, temp);
		sfxtxt.text = ""+temp;
	}

	public void SFXDown(){
		float temp = float.Parse(sfxtxt.text);
		temp--;
		if (temp < 0)
			temp = 0;
		setVolume (sfx, temp);
		sfxtxt.text = ""+temp;
	}
}
