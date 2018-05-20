using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

   [SerializeField] private Text endowmentLabel;
   [SerializeField] private Text studentCountLabel;

    int totalEndowment; 

    float spendingPerStudent;

    float tuition;

    int numStudents;

    int numAlumni;

	// Use this for initialization
	void Start () {
		
	}

    private void FixedUpdate()
    {
        endowmentLabel.text = "$" + totalEndowment.ToString();

        studentCountLabel.text = numStudents.ToString();
    }

    public void AskAlumniForMoney() {
        
    }
}
