console.log(`------------------------------------------------`)
for (let i = 1; i <= 10; i++) {
    console.log(i)
}
console.log(`------------------------------------------------`)
for (let i = 1; i <= 20; i++) {
    if (i % 2 == 0){
        console.log(i);
    }
}
console.log(`------------------------------------------------`)
let result = 0;
for (let i = 1; i <= 100; i++) {
    result +=i;
}
console.log(result);
console.log(`------------------------------------------------`)

result = 1;
for (let i = 1; i < 6; i++) {
    result *= i;
}
console.log(result);
console.log(`------------------------------------------------`)
for (let i = 1; i < 11; i++) {
    console.log(Math.pow(2, i))
}
console.log(`------------------------------------------------`)
for (let i = 1; i < 11; i++) {
    console.log(5*i);
}
console.log(`------------------------------------------------`)
let num = 66;
result = 0;
if (num > 0) {
    for (let i = 1; i < num + 1; i++) {
        result += i;
    }
    console.log((num * (num + 1))/2)
}
console.log(result);
console.log(`------------------------------------------------`)

num = 3;
result = 1;
for (let i = 1; i <= num; i++) {
    result *= i;
}
console.log(result);
console.log(`------------------------------------------------`)
let star = "";
for (i = 1; i <= num; i++) {
    star +="*";
}
console.log(star);
console.log(`------------------------------------------------`)

num = 10;
while(num > 0) {
    console.log(num);
    num--;
}
console.log(`------------------------------------------------`)
num = 10;
for (; num > 0; num--) {
    console.log(num);
} 
console.log(`------------------------------------------------`)

num = 6;
const sequence = [0, 1];
  for (let i = 2; i < num; i++) {
    sequence.push(sequence[i - 1] + sequence[i - 2]); 
  }
  console.log(sequence);