namespace Library 
open System.Diagnostics

module Benchmark =
    let run func = 
        let sw = Stopwatch()
        sw.Start()
        let res = func()
        sw.Stop()
        printfn "Elapsed %d ms" sw.ElapsedMilliseconds
        
        res