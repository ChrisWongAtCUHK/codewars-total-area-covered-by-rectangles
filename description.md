Your task in order to complete this Kata is to write a function which calculates the area covered by a <a href='https://en.wikipedia.org/wiki/Union_(set_theory)'>union</a> of rectangles.<br>
Rectangles can have <b> non-empty intersection</b>, in this way simple solution:
S<sub>all</sub> = S<sub>1</sub> + S<sub>2</sub> + ... + S<sub>n-1</sub> + S<sub>n</sub> (where n - the quantity of rectangles) <b> will not work.</b> 

### Preconditions
*   each rectangle is represented as: [x<sub>0</sub>, y<sub>0</sub>, x<sub>1</sub>, y<sub>1</sub>]
*  (x<sub>0</sub>, y<sub>0</sub>) - coordinates of the bottom left corner
*  (x<sub>1</sub>, y<sub>1</sub>) - coordinates of the top right corner
*  x<sub>i</sub>, y<sub>i</sub> - `positive integers or zeroes` (0, 1, 2, 3, 4..)
* sides of rectangles are `parallel to coordinate axes`
* your input data is array of rectangles

### Requirements

* Number of rectangles in one test (not including simple tests) range from `3000 to 15000.` There are `10 tests` with such range. So, your algorithm should be optimal.
* Sizes of the rectangles can reach values like 1e6.


### Example
<div>
<img src="https://s33.postimg.cc/nf3brdckv/111.png">
</div>

There are three rectangles: 
* R1: [3,3,8,5], with area 10
* R2: [6,3,8,9], with area 12
* R3: [11,6,14,12], with area 18
* R1 and R2 are overlapping (2x2), the grayed area is removed from the total area

Hence the total area is `10 + 12 + 18 - 4 = 36`

---

Note: expected time complexity: something around O(N²), but with a good enough constant factor. If you think about using something better, try this kata instead: [Total area covered by more rectangles](https://www.codewars.com/kata/6425a1463b7dd0001c95fad4)

