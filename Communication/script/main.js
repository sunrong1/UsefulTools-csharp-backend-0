
//document.querySelector("html").onclick = function () {
//	alert("Ouch!Stop Poking me!");
//}
document.querySelector("#ShowImage").onclick = function () {
	var myImage = document.querySelector("#ShowImage");
	var mySrc = myImage.getAttribute('src');

	if (mySrc === 'images/eye_2.png') {
		myImage.setAttribute('src', 'images/firefox-icon.png');
	}
	else {
		myImage.setAttribute('src','images/eye_2.png');
	}
}

var myButton = document.querySelector("button");
var myHeading = document.querySelector('h1');
function setUserName() {
	var myName = prompt('Please Input your name.');
	localStorage.setItem('name', myName);
	myHeading.textContent = 'You are Cool,' + myName;
}

if (!localStorage.getItem('name')) {
	setUserName();
} else {
	var storedName = localStorage.getItem('name');
	myHeading.textContent = 'You are Cool,' + storedName;
}

myButton.onclick = function () {
	setUserName();
}