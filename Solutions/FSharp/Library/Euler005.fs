namespace Library

module Euler5 =
    // Greatest Common Divisor (Euclidian)
    let rec gcd (a: int64, b: int64) =
        match b with
        | x when x = 0L -> a
        | _ -> gcd (b, a % b)

    // Least Common Multiple
    let rec lcm (a: int64, b: int64) = 
        (a * b) / gcd (a, b)

    // LCM for a List of Numbers
    let rec lcmList (list: int64 list) =
        match list with
        | [] -> 1L
        | [ a ] -> a
        | [ a; b ] -> lcm (a, b)
        | h :: t -> lcm (h, lcmList t)

    let run =
        [ for i in 1L .. 20L -> i ] |> lcmList
