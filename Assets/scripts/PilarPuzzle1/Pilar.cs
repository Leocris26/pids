using UnityEngine;
using System.Collections;

public class Pilar : MonoBehaviour {

	// Use this for initialization
	public AwitasLevel awT;
	public int answerState;
	int state;
	void Start () {
		this.state=0;
	}
	

	public void handle(){
		
		this.initRotation ();
		if (!awT.isSolved ()) {
			if (this.correctState ()) {
				awT.tryToSolve ();
			}
		}
	}


	public bool correctState(){
		return state == answerState;
	}

	public bool correctState(int tryState){
			return this.state == tryState;
	}

	void initRotation(){
		this.transform.Rotate (0,90,0);	
		state = (state + 1) % 4;

	}

}
