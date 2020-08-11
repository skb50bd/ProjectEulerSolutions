namespace Library

module Euler9 =
    let isPythagorianTriplet a b c =
        a * a + b * b = c * c
        
    let findPythagorianTripletToSum sum =
        [ for i in [ 1 .. sum / 2 ] do 
            for j in [ i .. sum / 2 ] -> 
                i, j, (sum - i - j) ]
        |> List.tryFind (fun (a, b, c) -> isPythagorianTriplet a b c)         
      
    let run = 
        match findPythagorianTripletToSum 1000 with
        | Some (a, b, c) -> a * b * c
        | None -> 0
