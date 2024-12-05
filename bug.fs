let mutable x = 10
let y = &x
printf "%A" (!y)
x <- 20
printf "%A" (!y)