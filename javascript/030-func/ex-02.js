const number = [1, 2, 3, 4];

const result = number.map(e => e * e)

console.log(result);




function select(items, logic) {
    const result = [];
    for (let i = 0; i < items.length; i++) {
        const element = items[i];
        result.push(logic(element))
    }
    return result;
}

const res = select(number, e => e ** 5)

console.log(res);
