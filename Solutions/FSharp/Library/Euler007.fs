namespace Library
open Utils

module Euler7 =
    let nThPrime n = 
        let mutable i = 2
        let mutable primeCount = 0

        while primeCount < n do
            if isPrime i then 
                primeCount <- primeCount + 1
            i <- i + 1

        i - 1

    let run = 
        nThPrime 10001