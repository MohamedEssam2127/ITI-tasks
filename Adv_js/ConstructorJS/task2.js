

function Box () {
    this.numOfBooks =0;
    this.content =[];
    this.delete=function(title){
        title =title.toLocaleLowerCase();
        let isExist = false ;
        let index
        for(let i=0;i < this.content.length && ! isExist;i++){
            if(title === this.content[i].title){
                index = i;
                isExist = true ;
            }
        }
        if(isExist){
            if(this.content[index].numOfCopies >1 ){
                this.content[index].numOfCopies--;
            }else{
                this.content.splice(index,1);
            }
        }else{
            throw new Error (' the book not exist ')
        }
        this.numOfBooks--;
        console.log("after Delete ")
        this.display()
    }

    this.addBook= function (b1){
        let isExist = false ;
        for(let i = 0 ;i < this.content.length ;i++){
            if(b1.title===this.content[i].title){
                isExist= true ;
                this.content[i].numOfCopies++;
            }
        }
        if(! isExist){
            this.content.push(b1)
        }
        this.numOfBooks++;
         console.log("after ADD ")
        this.display();
    }

    this.display= function (){
        let str = ' ---- number of books is '+ this.numOfBooks+' ---- \n \n' ;
        for(let i =0;i < this.content.length ; i++){
            str += "title  [" + this.content[i].title + "] ,number of copies  [" + this.content[i].numOfCopies +']\n \n'
        }
        console.log(str)
    }

}


function Book (title ="OK",numOfCopies=1){
    this.title = title.toLocaleLowerCase()
    this.numOfCopies = numOfCopies
}

var box1 =  new Box();
var book1=  new Book()
var book2=  new Book(title= 'hello')

box1.addBook(book1)
box1.addBook(book1)

box1.addBook(book2)
box1.delete('OK')
box1.delete('OK')
