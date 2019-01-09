using UnityEngine;
using System.Collections;

public class CarChoise : MonoBehaviour {

	public GameObject SedanBody;
	public GameObject TaxiBody;
	public GameObject KeliBody;
	public GameObject HatchBody;
	public int CarType;
	
	void Start () {
		CarType = CarSelect.CarNumber;
		if(CarType == 0){
			SedanBody.SetActive(true);
		}
		if(CarType == 1){
			TaxiBody.SetActive(true);
		}
		if(CarType == 2){
			KeliBody.SetActive(true);
		}
		if(CarType == 3){
			HatchBody.SetActive(true);
		}
	}
	
	
}
