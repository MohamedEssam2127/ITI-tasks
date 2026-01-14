function myfun1 (){
    return [].reverse.call(arguments)
}
function myfun2 () {
    return [].reverse.apply(arguments)
}

console.log(myfun1(1,2,3))
console.log(myfun2(1,2,3))