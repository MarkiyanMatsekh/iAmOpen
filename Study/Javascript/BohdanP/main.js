// in general - very good, especially as for javascript-beginner. The most of notes are minor. The main tasks are made greatly

(function() { // we don't let the garbage outside =)

window.onload = function(){	
	//alert("37: " + isPrime(37));
	addBubbleSortToArray();
	
	//useCar();
	
	useCircle();
}

//Prime
// function isPrime(value){
	// if (value > 1){
		// var i;
		// for (i = 2; i < value; i++){
			// if (value % i == 0){
				// return false;
			// }
		// }
		
		// return true;
	// }
	// return false;
// }

//Sort function
function addBubbleSortToArray(){
	Array.prototype.bubbleSort = function (isBigger){ // does this delegate really tells who's Bigger? it seems like he only _compares_ the values, without specific knowledge of them
		for (var i = this.length; i > 0; i--){
			for (var j = 0; j < i - 1; j++){
				if (isBigger(this[j], this[j+1])){ 
					var c = this[j];
					this[j] = this[j+1];
					this[j + 1] = c;
				}
			}
		}
	}
}

// function useArr(){
	// var arr = new Array();
	// for (var i = 0; i < 10; i++){
		// arr[i] = Math.floor(Math.random()*10);
	// }
	
	// alert("Random array: " + arr);
	// arr.bubbleSort(function(a, b){ return a > b;})
	// alert("Sortd array: " + arr);
// };

//Car
function Car(carModel, carYear){
	this.model = carModel;
	this.year = carYear;
};

function overrideCarToString(){
	Car.prototype.toString = function(){
		return this.model + ", " + this.year + "\n";// adding the newline at the end of textual representation of a car doesn't sound like a good idea. To achieve showing array on different lines use [].join('\n');
	}
};

function useCar(){
	overrideCarToString(); // better do this right after 'Car' definition, if you want all Cars to behave the same way

	var carArr = new Array(); // === var carArr = [new Car("Audi A4", 2001), new Car("Audi A7", 2010),new Car("Porshe 911", 2001) ...];
	carArr[0] = new Car("Audi A4", 2001);
	carArr[1] = new Car("Audi A7", 2010);
	carArr[2] = new Car("Porshe 911", 2001);
	carArr[3] = new Car("Toyota camery", 1999);
	carArr[4] = new Car("Ferari 599", 2011);
	carArr[5] = new Car("Mazda RX7", 2005);
	carArr[6] = new Car("Renault Duster", 2002);
	carArr[7] = new Car("Audi A6", 1995);
	
	alert("Array: \n" + carArr);
	carArr.bubbleSort(function(a, b){ return a.year > b.year;});
	alert("Sorted array: \n" + carArr);
};

//Circle clossure
function Circle(radius, color){
	var _radius = radius;
	var _color = color;
	
	this.getRadius = function(){ return _radius;} // it's not C#, better put an extra semilicon on each line=)
	this.setRadius = function(radius){_radius = radius;}
	this.getColor = function(){ return _color;}
	this.setColor = function(color){_color = color;}
};

function overrideCircleToString(){
	Circle.prototype.toString = function(){
		return this.getRadius() + ", " + this.getColor();
	}
};

function useCircle(){
	overrideCircleToString();

	var circ = new Circle(5, "Red");
	
	alert(circ);
	alert(circ.getRadius());
}

})();