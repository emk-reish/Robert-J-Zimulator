using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonationsBehavior : MonoBehaviour {

    float donationRate;

    float averageAmount;

    int numAlumni;

	float DonationPerCycle
    {
        get
        {
            return donationRate * averageAmount * numAlumni;
        }
    }
}
