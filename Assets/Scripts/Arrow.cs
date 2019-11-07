using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed, minimumX;
	public bool isLevel3 = false;
	public bool isLevel5 = false;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= minimumX)
        {
            Destroy(gameObject);
        }
		if(!isLevel3 && Player.level > 2)
		{
			StartCoroutine("FistSpeedUp");
			isLevel3=true;
		}
		if(!isLevel3 && Player.level > 5)
		{
			StartCoroutine("SecondSpeedUp");
			isLevel5=true;
		}
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player.lives = Player.lives - 1;
            Destroy(gameObject);
        }
        else if (other.CompareTag("Lightningbolt"))
        {
            Destroy(gameObject);
        }
    }
	
	IEnumerator FistSpeedUp () 
	{
        yield return new WaitForSeconds(1.5f);
		speed+= 1.5f;

	}
	
	IEnumerator SecondSpeedUp () 
	{
        yield return new WaitForSeconds(1.5f);
		speed+= 2f;
	}
}
