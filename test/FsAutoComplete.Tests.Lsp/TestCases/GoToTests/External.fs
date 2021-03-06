module External

open System.Net

let getHttpMethod (r: HttpWebRequest) = r.Method

open Giraffe.GiraffeViewEngine

// this is used to test sourcelink from PDBs, because Giraffe puts them there
let myButton props children = button props children

//this is used to test sourcelink from dll-embedded data, ie from FSharp.Core
let myConcat listA listB = List.concat [listA; listB]

let myStringConcat (separator: string) (strings: string []) = System.String.Join(separator, strings)
