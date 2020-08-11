namespace Library
open Utils

module Euler3 =
    let divide divident divisor =
        if divident % divisor = 0L then
            Some (divident / divisor)
        else 
            None

    let mutable number = 600_851_475_143L
    let mutable max = 1L;

    let maxDivisor = 
        let limit = (i64sqrt number) + 1L
        for i in 1L .. limit do
            let result = divide number i 
            if result.IsSome then 
                max <- i
                number <- result.Value
        max

    let run = 
        maxDivisor