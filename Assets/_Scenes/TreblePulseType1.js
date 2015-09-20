import System.Math;

private var begin = 0;
private var end = 5;
private var beat = 5;

// Time when the movement started.
private var startTime: float;	

function Start() {
	// Keep a note of the time the movement started.
	startTime = Time.time;
	
	//transform local scale
	transform.localScale = new Vector3(5,begin,5);
}

// Follows the target position like with a spring
function Update () {
	var change = (Time.time - startTime);
	var frac = (change/beat)*(end - begin);
	var frac2 = Abs(0.5-(frac/(end-begin)));
	
	if(change < beat){
		val = begin + 2*frac2*(end-begin);
		transform.localScale = new Vector3(5,val,5);
	}
	else{
		startTime = Time.time;
	}
}