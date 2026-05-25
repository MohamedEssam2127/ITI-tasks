import { Stack, Typography, Button, Box } from "@mui/material";
import heroImg from '../assets/Restaurant.webp';

export default function Hero() {
  return (
    <Stack
      sx={{
        backgroundImage: `url(${heroImg})`,
        backgroundSize: 'cover',
        backgroundPosition: 'center',
        width: '100%',
        minHeight: '80vh',
        position: 'relative',
        alignItems: 'center',
        justifyContent: 'center',
        px: { xs: 3, lg: 16 },
        boxSizing: "border-box",
      }}
    >
      <Box
        sx={{
          position: 'absolute',
          top: 0,
          left: 0,
          right: 0,
          bottom: 0,
          backgroundColor: 'rgba(0, 0, 0, 0.6)',
          zIndex: 1,
        }}
      />
      <Stack
        sx={{
          position: 'relative',
          zIndex: 2,
          textAlign: 'center',
          color: '#FFFFFF',
          alignItems: 'center',
          gap: 2,
        }}
      >
        <Typography 
          variant="h2" 
          sx={{ 
            fontFamily: 'sans-serif', 
            fontWeight: 'bold',
            fontSize: { xs: '2.5rem', md: '3.75rem' } 
          }}
        >
          Welcome to Our Restaurant
        </Typography>
        <Typography 
          variant="h5" 
          sx={{ 
            fontFamily: 'sans-serif',
            fontSize: { xs: '1.2rem', md: '1.5rem' },
            mb: 2
          }}
        >
          Delicious food served with love
        </Typography>
        <Button 
          variant="contained" 
          size="large" 
          sx={{ 
            textTransform: 'none', 
            fontWeight: 'bold',
            bgcolor: '#1976d2',
            '&:hover': {
              bgcolor: '#115293',
            },
            px: 4,
            py: 1.5,
            fontSize: '1.1rem'
          }}
        >
          View Menu
        </Button>
      </Stack>
    </Stack>
  );
}
