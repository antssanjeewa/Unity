var CarControl : GameObject;
var CarAIControl : GameObject;

function Start () {
	CarControl.GetComponent("CarUserControl").enabled = true;
	CarAIControl.GetComponent("CarAIControl").enabled = true;
}
