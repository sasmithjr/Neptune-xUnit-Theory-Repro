module Tests

open System
open Xunit

[<Fact>]
let ``Fact test`` () =
    Assert.True(true)


[<Theory>]
[<InlineData(0)>]
let ``Theory test 1``(_) =
    Assert.True(true)

[<Theory>]
[<InlineData(0)>]
[<InlineData(1)>]
let ``Theory test 2``(_) =
    Assert.True(true)