using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	public Gameover gameover;
	public HealthBar healthBar;
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}
	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Enemy")
		{
			TakeDamage(5);
			if (currentHealth <= 0)
			{
				Destroy(gameObject);
				gameover.Game_over();

			}
		}
	}
}
