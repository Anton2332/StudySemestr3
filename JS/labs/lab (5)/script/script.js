//1.1
{
  function coputeAreaOfARectengle(a, b) {
    return a * b;
  }
  var output = coputeAreaOfARectengle(4, 8);
  console.log(output);
}

//1.2
{
  function computeAreaOfACircle(a) {
    return Math.PI * Math.pow(a, 2);
  }
  var output = computeAreaOfACircle(4);
  console.log(output);
}

//1.3
{
  function computePower(a, b) {
    return Math.pow(a, b);
  }
  var output = computePower(2, 3);
  console.log(output);
}

//1.4
{
  function computeSquareRoot(a) {
    return Math.sqrt(a);
  }
  var output = computeSquareRoot(9);
  console.log(output);
}

//1.5
{
  function getLengthOfThreeWords(a, b, c) {
    return a.length + b.length + c.length;
  }
  var output = getLengthOfThreeWords('some', 'other', 'words');
  console.log(output);
}

//1.6
{
  function joinArrays(a, b) {
    var c = [];
    for (var i = 0; i < a.length; i++)
      c.push(a[i]);
    for (var i = 0; i < b.length; i++)
      c.push(b[i]);
    return c;
  }
  var output = joinArrays([1, 2], [3, 4]);
  console.log(output);
}

//1.7
{
  var obj = {
    key: [1, 2, 3, 4],
  };
  function getProductOfAllElementsAtProperty(a, b) {
    var k = 0;
    if (a[b] != undefined)
      if (a[b].length != 0) {
        k = 1;
        for (var i = 0; i < a[b].length; i++)
          k *= a[b][i];

      }
    return k;
  }
  var output = getProductOfAllElementsAtProperty(obj, 'key');
  console.log(output);
}

//1.8
{
  function sumDigits(a) {
    var b = 0;
    if (a > 0)
      for (; a != 0;) {
        b += a % 10;
        a /= 10;
        a = Math.trunc(a);
      }
    else
      for (; a != 0;) {
        if (Math.trunc(a / 10) != 0) {
          b -= a % 10;
          a /= 10;
          a = Math.trunc(a);
        }
        else {
          b += a % 10;
          a /= 10;
          a = Math.trunc(a);
        }
      }
    return b;
  }
  var output = sumDigits(1148);
  console.log(output)
  output = sumDigits(-316);
  console.log(output);
}

//1.9
{
  function isNumber(n) {
    return !isNaN(parseFloat(n)) && !isNaN(n - 0)
  }
  function findShortestWordAmongMixedElements(a) {
    var b = '', k = 0;
    for (var i = 0; i < a.length; i++) {
      if (!isNumber(a[i])) {
        if (k == 0) {
          b = a[i];
          k++;
        }
        else if (b.length > a[i].length)
          b = a[i];
      }
    }
    return b;
  }
  var output = findShortestWordAmongMixedElements([4, 'two', 2, 'three']);
  console.log(output);
}

//1.10
{
  function findSmallestNumberAmongMixedElements(a) {
    var b = '', k = 0;
    for (var i = 0; i < a.length; i++) {
      if (isNumber(a[i])) {
        if (k == 0) {
          b = a[i];
          k++;
        }
        else if (a[i] < b)
          b = a[i];
      }
    }
    return b;
  }
  var output = findSmallestNumberAmongMixedElements([4, 'lincoln', 9, 'octopus']);
  console.log(output);
}

//1.11
{
  function modulo(a, b) {
    var c, e;
    c = a / b;
    e = Math.trunc(c);
    c -= e;
    c *= 4;
    if ((a < 0 && c > 0) || (a > 0 && c < 0))
      c *= -1;
    return c;
  }
  var output = modulo(25, 4);
  console.log(output);
}

