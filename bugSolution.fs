let x = ref 10
let y = x
printf "%A" !x
x := 20
printf "%A" !x