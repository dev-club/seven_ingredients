//Seven Ingredients: Go

package main

import "fmt"



//VARIABLES

var a int = 10
var b string = "some words"
var c bool = false

//CONDITIONALS

func sqrt(x float64) string {
    if x < 0 {
        return sqrt(-x) + "i"
    }
    return fmt.Sprint(math.Sqrt(x))
}

//SETS

var x [2]string
x[0] = "Hello"
x[1] = "World"
    
    
//LOOPS

func looper () int {
 sum := 0
    for i := 0; i < 10; i++ {
        sum += i
    }
 return sum
}

func alooper () string {
  d:=""
    for i := 0; i < len(p); i++ {
        d+=("p[%d] == %d\n", i, p[i])
    }
  return d
}
//FUNCTIONS

func ichi() int {
	var d int = 10
	return d
	}
	
func main() {
	fmt.Println( ichi() )
}
