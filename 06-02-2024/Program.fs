let helloWorld () = printfn "Hello World!"

let sum numberOne numberTwo = numberOne + numberTwo

let square (size: int) = size * size

// Create an array with 10 values and it make a map
// using the square function, returning the sum between
// all numbers in array.
// The "|>" expression is used to pass values to execute
// in the others functions
let sumSquares: int = [ 1..10 ] |> List.map square |> List.sum

let moduleWithoutSignal (number: int) = if number < 0 then -number else number

let mediaBetweenTwoNumbers numberOne numberTwo = (numberOne + numberTwo) / 2

let lessValueBetweenThreeNumbers numberOne numberTwo numberThree =
    if numberOne < numberTwo && numberTwo < numberThree then
        numberOne
    elif numberTwo < numberOne && numberTwo < numberThree then
        numberTwo
    else
        numberThree

let showTriangleType basis left right =
    if basis = left && basis = right then "Equilateral Triangle"
    elif left = right then "Isosceles Triangle"
    else "Stepped Triangle"

[<EntryPoint>]
let main args =
    // Call the helloWorld function
    helloWorld ()

    // Force type integer to value constant
    let value: int = 10
    let otherValue: int = value + 4
    let anotherValue: int = -10

    // The "%i" print an integer value in printfn.
    // The sum function has priority over and it's
    // be called first
    printfn "The result is: %i" (sum value otherValue)
    printfn "Sum all squares is: %i" sumSquares
    printfn "Value without signal: %i" (moduleWithoutSignal anotherValue)
    printfn "Media between these two numbers is: %i" (mediaBetweenTwoNumbers value otherValue)
    printfn "Show less value between three numbers is: %i" (lessValueBetweenThreeNumbers value otherValue anotherValue)
    // The "%s" print an string value in printfn
    printfn "Show which triangle type is: %s" (showTriangleType value value value)

    0