//1.12
{
  function flipEveryNChars(a, b) {
    var output = '', c = '';
    var intput = a.split('');
    for (var i = 0; i < input.length; i++) {
      if (c.length != b)
        c += input[i];
      if (c.length == b) {
        k = 0;
        output += c.split('').reverse().join('');
        c = '';
      }
    }
    return output;
  }

  var input = 'a short example';
  var output = flipEveryNChars(input, 5);
  console.log(output);
}

//1.13
{
  function detectOutlierValue(a) {
    var input = a.split(' ');
    var k1 = 0, k2 = 0, i1, i2;
    for (var i = 0; i < input.length; i++) {
      if (input[i] % 2 == 0) {
        k2++;
        i2 = i;
      }
      else if (input[i] % 2 != 0) {
        k1++;
        i1 = i;
      }
    }
    if (k1 == 1)
      console.log(" => " + i1 + " - is odd");
    else if (k2 == 1)
      console.log(" => " + i2 + " - is pair");
  }
  detectOutlierValue('2 4 7 8 10')
  detectOutlierValue('1 10 1 1')
}

//1.14
{
  function sumInArray(a) {
    var sum = 0;
    for (var i = 0; i < a.length; i++)
      sum += a[i];
    return sum;
  }
  function findPairForSum(a, b) {
    var arr = [];
    for (var i = 0; i < a.length; i++) {
      arr.push(a[i]);
      for (var j = 0; j < a.length; j++) {
        if (j != i)
          arr.unshift(a[j]);
        if (sumInArray(arr) == b && arr.length == 2)
          break;
        else
          arr.shift();
      }
      if (sumInArray(arr) == b && arr.length == 2)
        break;
      else
        arr = [];
    }
    return arr;
  }
  var pair = findPairForSum([3, 34, 4, 12, 5, 2], 9);
  console.log(pair);
}

//1.15
{
  var landslide = (a) => a.substr(1) + a[0];
  function darkalityCheck(a, b) {
    var k = false;
    for (var i = 0; i < a.length; i++) {
      if (a == b) {
        k = true;
        break;
      } else
        a = landslide(a);
    }
    return k;
  }
  var output = darkalityCheck("hello world", "orldhello w");
  if (output)
    console.log("true");
  else
    console.log("false");
}

//1.16
{
  function search(arr, b) {
    var j;
    if (arr.length % 2 != 0)
      j = (arr.length - 1) / 2;
    else j = arr.length / 2;
    for (; ;) {
      if (arr[j] == b)
        break;
      else if (arr[j] < b)
        j++;
      else if (arr[j] > b)
        j--;
    }
    return j;
  }
  var arr = [1, 3, 16, 22, 31, 33, 34];
  console.log(search(arr, 31));
}

//1.17
{
  function isogramCheck(a) {
    var k = 0;
    for (var i = 0; i < a.length; i++) {
      for (var j = 0; j < a.length; j++)
        if (a[i] == a[j])
          k++;
      if (k > 1)
        break;
    }
    if (k > 1)
      return false;
    else
      return true;
  }
  var output = isogramCheck("123456");
  if (output)
    console.log("Ізограма")
  else
    console.log("Не ізограма");
}

//1.18
{
  function checkForPalindrom(c) {
    var a = '' + c;
    var k = 0;
    var j = a.length - 1;
    if (a.length % 2 == 0) {
      for (var i = 0; i < a.length / 2; i++) {
        if (a[i] == a[j]) {
          k++;
        }
        j--;
      }
      if (k == a.length / 2)
        console.log(a + " - palindrom ");
    } else {
      for (var i = 0; i < (a.length - 1) / 2; i++) {
        if (a[i] == a[j]) {
          k++;
        }
        else break;
        j--;
      }
      if (k == (a.length - 1) / 2)
        console.log(a + " - palindrom ");
    }
  }
  function checkForPalindromInSentence(a) {
    var b = a.split(' ');
    for (var i = 0; i < b.length; i++) {
      checkForPalindrom(b[i]);
    }
  }
  checkForPalindromInSentence('hi me name is palindrom 12321')
}
