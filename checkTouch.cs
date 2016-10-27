using UnityEngine;
using System.Collections;

public class CheckTouch : MonoBehaviour {

    public GameObject item;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			if (touch.tapCount==1 && touch.phase==TouchPhase.Began)
			{
				Debug.Log("touch started");
			}
			if (touch.tapCount==1 && touch.phase==TouchPhase.Ended)
			{
                // check if you touched the item Gameobject
                if (Physics2D.OverlapPoint(touch2dPoint) == item.GetComponent<Collider2D>())
                    {
                        Debug.Log(" you touched item");
                    }
				Debug.Log("touch ended ");
			}
			if (touch.tapCount> 0 && touch.phase==TouchPhase.Moved)
			{
				Debug.Log(" touch is moving ");
			}
		}
	}

}
