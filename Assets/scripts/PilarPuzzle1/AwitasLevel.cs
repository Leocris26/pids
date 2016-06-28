using UnityEngine;
using System.Collections;

public class AwitasLevel : MonoBehaviour {

	// Use this for initialization
	public Pilar[] pilares;
	bool solved;

	public void tryToSolve(){
		bool tempSolved = true;
		if (this.gameObject.name == "muro1"){
			for (int i = 0; i < 4; i++) {
				if (!pilares [i].correctState ()) {
					tempSolved = false;
					break;
				}
			}
		}
		else{
			for (int i = 0; i < 3; i++) {
				if (!pilares [i].correctState ()) {
					tempSolved = false;
					break;
				}
			}
		}
			
		if (tempSolved) {
			this.solve ();
		}
	}
	void solve(){
		this.solved = true;
		if (this.gameObject.name == "muro1"){
			for (int i = 0; i < 4; i++) {
				pilares [i].tag = "Untagged";
			}
		}
		else {
			for (int i = 0; i < 3; i++) {
				pilares [i].tag = "Untagged";
			}
		}
		Destroy (this.gameObject);


	}

	public bool isSolved(){
		return solved;
	}



}
