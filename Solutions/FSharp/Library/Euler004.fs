namespace Library

module Euler4 =
    let isPalindrome (s: string) = 
        let len = s.Length
        seq { 0 .. (len / 2) } 
        |> Seq.forall (fun i -> s.[i] = s.[len - i - 1])

    let run =
        let mutable max = 0
        for a in seq { 111 .. 999 } do
            for b in seq { 111 .. 999 } do
                let prod = a * b
                if prod |> string |> isPalindrome then
                    if prod > max then
                        max <- prod
        max