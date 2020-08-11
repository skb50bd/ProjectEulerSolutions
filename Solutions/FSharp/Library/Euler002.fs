namespace Library

// Even Fibonacci Numbers
module Euler2 =
    let upto = 4_000_000
    let rec evenFibsRec a b =
        let current = a + b  
        if current <= upto then
            let rest = evenFibsRec b current
            if current % 2 = 0 then 
                current :: rest
            else 
                rest
        else
            []

    let run =
        2 :: (evenFibsRec 1 2)
        |> List.sum