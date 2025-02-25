# CS Challenge 2025 - 1
This repository contains all of my solutions for the computer science challenge, developed in c#,
the code works exclusively on the leetcode platform, for a detailed review of my submissions you can access my [leetcode profile].

[leetcode profile]: https://leetcode.com/u/Mateoskix/

## Roman to Integer

### Explanation
The main goal of this problem is to create an algorithm that transforms valid Roman numeral strings into integers. I implemented a dictionary to store the reference values for Roman numerals (e.g., 'I' → 1, 'V' → 5, 'M' → 1000, etc.). Originally, I thought that the best way to explain the relationship between Roman numerals when processing them was based on whether they were divisible by 5. This logic worked well, except when a numeral ended with 'I'. I then asked ChatGPT for an approach that could cover all cases. It suggested using a "greater than" logic to compare the current index with the next one. Finally, I modified the code to check whether the next position is within the string and if the value to the right is greater than the current value (e.g., in "IV"). In that case, the algorithm subtracts the current value; otherwise, it adds it.

### Performance
We loop through the string once and perform constant-time operations with constant values therefore we have:
* Time: O(n)
* Space: O(1)

Leetcode provided the following metrics:

![Metrics](Screenshots/rti1.png)

<details><summary><b>Show metrics in-depth</b></summary>

* Runtime:

![Runtime](Screenshots/rti2.png)

* Memory:

![Memory](Screenshots/rti3.png)

</details>

## Reverse Linked List 1

### Explanation
### Performance

Leetcode provided the following metrics:

![Metrics](Screenshots/rll1-1.png)

<details><summary><b>Show metrics in-depth</b></summary>

* Runtime:

![Runtime](Screenshots/rll1-2.png)

* Memory:

![Memory](Screenshots/rll1-3.png)

</details>

## Reverse Linked List 2

### Explanation
### Performance

Leetcode provided the following metrics:

![Metrics](Screenshots/rll2-1.png)

<details><summary><b>Show metrics in-depth</b></summary>

* Runtime:

![Runtime](Screenshots/rll2-2.png)

* Memory:

![Memory](Screenshots/rll2-3.png)

</details>

## Reverse Words in a String

### Explanation
### Performance

Leetcode provided the following metrics:

![Metrics](Screenshots/rwis1.png)

<details><summary><b>Show metrics in-depth</b></summary>

* Runtime:

![Runtime](Screenshots/rwis2.png)

* Memory:

![Memory](Screenshots/rwis3.png)

</details>

## Subsets

### Explanation
### Performance

Leetcode provided the following metrics:

![Metrics](Screenshots/s1.png)

<details><summary><b>Show metrics in-depth</b></summary>

* Runtime:

![Runtime](Screenshots/s2.png)

* Memory:

![Memory](Screenshots/s3.png)

</details>

## Longest Valid Parentheses

### Explanation
### Performance

Leetcode provided the following metrics:

![Metrics](Screenshots/lvp1.png)

<details><summary><b>Show metrics in-depth</b></summary>

* Runtime:

![Runtime](Screenshots/lvp2.png)

* Memory:

![Memory](Screenshots/lvp3.png)

</details>

## Rotate Image

### Explanation
### Performance

Leetcode provided the following metrics:

![Metrics](Screenshots/ri1.png)

<details><summary><b>Show metrics in-depth</b></summary>

* Runtime:

![Runtime](Screenshots/ri2.png)

* Memory:

![Memory](Screenshots/ri3.png)

</details>