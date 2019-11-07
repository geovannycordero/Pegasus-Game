using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
	public GameObject pegasus;
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine("AttackAnimation");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	IEnumerator AttackAnimation () 
	{
        yield return new WaitForSeconds(0.17f);
		Destroy(gameObject);
	}
}
