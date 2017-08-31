using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	private int count;

	public Text win;
	public Text score;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		setCountText ();
		win.text = "";
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement*speed);
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count++;
			setCountText();
		}
	}
	void setCountText()
	{
		score.text = "Score: " + count.ToString();
		if (count >= 15) 
		{
			win.text = "You Win!";
			this.gameObject.SetActive(false);
		}
	}
}