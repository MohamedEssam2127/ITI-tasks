# QuickSort Implementation

## Function Overview

The `quickSort` function sorts an array of numbers using recursion and partitioning. It returns a new sorted array without mutating the original input.

## Pivot Selection

- The pivot is chosen from the middle of the array:
  - `const pivot = arr[Math.floor(arr.length / 2)]`
- This picks the element at index `Math.floor(arr.length / 2)`.
- Using the middle element is a simple heuristic that often yields balanced partitions.

## Partitioning Logic

The array is processed with a loop:

- `for (const n of arr) { ... }`

Each number `n` is compared to the pivot:

- If `n < pivot`, it goes into `left`
- If `n > pivot`, it goes into `right`
- If `n === pivot`, it goes into `equal`

This divides the array into three groups based on comparison with the pivot.

## Purpose of `left`, `right`, and `equal`

- `left`
  - Holds all values smaller than the pivot
  - These values must come before the pivot in sorted order

- `right`
  - Holds all values larger than the pivot
  - These values come after the pivot in sorted order

- `equal`
  - Holds all values equal to the pivot
  - This handles duplicates safely and preserves them correctly

## Recursive Sorting and Final Result

After partitioning, the function returns:

- `quickSort(left).concat(equal, quickSort(right))`

This means:

1. Sort the `left` partition recursively
2. Keep the pivot values in `equal`
3. Sort the `right` partition recursively
4. Join them in order: sorted `left`, then `equal`, then sorted `right`

## Base Case

- `if (arr.length < 2) return arr`
- If the array has 0 or 1 element, it is already sorted
- Recursion stops here

## Why This Works

- Each recursive call sorts a smaller subset
- The pivot divides the array into smaller pieces
- Combining sorted partitions yields a fully sorted array
- The `equal` array ensures duplicate pivot values are preserved and not lost during partitioning
