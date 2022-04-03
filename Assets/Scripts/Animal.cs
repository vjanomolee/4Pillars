using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Animal : MonoBehaviour
{
	public string Name;
	public string Height;
	public string Age;
	public GameObject ui_SpeechBubble;
	public TMP_Text speechBubbleTMP;
	public string speechBubbleText;
	public AudioClip wav_Animal;
	public AnimationClip anim_Die_Animal;
	public AnimationClip anim_Idle_Animal;

	public string targetTag = "TagOfTarget";
	
	public int maxHealth = 100;
	public int currentHealth;
	public GameObject ui_HealthBar;
	public Slider slider;
	public Gradient gradient;
	public Image fill;
	public TMP_Text  cHealth;

	public int damageAmount;

	void Start()
	{
		currentHealth = maxHealth;
		SetMaxHealth(maxHealth);
	}

    private void Update()
    {
		
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
	public void OnMouseDown()
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
		slider.maxValue = health;
		slider.value = health;

		fill.color = gradient.Evaluate(1f);
	}
	public void SetHealth(int health)
	{
		slider.value = health;
		fill.color = gradient.Evaluate(slider.normalizedValue);
		cHealth.SetText(currentHealth.ToString());
	}
	public void TakeDamage(int damageAmount)
	{
		currentHealth -= damageAmount;
		SetHealth(currentHealth);
	}


    public virtual void MakeSoundAndUI()
	{
		AudioSource audioS = GetComponent<AudioSource>();
		audioS.clip = wav_Animal;
		audioS.Play();
		speechBubbleTMP.SetText(speechBubbleText);
		ui_SpeechBubble.SetActive(true); // enable UI speech bubble of that animals sound
	}
	public virtual void Die() // play hurt animation clip Needt to fix animation code
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
}
