using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Animal : MonoBehaviour
{
	string targetTag = "Animal"; //make public if you want to change the tag to something besides Animal
	public GameObject expAbstraction;
	public GameObject expEncapsulation;
	public GameObject expPolymorphism;
	public GameObject expInheritance;
	public GameObject ui_SpeechBubble;
	
	[SerializeField]
	private TMP_Text speechBubbleTMP;
	public TMP_Text SpeechBubbleTMP
	{
		get
		{
			return speechBubbleTMP;
		}
		set
		{
			speechBubbleTMP = value;
		}
	}

	//public string speechBubbleText;
	public AudioClip wav_Animal;
	public AnimationClip anim_Die_Animal;
	public AnimationClip anim_Idle_Animal;
	public int maxHealth = 100;
	private int currentHealth;
	public GameObject ui_HealthBar;
	public Slider hBarSlider;
	public Gradient hBarGradient;
	public Image hBarFill;
	public TMP_Text cHealth;
	public int damageAmount;

	void Start()
	{
		currentHealth = maxHealth;
		SetMaxHealth(maxHealth);
	}

    public void OnMouseEnter()
	{
		if (CompareTag(targetTag))
		{
			ui_HealthBar.SetActive(true);
		}
		if (!CompareTag(targetTag))
		{
			ui_HealthBar.SetActive(false);
			ui_SpeechBubble.SetActive(false);
		}
	}
	public void OnMouseExit()
	{
		if (CompareTag(targetTag))
		{
			ui_SpeechBubble.SetActive(false);
			ui_HealthBar.SetActive(false);

			if (currentHealth > 0)
			{
				ChillState();
			}
		}
	}
	public virtual void OnMouseDown()
	{
		if (CompareTag(targetTag))
		{
			MakeSoundAndUI();
			TakeDamage(damageAmount);
			if (currentHealth <= 0)
			{
				Die();
			}
		}
	}
	public void SetMaxHealth(int health)
	{
		hBarSlider.maxValue = health;
		hBarSlider.value = health;
		hBarFill.color = hBarGradient.Evaluate(1f);
	}
	public void SetHealth(int health)
	{
		hBarSlider.value = health;
		hBarFill.color = hBarGradient.Evaluate(hBarSlider.normalizedValue);
		cHealth.SetText(currentHealth.ToString());
	}
	public virtual void TakeDamage(int damageAmount)
	{
		currentHealth -= damageAmount;
		SetHealth(currentHealth);
	}
    public virtual void MakeSoundAndUI()
	{
		AudioSource audioS = GetComponent<AudioSource>();
		audioS.clip = wav_Animal;
		audioS.Play();
		ui_SpeechBubble.SetActive(true);
	}
	public virtual void Die() 
	{
		Animation anim;
		anim = GetComponent<Animation>();
		anim.clip = anim_Die_Animal;
		anim.Play();
	}
	public virtual void ChillState()
	{
		Animation anim;
		anim = GetComponent<Animation>();
		anim.clip = anim_Idle_Animal;
		anim.Play();
	}

	public virtual void Revive()
    {
		currentHealth = maxHealth;
    }

	public virtual void ExplanationInheritance()
	{
		expAbstraction.SetActive(false);
		expEncapsulation.SetActive(false); 
		expPolymorphism.SetActive(false);
		expInheritance.SetActive(true); 
	}
	
	public void ExplanationPolymorphism()
	{

		expAbstraction.SetActive(false);
		expEncapsulation.SetActive(false);  
		expPolymorphism.SetActive(true);
		expInheritance.SetActive(false); 
	} 

    public void ExplanationEncapsulation()
	{
		expAbstraction.SetActive(false);
		expEncapsulation.SetActive(true);  
		expPolymorphism.SetActive(false);
		expInheritance.SetActive(false); 
	}

	public void ExplanationAbstraction()
	{
		expAbstraction.SetActive(true);
		expEncapsulation.SetActive(false);  
		expPolymorphism.SetActive(false);
		expInheritance.SetActive(false);
	}
}