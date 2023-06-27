using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HPbar{
	
	private float maxHP;
	private Image bar;

	public HPbar(Image bar, int maxHP){
		this.bar = bar;
		this.maxHP = maxHP;
	}

	public void updateHPbar(int currentHP){		
		bar.fillAmount = (float) currentHP / maxHP;
	}
}
