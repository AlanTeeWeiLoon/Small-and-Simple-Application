var mySeconds;
var intervalHandle;

function reset(){
	mySeconds = 0;
	clearInterval(intervalHandle);
	console.log("123")
	document.getElementById("timeMinute").style.display="block";
    document.getElementById("timeMinute").value=0;	
    document.getElementById("time").innerHTML="0:00";
    
	
	
	
}
function tick(){
	var timeDisplay=document.getElementById("time");
	
	var min=Math.floor(mySeconds/60);
	var sec=mySeconds-(min*60);
	
	if (sec < 10) {
		sec="0"+sec;
	}
	
	var message=min.toString()+":"+sec;
	
	timeDisplay.innerHTML=message;
	
	if(mySeconds===0){
		alert("Done");
		clearInterval(intervalHandle);
		reset();
	}
	mySeconds--;
	
	
}
function startCounter(){
	var myInput=document.getElementById("timeMinute").value;
	if (isNaN(myInput)){
		alert("Type a valid number please");
		return;
	}
	mySeconds=myInput*60;
	
	intervalHandle=setInterval(tick, 1000);
	
	document.getElementById("timeMinute").style.display="none";
	
	
}


