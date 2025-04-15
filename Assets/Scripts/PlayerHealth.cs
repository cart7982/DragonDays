using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
	public int currentHealth;
	public int maxHealth;

	public TMP_Text healthText;
	public Animator healthTextAnim;

	private Vector2 originalPos;

	//Start sets the initial text on the UI.
	private void Start()
	{
		healthText.text = "HP: " + currentHealth + " / " + maxHealth;
		//originalpos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
		originalPos = gameObject.transform.position;
	}

	//UI display for player health.
	public void ChangeHealth(int amount)
	{
		currentHealth += amount;
		healthTextAnim.Play("TextUpdate");
		healthText.text = "HP: " + currentHealth + " / " + maxHealth;
		if(currentHealth <= 0)
		{
			//gameObject.SetActive(false);
            //UnityEditor.EditorApplication.isPlaying = false;
			resetPlayer();
		}
	}

	public void resetPlayer()
	{
		currentHealth = 10;
		healthTextAnim.Play("TextUpdate");
		healthText.text = "HP: " + currentHealth + " / " + maxHealth;
		gameObject.transform.position = originalPos;
	}
}
