const input = document.getElementById('input')
const result = document.getElementById('result')
const sortBtn = document.getElementById('sortBtn')

const quickSort = arr => {
  if (arr.length < 2) return arr
  const pivot = arr[Math.floor(arr.length / 2)]
  const left = []
  const right = []
  const equal = []
  for (const n of arr) {
    if (n < pivot) left.push(n)
    else if (n > pivot) right.push(n)
    else equal.push(n)
  }
  return [...quickSort(left), ...equal, ...quickSort(right)]
}

const parseNumbers = value => value
  .split(',')
  .map(item => item.trim())
  .filter(Boolean)
  .map(Number)
  .filter(num => !Number.isNaN(num))

const render = values => {
  if (values.length) {
    result.textContent = values.join(', ')
    return
  }
  result.textContent = input.value.trim() ? 'No valid numbers' : 'Enter numbers to sort'
}

const handleSort = () => {
  const values = parseNumbers(input.value)
  render(quickSort(values))
}

sortBtn.addEventListener('click', handleSort)
input.addEventListener('keydown', event => {
  if (event.key === 'Enter') handleSort()
})