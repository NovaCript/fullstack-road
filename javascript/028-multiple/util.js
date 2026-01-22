function multiply(x, y) {
    return x * y;
}

function divide(x, y) {
    return x / y;
}

// group export
export {divide, multiply};

// export
export function sum(x, y) {
    return x + y;
}

// только один default export по умолчанию
export default function (x, y) {
    return x - y;
}

