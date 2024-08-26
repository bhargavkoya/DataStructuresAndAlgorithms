class MyArray{
    constructor(){
        this.length=0;
        this.data={};
    }
    
    get(index){
        return this.data[index];
    }
    
    push(item){
        this.data[this.length]=item;
        this.length++;
        return this.length;
    }
    pop(){
        const lastitem=this.data[this.length-1];
        delete this.data[this.length-1];
        this.length--;
        return lastitem;
    }
    
    delete(index){
        const item=this.data[index];
        this.shiftItems(index);
        return item;
    }
    
    shiftItems(index){
        for(let i=index;i<this.length-1;i++){
            this.data[i]=this.data[i+1];
        }
        delete this.data[this.length-1];
        this.length--;
    }
}

const newarray=new MyArray();
newarray.push('hi');
newarray.push('hello');
//newarray.pop();
newarray.delete(1);
console.log(newarray);


//Exercises

//1.Reverse a string
const rev= str=>str.split('').reverse().join('');
console.log(rev);


//2.mergearrays
function mergeSortedArrays(array1, array2){
    const mergedArray = [];
    let array1Item = array1[0];
    let array2Item = array2[0];
    let i = 1;
    let j = 1;
    
    //We should actually move these 2 if statements to line 2 so that we do the checks before we do assignments in line 3 and 4!
    if(array1.length === 0) {
      return array2;
    }
    if(array2.length === 0) {
      return array1;
    }
  
    while (array1Item || array2Item){
     if(array2Item === undefined || array1Item < array2Item){
       mergedArray.push(array1Item);
       array1Item = array1[i];
       i++;
     }   
     else {
       mergedArray.push(array2Item);
       array2Item = array2[j];
       j++;
     }
    }
    return mergedArray;
  }
  
  mergeSortedArrays([0,3,4,5], [4,6,9]);
  //output
  //[0,3,4,4,5,6,9]


//JSArray METHODS:
//1.concat():returns a new array, containing the joined arrays,method does not change the existing arrays.


const arr1 = ["Cecilie", "Lone"];
const arr2 = ["Emil", "Tobias", "Linus"];
const children = arr1.concat(arr2);
//output 
["Cecilie", "Lone","Emil", "Tobias", "Linus"]

//2.copywithin():copies array elements to another position in the array,overwrites the existing values
const fruits = ["Banana", "Orange", "Apple", "Mango", "Kiwi"];
fruits.copyWithin(2, 0, 2);
//output
["Banana", "Orange", "Banana", "Orange", "Kiwi"];

//3.fill():fills specified elements in an array with a value,overwrites the original array
const fruitss = ["Banana", "Orange", "Apple", "Mango"];
fruitss.fill("Kiwi", 2, 4);
//output
["Banana", "Orange", "Kiwi", "Kiwi"];

//4.filter():creates a new array filled with elements that pass a test provided by a function,does not change the original array.
const ages = [32, 33, 16, 40];
const result = ages.filter(checkAdult);

function checkAdult(age) {
  return age >= 18;
}
//output
[32,33,40]

//5.find():returns the value of the first element that passes a test,does not change the original array.
const agess = [3, 10, 18, 20];

function checkAge(age) {
  return age > 18;
}
agess.find(checkAge);
//output
20

//6.findIndex(): same as find but it returns index of value.

//7.forEach():calls a function for each element in an array.
let sum = 0;
const numbers = [65, 44, 12, 4];
numbers.forEach(myFunction);

function myFunction(item) {
  sum += item;
}
//output
125

//8.from():returns an array from any object with a length property
Array.from("ABCDEFG")
//output
['A','B','C','D','E','F','G']

//9.includes():returns true if an array contains a specified value otherwise false
//array.includes(element, start)
const fruitsss = ["Banana", "Orange", "Apple", "Mango"];
fruitsss.includes("Banana", 3);
//output
false

//10.indexOf():returns the first index (position) of a specified value,returns -1 if the value is not found,starts at a specified index and searches from left to right
const fruitst = ["Banana", "Orange", "Apple", "Mango", "Apple"];
let index = fruitst.indexOf("Apple", 3);
//output
4

