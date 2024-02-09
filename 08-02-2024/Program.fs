// Trabalho M2 - Daniel Sansão Araldi - Programação Funcional II

// 1) Faça uma função que recebe uma lista e retorne o produto dos valores
// ímpares.
let rec isOdd number =
    match number with
    | 0 -> false
    | 1 -> true
    | _ -> isOdd (number - 2)

let rec productOfOddValues numbers =
    match numbers with
    | [] -> 1
    | head :: tail when isOdd head -> head * productOfOddValues tail
    | _ :: tail -> productOfOddValues tail
// --------------------------------------------------------------------------

// 2) Faça uma função que receba 2 valores, caso sejam iguais, multiplique os
// dois, caso sejam diferentes, faça o primeiro valor elevado ao segundo. Não
// pode utilizar o operador de potência (deve ser feita uma sequência de
// multiplicações, 23 = 2 * 2 * 2).

let rec multiply number times =
    match times with
    | 0 -> 1
    | _ -> number * multiply number (times - 1)

let powOrMultiply number times =
    match (number, times) with
    | (num, tim) when num = tim ->
        let result = num * tim
        printfn "(Valores Iguais) A multiplicação entre os dois valores é: %d" result
    | (num, tim) ->
        let result = multiply num tim
        printfn "(Valores são Diferentes) O primeiro valor elevado pelo segundo é: %d" result
// --------------------------------------------------------------------------

// 3) Faça uma função que recebe um número e retorna se ele é primo ou não.

let rec isPrime number =
    match number with
    | 1 -> false
    | 2 -> true
    | _ when number % 2 = 0 -> false
    | _ -> findNextPrimes number 3

and findNextPrimes number divider =
    match number with
    | _ when divider * divider > number -> true
    | _ when number % divider = 0 -> false
    | _ -> findNextPrimes number (divider + 2)
// --------------------------------------------------------------------------

// 4) Faça uma função que recebe uma lista e retorna a soma dos valores primos
// (utilizar a função da questão 3).

let rec sumPrimes numbers =
    match numbers with
    | [] -> 0
    | head :: tail ->
        match isPrime head with
        | true -> head + sumPrimes tail
        | false -> sumPrimes tail
// --------------------------------------------------------------------------

[<EntryPoint>]
let main args =
    let numbers = [ 1; 2; 3; 4; 5; 6; 7; 8; 9; 10 ]
    let productOdds = productOfOddValues numbers
    printfn "Resultado do produto dos valores ímpares é: %i" productOdds
    printf "\n"

    powOrMultiply 2 4
    powOrMultiply 5 5

    printfn "\nNúmero 13 é primo? %b" (isPrime 13)
    printfn "Número 15 é primo? %b" (isPrime 15)
    printfn "Número 20 é primo? %b" (isPrime 20)
    printfn "Número 23 é primo? %b" (isPrime 23)

    let primeNumbers = [ 2; 3; 5; 7; 11; 13; 17; 19; 23; 29 ]
    printfn "\nA soma dos primos é: %i" (sumPrimes primeNumbers)

    0
