import { Typography, Stack, Box } from "@mui/material";

export default function AboutUs() {
  return (
    <Stack
      direction={{ xs: 'column', md: 'row' }}
      spacing={{ xs: 4, md: 8 }}
      sx={{
        px: { xs: 3, lg: 16 },
        pt: { xs: 8, md: 12 },
        pb: { xs: 4, md: 6 },
        boxSizing: 'border-box',
        alignItems: 'center',
        bgcolor: '#fbfbfb',
        
      }}
    >
      <Box 
        component="img"
        src="https://images.unsplash.com/photo-1517248135467-4c7edcad34c4?ixlib=rb-4.0.3&auto=format&fit=crop&w=800&q=80"
        alt="About Us"
        sx={{
          width: { xs: '100%', md: '40%' },
          borderRadius: 2,
          objectFit: 'cover',
          boxShadow: 3
        }}
      />
      <Stack 
        sx={{ 
          width: { xs: '100%', md: '60%' },
          alignItems: 'flex-start',
          textAlign: 'left'
        }}
      >
        <Typography variant="h4" sx={{ fontWeight: 'bold', mb: 2, color: '#333' }}>
          About Us
        </Typography>
        <Typography 
          variant="body1" 
          sx={{ 
            lineHeight: 1.8, 
            color: '#555', 
            fontSize: { xs: '1rem', md: '1.125rem' } 
          }}
        >
          We are a family-owned restaurant dedicated to serving delicious, high-quality meals made from fresh, locally sourced ingredients. Our mission is to provide an unforgettable dining experience for every guest.
        </Typography>
      </Stack>
    </Stack>
  );
}