//11.isArray():returns true if an object is an array, otherwise false
const fruitstt = ["Banana", "Orange", "Apple", "Mango"];
let results = Array.isArray(fruitstt);
//output
true

//12.join():returns an array as a string,does not change the original array,Any separator can be specified. The default is comma (,).
const fruits1 = ["Banana", "Orange", "Apple", "Mango"];
let text = fruits1.join();//Banana,Orange,Apple,Mango
let text2=fruits1.join(" and "); //Banana and Orange and Apple and Mango

//13.keys():returns an Array Iterator object with the keys of an array,does not change the original array.
const fruits2 = ["Banana", "Orange", "Apple", "Mango"];
const keys = fruits.keys();

let text1 = "";
for (let x of keys) {
  text1 += x + "<br>";
}
//output
0
1
2
3

//14.length:The length property sets or returns the number of elements in an array.
const fruits3 = ["Banana", "Orange", "Apple", "Mango"];
let length = fruits.length; //4
fruits3.length=2; //sets length to 2 

//15.map():creates a new array from calling a function for every array element,does not change the original array.
const numbers1 = [4, 9, 16, 25];
const newArr = numbers1.map(Math.sqrt);
//output
[2,3,4,5]

//16.pop():removes (pops) the last element of an array,changes the original array,returns the removed element.
const fruits4 = ["Banana", "Orange", "Apple", "Mango"];
fruits4.pop();
//output
Mango

//17.push():adds new items to the end of an array,changes the length of the array.
const fruits5 = ["Banana", "Orange", "Apple", "Mango"];
fruits5.push("Kiwi", "Lemon");
//output
["Banana", "Orange", "Apple", "Mango","Kiwi","Lemon"];

//18.reduce():executes a reducer function for array element,returns a single value: the function's accumulated result,does not change the original array
//array.reduce(function(total, currentValue, currentIndex, arr), initialValue)
const numbers2 = [175, 50, 25];
function myFunc(total, num) {
  return total - num;
}
numbers.reduce(myFunc);
//output
100

//19.reverse():reverses the order of the elements in an array,overwrites the original array.
const fruits6 = ["Banana", "Orange", "Apple", "Mango"];
fruits6.reverse();
//output
[  "Mango","Apple","Orange","Banana"];

//20.shift():removes the first item of an array,changes the original array,returns the shifted element.
const fruits7 = ["Banana", "Orange", "Apple", "Mango"];
fruits7.shift();
//output
Banana

//21.slice():returns selected elements in an array, as a new array,selects from a given start, up to a (not inclusive) given end,does not change the original array
const fruits8 = ["Banana", "Orange", "Lemon", "Apple", "Mango"];
const citrus = fruits8.slice(1, 3);
//output
["Orange", "Lemon"]

//22.sort():sorts the elements as strings in alphabetical and ascending order,overwrites the original array.
const fruits9 = ["Banana", "Orange", "Apple", "Mango"];
fruits9.sort();
//output
["Apple","Banana", "Mango","Orange"];

//23.splice():adds and/or removes array elements,overwrites the original array.
//array.splice(index, howmany, item1, ....., itemX)

const fruits10 = ["Banana", "Orange", "Apple", "Mango"];
fruits10.splice(2, 0, "Lemon", "Kiwi"); //["Banana", "Orange", ,"Lemon", "Kiwi","Apple", "Mango"];
fruits10.splice(2, 2);//["Banana", "Orange", "Apple", "Mango"];

//24.toString():returns a string with array values separated by commas,does not change the original array.
const fruits12 = ["Banana", "Orange", "Apple", "Mango"];
let text12 = fruits.toString();
//output
Banana,Orange,Apple,Mango

//25.unshift():adds new elements to the beginning of an array,overwrites the original array.
const fruits13 = ["Banana", "Orange", "Apple", "Mango"];
fruits13.unshift("Lemon","Pineapple");
//output
["Lemon","Pineapple","Banana", "Orange", "Apple", "Mango"];


//26.valueOf():returns the array itself,does not change the original array,
const fruits14 = ["Banana", "Orange", "Apple", "Mango"];
const myArray = fruits14.valueOf();
//output
["Banana", "Orange", "Apple", "Mango"];







