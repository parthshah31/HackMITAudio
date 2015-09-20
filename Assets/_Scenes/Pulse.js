// Transforms to act as start and end markers for the journey.
public var begin = 0;
public var end = 4;
public var beat = 0.65;

// Time when the movement started.
private var startTime: float;	

function Start() {
	// Keep a note of the time the movement started.
	startTime = Time.time;
	
	//transform local scale
	transform.localScale = new Vector3(begin,begin,begin);
}

// Follows the target position like with a spring
function Update () {
	var change = (Time.time - startTime);
	var frac = (change/beat)*(end - begin);
	
	if(change < beat){
		val = begin + frac*(end-begin);
		transform.localScale = new Vector3(val,val,val);
	}
	else{
		startTime = Time.time;
	}
}