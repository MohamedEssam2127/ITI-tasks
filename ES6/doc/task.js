const myobj = {
    name: "mo essam",
    address: "Cairo",
    age: 22,
    _id: 555
}

const handler = {
    has(target, prop) {
        if (prop === '_id') {
            return false
        }
        return Reflect.has(target, prop)
    },
    
    deleteProperty(target, prop) {
        if (prop === 'name') {
            throw 'Error: name cant be deleted'
        }
        return Reflect.deleteProperty(target, prop)
    },

    ownKeys(target) {
        return Reflect.ownKeys(target).filter(key => key !== '_id')
    },

    defineProperty(target, prop, descriptor) {
        if (prop === 'admin') {
            throw 'Error: cant add admin property'
        }
        return Reflect.defineProperty(target, prop, descriptor)
    },

    preventExtensions(target) {
        return false
    }
}

const p = new Proxy(myobj, handler)

console.log('age' in p)
console.log('_id' in p)

console.log(Object.keys(p))

try {
    delete p.name 
} catch (e) {
    console.log(e)
}

try {
    Object.defineProperty(p, 'admin', { value: true })
} catch (e) {
    console.log(e)
}

Object.preventExtensions(p)