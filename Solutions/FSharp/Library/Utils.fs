namespace Library

module Utils =
    
    let isqrt = double >> sqrt >> int
    let i64sqrt (n: int64) = n |> double |> sqrt |> int64
        
    let isPrime n = 
        let hasFactor =
            [ 2 .. isqrt n ]
            |> List.exists (fun x -> n % x = 0) 
        not hasFactor

