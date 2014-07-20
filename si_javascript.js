//7 ingredients: Javascript

//VARIABLES
var x=10;
var y="words, words, words";
var z=false;

//CONDITIONALS
if (x>10){
    console.log(x);
}else{
    console.log(y);
}

//FUNCTIONS
var hr=function(n){
    var n=n||7;
    var d="";
    for (var i=0;i<n;i++){
        d+="-";
    }
    console.log(d);
}

hr();

//SETS
var a=['Hamlet','The Merchant of Venice','The Taming of the Shrew'];
var b={"food":"cake","not_food":"not cake"};
console.log(a[0]);
console.log(b['food']);
a.push('The Scottish Play');
console.log(a[3]);
hr();

//LOOPS
for (var i=0;i<a.length;i++){
    console.log(a[i]);
}
hr(3);

for (var key in b){
    console.log(key);
    console.log(b[key]);
}
hr();

//DOCUMENTATION
console.log( "let's be honest: http://www.w3schools.com/js/");
hr();

//EXECUTION
console.log( "browser dev tools console tab, or javascript script tags in html documents.");
hr();
