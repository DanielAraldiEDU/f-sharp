// Trabalho M2 - Daniel Sansão Araldi - Programação Funcional I

// 1) Faça uma função que receba 2 valores e retorne a divisão do maior pelo
// menor.

let handleDivideBiggestBySmallest numberOne numberTwo =
    if numberOne >= numberTwo then
        numberOne / numberTwo
    else
        numberTwo / numberOne
// --------------------------------------------------------------------------

// 2) Faça uma função que receba 3 valores e escreva que tipo de triângulo eles
// formam:
//  2.1) Não forma um triângulo - Uma das medidas é maior que a soma das outras
//  duas;
//  2.2) Equilátero - Todos os lados iguais;
//  2.3) Isósceles - Dois lados iguais;
//  2.4) Escaleno - Todos os lados diferentes.

let handleTriangleType numberOne numberTwo numberThree =
    if
        numberOne >= (numberTwo + numberThree)
        || numberTwo >= (numberOne + numberThree)
        || numberThree >= (numberOne + numberTwo)
    then
        printfn "Resultado: Não forma um triângulo"
    elif numberOne = numberTwo && numberOne = numberThree then
        printfn "Resultado: Triângulo Equilátero"
    elif numberOne = numberTwo || numberTwo = numberThree || numberOne = numberThree then
        printfn "Resultado: Triângulo Isósceles"
    else
        printfn "Resultado: Triângulo Escaleno"
// --------------------------------------------------------------------------

// 3) Faça uma função que a partir de um vetor [0..20] e faça o seguinte
// processo:
//  3.1) Primeiro filtre os valores para deixar somente pares do vetor
//  (List.filter);
//  3.2) Depois multiplique cada valor por 2 (List.map);
//  3.3) Por último filtre novamente os valores, agora para deixar somente os
//  múltiplos de 6.
// As operações devem ser aplicadas utilizando o operador pipe (|>).

let handleMultiplesOfSixAnArray =
    let isPair number = number % 2 = 0
    let multiplyByTwo number = number * 2
    let multiplesOfSix number = number % 6 = 0

    [ 0..20 ]
    |> List.filter isPair
    |> List.map multiplyByTwo
    |> List.filter multiplesOfSix
// --------------------------------------------------------------------------

// 4) Faça uma função em que o usuário digite 3 números e calcule a média entre
// elas, outra função que retorna se a média é acima ou abaixo da 6.0 e uma
// terceira, que a partir da informação booleana de aprovado ou reprovado,
// escreve uma mensagem correspondente ao resultado na tela. Essas funções
// devem estar aninhadas dentro de uma função resultado_notas que deve chamar
// as 3 funções internas utilizando pipeline.

// resultado_notas -> resultsOfGrades
let resultsOfGrades numberOne numberTwo numberThree =
    let media = (numberOne + numberTwo + numberThree) / 3.0
    let mediaIsGreatherOrEqualSix media = media >= 6.0

    let handleApproved isApproved =
        if (isApproved) then
            printf "Resultado: Aprovado!"
        else
            printf "Resultado: Reprovado!"

    media |> mediaIsGreatherOrEqualSix |> handleApproved
// --------------------------------------------------------------------------

[<EntryPoint>]
let main argv =
    printfn "\nInforme 2 números a serem divididos: "
    let numberOne = (System.Console.ReadLine() |> System.Double.Parse)
    let numberTwo = (System.Console.ReadLine() |> System.Double.Parse)

    printfn "Resultado da divisão entre maior pelo menor número: %f" (handleDivideBiggestBySmallest numberOne numberTwo)

    printfn "\nInforme 3 lados para um triângulo: "
    let basis = System.Console.ReadLine() |> System.Int32.Parse
    let leftSide = System.Console.ReadLine() |> System.Int32.Parse
    let rightSide = System.Console.ReadLine() |> System.Int32.Parse

    handleTriangleType basis leftSide rightSide

    printf "\nMostra os múltiplos de 6 com os pares dobrados (em um vetor de 0 até 20): "

    for number in handleMultiplesOfSixAnArray do
        printf "%i " number

    printfn "\n\nInforme 3 notas: "
    let notaOne = System.Console.ReadLine() |> System.Double.Parse
    let notaTwo = System.Console.ReadLine() |> System.Double.Parse
    let notaThree = System.Console.ReadLine() |> System.Double.Parse

    // resultado_notas -> resultsOfGrades
    resultsOfGrades notaOne notaTwo notaThree

    0
