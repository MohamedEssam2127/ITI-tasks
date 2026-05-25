import { Box, Typography, Paper } from '@mui/material'

export default function FeaturesSection() {
  return (
    <Box sx={{ width: '100%', textAlign: 'center', backgroundImage: 'linear-gradient(90deg, #00d4ff 0%, #1e90ff 100%)', py: 6 }}>
      <Paper
        elevation={0}
        sx={{
          display: 'inline-block',
          width: '30%',
          bgcolor: 'transparent',
          color: 'white',
          verticalAlign: 'top'
        }}
      >
        <Typography variant="h5" sx={{ mb: 1, fontWeight: 'bold' }}>Speed ⚡</Typography>
        <Typography variant="body2">Amazing experience with modern UI</Typography>
      </Paper>

      <Paper
        elevation={0}
        sx={{
          display: 'inline-block',
          width: '30%',
          bgcolor: 'transparent',
          color: 'white',
          verticalAlign: 'top'
        }}
      >
        <Typography variant="h5" sx={{ mb: 1, fontWeight: 'bold' }}>Design 🎨</Typography>
        <Typography variant="body2">Amazing experience with modern UI</Typography>
      </Paper>

      <Paper
        elevation={0}
        sx={{
          display: 'inline-block',
          width: '30%',
          bgcolor: 'transparent',
          color: 'white',
          verticalAlign: 'top'
        }}
      >
        <Typography variant="h5" sx={{ mb: 1, fontWeight: 'bold' }}>Responsive 📱</Typography>
        <Typography variant="body2">Amazing experience with modern UI</Typography>
      </Paper>
    </Box>
  )
}