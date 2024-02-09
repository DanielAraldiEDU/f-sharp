let tuple = (1, 2)
let otherTuple = (1, "A")
let anotherTuple = (tuple, otherTuple)
let tupleWithThreeValues = (1, 2, 3)

// Get first element of tuple
printfn "First element of tuple: %i" (fst tuple)
// Get second element of tuple
printfn "Second element of tuple: %s" (snd otherTuple)

let getThirdValue tupleValue =
    match tupleValue with
    // If the tuple has exactly three values it executes this:
    | (_, _, third) -> printfn "Third element of tuple: %i" third

getThirdValue tupleWithThreeValues

let fibonacci values =
    match values with
    | (previous, next) -> (next, previous + next)

let result = (0, 1) |> fibonacci |> fibonacci |> fibonacci |> fibonacci |> fibonacci
printfn "Result's previous and next value of fibonacci: %A" result
