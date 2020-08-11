namespace Library
open Utils

module Euler10 =  
    let sumOfPrimesTill upto = 
        let primes = 
            [ 2L .. upto ]
            |> List.filter (int >> isPrime) 
        
        let sum = 
            primes
            |> List.sum

        sum

    let run = 
        sumOfPrimesTill 2_000_000L
