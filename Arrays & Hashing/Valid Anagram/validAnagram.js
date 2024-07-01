// Solution-1: Harfleri Sıralayarak Karşılaştırma
function isAnagram(s, t) {
  if (s.length !== t.length) {
    return false;
  }

  return s.split("").sort().join("") === t.split("").sort().join("");
}

// Testler
console.log(isAnagram("anagram", "nagaram")); // true
console.log(isAnagram("rat", "car")); // false

// Solution-2: Harfleri Sayarak Karşılaştırma
function isAnagram(s, t) {
  if (s.length !== t.length) {
    return false;
  }

  let count = {};

  for (let char of s) {
    count[char] = (count[char] || 0) + 1;
  }

  for (let char of t) {
    if (!count[char]) {
      return false;
    }
    count[char]--;
  }

  return true;
}

// Testler
console.log(isAnagram("anagram", "nagaram")); // true
console.log(isAnagram("rat", "car")); // false
