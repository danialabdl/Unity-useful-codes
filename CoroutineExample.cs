using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoroutineExample : MonoBehaviour
{
    /*in this example a simple code is a simple code runs every second.
     * this is a simple coroutine
     */

	// Use this for initialization
	void Start () {
		StartCoroutine ("DoSomething");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator DoSomething()
	{
		Debug.Log (" did Something...");
		yield return new WaitForSeconds (1);
        StartCoroutine("DoSomething");
	}
}
