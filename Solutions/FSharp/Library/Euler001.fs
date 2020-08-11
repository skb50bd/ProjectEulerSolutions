namespace Library

// Multiples of 3 and 5
module Euler1 =
    let multiples3 upto = seq { 0 .. 3 .. upto }
    let multiples5 upto = seq { 0 .. 5 .. upto }
    let run =
        let upto = 1000 - 1;
        let threes = Set.ofSeq (multiples3 upto)
        let fives = Set.ofSeq (multiples5 upto)
        Set.union threes fives
        |> Seq.sum