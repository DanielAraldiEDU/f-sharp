let helloWorld () = printfn "Hello World!"

let sum numberOne numberTwo = numberOne + numberTwo

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
    printfn "The result is %i" (sum value otherValue)

    0
