function fun (obj){
    let defualtObj = {
        courseName:'ES6 ',
        courseDuration :'3days' ,
        courseOwner :'JavaScript'
    }
    let finalObj= {}
    if(obj){
        let keys = Object.keys(obj)
        for(let k  of keys){
            if( k !== 'courseName' &&
            k !== 'courseDuration' &&
            k!== 'courseOwner' ){
                        throw new Error 
                        (" params must include courseName or courseDuration or courseOwner  ")
        }
    }
    }
    Object.assign(finalObj ,defualtObj ,obj)
    console.log (finalObj)
}

fun ();
fun({courseName :'ee'});
// fun ({userName:'essam'})
