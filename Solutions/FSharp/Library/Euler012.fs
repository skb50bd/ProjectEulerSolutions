namespace Library
open Utils 

module Euler12 =  
    let seriesSumOfFirst n = 
        n * (n + 1) / 2

    let getNumberOfFactors n =
        let mutable factorCount = 0

        for i in 2 .. isqrt n do 
            if n % i = 0 then factorCount <- factorCount + 2
        
        factorCount

    let findTriangleNumberWithNFactors n =
        let mutable maxFactors = 0
        let mutable index = 1

        while maxFactors < n do 
            let triangleNumber = seriesSumOfFirst index
            let factorCount = getNumberOfFactors triangleNumber
            
            if maxFactors < factorCount then 
                maxFactors <- factorCount
            index <- index + 1

        seriesSumOfFirst (index - 1)

    let run = 
        findTriangleNumberWithNFactors 500