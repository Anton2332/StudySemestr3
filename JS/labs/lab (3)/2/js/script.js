//5.2.1.
{
  var obj = {
    key: 'value'
  };

  function getProperty(a, b) {
    return a[b];
  };


  var output = getProperty(obj, 'key');
  console.log(output);
}

//5.2.2.
{
  var myObj = {};
  function addProperty(a, b) {
    a[b] = true;
  };
  addProperty(myObj, "myProperty");
  console.log(myObj.myProperty);
}

//5.2.3.
{
  var obj = {
    name: 'Sam',
    age: 20
  };
  function removeProperty(a, b) {
    delete a[b]
  }
  removeProperty(obj, 'name');
  console.log(obj.name);
}

//5.2.4
{
  function getFullName(a, b) {
    return (a + " " + b);
  }
  var output = getFullName("Joe", "Smith");
  console.log(output);
}

//5.2.5
{
  function getLengthOfWord(a) {
    return a.length;
  }
  var output = getLengthOfWord("some");
  console.log(output);
}

//5.2.6
{
  function getLengthOfTwoWords(a, b) {
    return a.length + b.length;
  }
  var output = getLengthOfTwoWords("some", "words");
  console.log(output);
}

//5.2.7
{
  function isGreaterThan(a, b) {
    if (b > a)
      return true;
    else
      return false;
  }
  var output = isGreaterThan(11, 10);
  console.log(output);
}

//5.2.8
{
  function isEven(a) {
    if (a % 2 == 0)
      return true;
    else
      return false;
  }
  var output = isEven(11);
  console.log(output);
}

//5.2.9
{
  function isSameLength(a, b) {
    if (a.length == b.length)
      return true;
    else
      return false;
  }
  var output = isSameLength("words", "super");
  console.log(output);
}

//5.2.10
{
  function isEvenAndGreaterThanTen(a) {
    if (a % 2 == 0 && a > 10)
      return true;
    else
      return false;
  }
  var output = isEvenAndGreaterThanTen(13);
  console.log(output);
}

//5.2.11
{
  function computeAreaOfATriangle(a, b) {
    return (a * b) / 2;
  }
  var output = computeAreaOfATriangle(4, 6);
  console.log(output);
}

