const symbolGen = {
    obj :{
        name :'essam',
        age:22,
    },

    *[Symbol.iterator](){
        for(let [key ,val] of Object.entries(this.obj)){
            yield `${key }: ${val}`
        }
    }
}


let iter = symbolGen[Symbol.iterator]()
console.log (iter.next())
console.log (iter.next())