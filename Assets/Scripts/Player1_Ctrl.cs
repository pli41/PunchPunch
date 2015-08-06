using UnityEngine;
using System.Collections;

public class Player1_Ctrl : MonoBehaviour {

	public Animator left_anim;
	public Animator right_anim;





	int leftIdlePunchHash = Animator.StringToHash("Left_Idle_Punch");
	int leftPunchIdleHash = Animator.StringToHash("Left_Punch_Idle");


	int rightIdlePunchHash = Animator.StringToHash("Right_Idle_Punch");
	int rightPunchIdleHash = Animator.StringToHash("Right_Punch_Idle");
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//Left Hand
		if(Input.GetKeyDown (KeyCode.Z) && left_anim.GetCurrentAnimatorStateInfo(0).IsName("Left_Idle")){
			left_anim.ResetTrigger("Left_Punch_Idle");
			left_anim.SetTrigger(leftIdlePunchHash);
		}

		//Right Hand
		if(Input.GetKeyDown (KeyCode.X) && right_anim.GetCurrentAnimatorStateInfo(0).IsName("Right_Idle")){
			Debug.Log("123");
			right_anim.ResetTrigger("Right_Punch_Idle");
			right_anim.SetTrigger(rightIdlePunchHash);

		}


		//Reset both hands
		if(left_anim.GetCurrentAnimatorStateInfo(0).IsName("Left_Punch")){
			left_anim.SetTrigger(leftPunchIdleHash);
		}
		if(right_anim.GetCurrentAnimatorStateInfo(0).IsName("Right_Punch")){
			right_anim.SetTrigger(rightPunchIdleHash);
		}

	}
}
