import { Box, Button, Typography } from '@mui/material'
import spiderMan from '../assets/Venom.png'

export default function HeroSection() {
  return (
    <Box
      sx={{
        backgroundImage: `url(${spiderMan})`,
        backgroundSize: 'cover',
        backgroundPosition: 'center',
        height: 300,
        textAlign: 'center',
        pt: 20
      }}
    >
      <Typography
        variant="h2"
        component="h1"
        sx={{
          color: 'white',
          mb: 4,
          fontWeight: 'bold'
        }}
      >
        Welcome Hero 🕸️
      </Typography>
      
      <Button
        variant="contained"
        sx={{
          px: 4,
          py: 1.5,
          fontWeight: 'bold',
          backgroundImage: 'linear-gradient(45deg, #00d4ff 30%, #9c27b0 90%)'
        }}
      >
        GET STARTED
      </Button>
    </Box>
  )
}