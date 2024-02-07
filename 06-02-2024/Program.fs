let helloWorld () = printfn "Hello World!"

let sum numberOne numberTwo = numberOne + numberTwo

let square (size: int) = size * size

// Create an array with 10 values and it make a map
// using the square function, returning the sum between
// all numbers in array.
// The "|>" expression is used to pass values to execute
// in the others functions
let sumSquares: int = [ 1..10 ] |> List.map square |> List.sum

let moduleWithoutSignal (number: int) =
    if number < 0 then number * -1 else number

let mediaBetweenTwoNumbers numberOne numberTwo = (numberOne + numberTwo) / 2

[<EntryPoint>]
let main args =
    // Call the helloWord function
    helloWorld ()

    // Force type integer to value constant
    let value: int = 10
    let otherValue: int = value + 4

    // The "%i" print an integer value in printfn
    // The sum function has priority over and it's
    // been called first
    printfn "The result is: %i" (sum value otherValue)
    printfn "Sum all squares is: %i" sumSquares
    printfn "Value without signal: %i" (moduleWithoutSignal -10)
    printfn "Media between these two numbers is: %i" (mediaBetweenTwoNumbers value otherValue)

    0
