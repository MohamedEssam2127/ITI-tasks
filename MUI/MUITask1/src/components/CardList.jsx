import { Box } from '@mui/material'
import SpiderCard from './SpiderCard'

export default function CardList() {
  const cards = [1, 2, 3, 4, 5, 6]

  return (
    <Box
      sx={{
        bgcolor: '#0e0d0dff',
        px: 4,
        py: 6,
        display: 'grid',
        gridTemplateColumns: 'repeat(3, 1fr)',
        gap: 3
      }}
    >
      {cards.map((num) => (
        <SpiderCard key={num} title={`Spider Card ${num}`} />
      ))}
    </Box>
  )
}