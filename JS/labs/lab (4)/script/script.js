//1.1
{
  function findMinLengthOfThreeWords(a, b, c) {
    if (a.length < b.length && a.length < c.length) {
      return a.length
    }
    else if (b.length < a.length && b.length < c.length)
      return b.length
    else
      return c.length
  }

  var output = findMinLengthOfThreeWords("a", "be", "see")
  console.log(output);
}

//1.2
{
  function filterOddElements(arr) {
    var arr2 = [];
    for (var i = 0; i < arr.length; i++) {
      if (arr[i] % 2 != 0)
        arr2.push(arr[i]);
    }
    return arr2;
  }

  var output = filterOddElements([1, 2, 3, 4, 5]);
  console.log(output);
}

//1.3
{
  function getLengthOfShortestElement(arr) {
    var k = arr[0].length;
    for (var i = 0; i < arr.length; i++)
      if (arr[i].length < k)
        k = arr[i].length;

    return k;
  }

  var output = getLengthOfShortestElement(["one", "two", "three"]);
  console.log(output);
}

//1.4
{
  function joinArrayOfArrays(arr) {
    var arr2 = [];
    for (var i = 0; i < arr.length; i++) {
      for (var j = 0; j < arr[i].length; j++)
        arr2.push(arr[i][j]);
    }
    return arr2;
  }

  var output = joinArrayOfArrays([[1, 4], [true, false], ["x", "y"]]);
  console.log(output);
}

//1.5
{
  function findSmallestNumberAmongMixedElements(arr) {

    var k, j = 0;
    for (var i = 0; i < arr.length; i++) {
      if (j == 0 && Number.isInteger(arr[i])) {
        j++;
        k = arr[i];
      }
      if (k > parseInt(arr[i]))
        k = parseInt(arr[i]);
    }
    if (k == undefined)
      return 0;
    else
      return k;
  }

  var output = findSmallestNumberAmongMixedElements([4, "lincoln", 9, "octopus"]);
  console.log(output);

}

//1.6
{
  function computeSummationTon(n) {
    var k = 0;
    for (var i = 0; i <= n; i++)
      k += i;
    return k;
  }

  var output = computeSummationTon(6);
  console.log(output);
}

//1.7
{
  function convertScoreToGrabe(score) {
    if (score <= 100 && score >= 90)
      return "A";
    else if (score <= 89 && score >= 82)
      return "B";
    else if (score <= 81 && score >= 75)
      return "C";
    else if (score <= 74 && score >= 69)
      return "D";
    else if (score <= 68 && score >= 60)
      return "E";
    else if (score <= 59 && score >= 35)
      return "Fx";
    else if (score <= 34 && score >= 0)
      return "F";
    else
      return "ENVALID SCORE";
  }

  var output = convertScoreToGrabe(91);
  console.log(output);
}

//1.8
{
  function getLongestOfThreeWords(word1, word2, word3) {
    var k;
    if (word3.length > word2.length && word3.length > word1.length)
      return word3;
    else if (word2.length > word3.length && word2.length > word1.length)
      return word2;
    else
      return word1;
  }

  var output = getLongestOfThreeWords("these", "three", "words");
  console.log(output);
}

//1.9
{
  function multiply(num1, num2) {
    var k = 0;
    for (var i = 0; i < num2; i++)
      k += num1;
    return k;
  }

  var output = multiply(4, 7);
  console.log(output);
}

//1.10
{
  function computeSumBetween(num1, num2) {
    if (num2 < num1)
      return 0;
    else {
      var k = num1;
      for (var i = num1 + 1; i < num2; i++)
        k += i;
      return k;
    }
  }

  var output = computeSumBetween(2, 5);
  console.log(output);
}


