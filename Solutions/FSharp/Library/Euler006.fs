namespace Library

module Euler6 =
    let rec squaredSumRec (list: int list) sum =
        match list with
        | [] -> sum
        | [ a ] -> (a * a) + sum
        | h :: t  -> (h * h) + (squaredSumRec t sum)
    
    let squaredSum list =
        list |> List.sumBy (fun x -> x * x)


    let summedSquare (list: int list) =
        let sum = list |> List.sum
        sum * sum

    let summedSquareRec (list: int list) =
        let rec sumRec list' sumAcc = 
            match list' with 
            | [] -> 0
            | [ a ] -> a + sumAcc
            | h :: t -> h + (sumRec t sumAcc)

        let sumVal = sumRec list 0
        sumVal * sumVal
        

    let run =
        let list = [ for i in 1 .. 100 -> i ]
        summedSquare list - squaredSum list
