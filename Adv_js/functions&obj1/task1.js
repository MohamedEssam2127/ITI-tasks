lnkdLstObj = {
    data: [],
    length: 0,
    Enqueue: function (myVal) {
        if (this.data.length === 0) {
            this.data.unshift({ value: myVal })
            this.length++;
        } else {
            if (this.data[0].value > myVal) {
                this.data.unshift({ value: myVal })
                this.length++;
            } else if (this.data[0].value < myVal) {
                throw new Error(" the first element must be the smallest one ")
            } else {
                throw new Error("  the value is already exsit  ")
            }
        }
    },
    push: function (myVal) {
        if (this.data.length === 0) {
            this.data.push({ value: myVal })
            this.length++;
        } else {
            if (this.data[this.length - 1].value < myVal) {
                this.data.push({ value: myVal })
                this.length++;
            } else if (this.data[this.length - 1].value > myVal) {
                throw new Error(" the last  element must be the largest one ")
            } else {
                throw new Error("  the value is already exsit  ")
            }
        }
    },
    pop: function () {
        if (this.data.length === 0) {
            throw new Error(" linked list is empty")
        } else {
            this.data.pop();
            this.length--;
        }
    },
    dequeue: function () {
        if (this.data.length === 0) {
            throw new Error(" linked list is empty")
        } else {
            this.data.shift();
            this.length--;
        }
    },
    insert: function (index, myVal) {
        if (this.data.length === 0 && index !== 0) {
            throw new Error("the linked list is empty");
        }
        if (index === 0) {
            if (this.data.length === 0) {
                this.data.push({ value: myVal })
                this.length++
            } else if (this.data[index].value > myVal) {
                this.data.unshift({ value: myVal })
                this.length++
            } else {
                throw new Error(" the first element must be the smallest one ")
            }
        } else if (index === this.length) {
            if (this.data[index - 1].value < myVal) {
                this.data.push({ value: myVal })
                this.length++
            } else {
                throw new Error(" the last  element must be the largest one ")
            }
        } else if (this.data[index - 1].value < myVal && this.data[index].value > myVal) {
            this.data.splice(index, 0, { value: myVal })
            this.length++
        } else {
            throw new Error("cant add this value not in place ")
        }
    },
    display: function () {
        let str = "";
        for (let i = 0; i < this.data.length; i++) {
            str += this.data[i].value + " "
        }
        return str;
    },
   remove: function (index, myVal) {
    if (this.data.length === 0) {
        throw new Error("the linked list is empty");
    }

    if (index < 0 || index >= this.data.length) {
        throw new Error("index out of bounds");
    }

    if (this.data[index].value === myVal) {
        this.data.splice(index, 1);
        this.length--;
    } else {
        throw new Error("data not found");
    }
}
}

lnkdLstObj.insert(0, 2); // [2]
lnkdLstObj.insert(1, 5); // [2,5]
lnkdLstObj.insert(1, 3); // [2,3,5]
lnkdLstObj.push(8)  //[2,3,5,8]
lnkdLstObj.push(9)   //[2,3,5,8,9]
lnkdLstObj.Enqueue(1) //[1,2,3,5,8,9]


console.log(lnkdLstObj.display())
lnkdLstObj.remove(0,1)
console.log(lnkdLstObj.display())
lnkdLstObj.remove(2,5)
console.log(lnkdLstObj.display())