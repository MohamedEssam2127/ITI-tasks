import { Box, Button, Typography } from '@mui/material'

export default function MyHeader() {
  return (
    <Box sx={{ bgcolor: '#f4f4f4', height: 75, width: '100%' , boxShadow: '0 8px 20px -8px rgba(0,0,0,0.5)'}}>
      <Typography
        variant="h6"
        sx={{
          display: 'inline-block',
          color: 'black',
          lineHeight: '80px',
          ml: 4,
          fontSize:32
        }}
      >
        Spider UI
      </Typography>
      
      <Button
        variant="contained"
        sx={{
          display: 'inline-block',
          float: 'right',
          mt: 2.5,
          mr: 4,
          bgcolor: 'black',
          color: 'white',
        }}
      >
        LOGIN
      </Button>
    </Box>
  )
}