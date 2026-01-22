const arr = [1, 5, 4, 6, 2, 3, -77, 5, 4, 2, 5, 4, 7, 9, 1];

function getElementFromArray(arr, checkItem) {
  const newArr = [];

  for (let i = 0; i < arr.length; i++) {
    const items = arr[i];
    if (checkItem(items)) {
      newArr.push(arr[i]);
    }
  }
  console.log(newArr);
}

// getElementFromArray(arr, e => e < 2)


// predicate
const result = arr.filter(e => e < 0)
console.log(result);


